using System.Reflection;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace SwitchBot.JsonConverters;
internal class JsonPathConverter : JsonConverter
{
    public override object ReadJson(
        JsonReader reader,
        Type objectType,
        object? existingValue,
        JsonSerializer serializer)
    {
        JObject jo = JObject.Load(reader);
        object targetObj = Activator.CreateInstance(objectType);

        foreach (PropertyInfo prop in objectType.GetProperties().Where(p => p.CanRead && p.CanWrite))
        {
            JsonPropertyAttribute att = prop.GetCustomAttributes(true).OfType<JsonPropertyAttribute>().FirstOrDefault();

            string jsonPath = att != null ? att.PropertyName : prop.Name;

            if (serializer.ContractResolver is DefaultContractResolver)
            {
                var resolver = (DefaultContractResolver)serializer.ContractResolver;
                jsonPath = resolver.GetResolvedPropertyName(jsonPath);
            }

            if (!Regex.IsMatch(jsonPath, @"^[a-zA-Z0-9_.-]+$"))
            {
                throw new InvalidOperationException($"JProperties of JsonPathConverter can have only letters, numbers, underscores, hiffens and dots but name was ${jsonPath}."); // Array operations not permitted
            }

            JToken token = jo.SelectToken(jsonPath);
            if (token != null && token.Type != JTokenType.Null)
            {
                object value = token.ToObject(prop.PropertyType, serializer);
                prop.SetValue(targetObj, value, null);
            }
        }

        return targetObj;
    }

    public override bool CanConvert(Type objectType)
    {
        // CanConvert is not called when [JsonConverter] attribute is used
        return objectType.GetCustomAttributes(true).OfType<JsonPathConverter>().Any();
    }

    public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
    {
        JObject resultJson = new();

        // Get all properties of a provided class
        IEnumerable<PropertyInfo> properties = value
            .GetType().GetRuntimeProperties().Where(p => p.CanRead && p.CanWrite);

        foreach (PropertyInfo propertyInfo in properties)
        {
            JsonPropertyAttribute propertyAttribute = propertyInfo
                .GetCustomAttributes(true)
                .OfType<JsonPropertyAttribute>()
                .FirstOrDefault();

            // Use either custom JSON property or regular property name
            string propertyJsonPath = propertyAttribute != null
                ? propertyAttribute.PropertyName
                : propertyInfo.Name;

            if (serializer.ContractResolver is DefaultContractResolver resolver)
            {
                propertyJsonPath = resolver.GetResolvedPropertyName(propertyJsonPath);
            }

            if (string.IsNullOrEmpty(propertyJsonPath))
            {
                continue;
            }

            // Split by the delimiter, and traverse according to the path
            string[] nesting = propertyJsonPath.Split('/');
            JObject lastJsonLevel = resultJson;
            for (int i = 0; i < nesting.Length; i++)
            {
                if (i == nesting.Length - 1)
                {
                    lastJsonLevel[nesting[i]] = JToken.FromObject(propertyInfo.GetValue(value));
                }
                else
                {
                    if (lastJsonLevel[nesting[i]] == null)
                    {
                        lastJsonLevel[nesting[i]] = new JObject();
                    }

                    lastJsonLevel = (JObject)lastJsonLevel[nesting[i]];
                }
            }
        }

        serializer.Serialize(writer, resultJson);
    }
}