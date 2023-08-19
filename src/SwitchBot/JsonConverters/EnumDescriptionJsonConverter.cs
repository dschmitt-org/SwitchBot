using EnumsNET;
using Newtonsoft.Json;

namespace SwitchBot.JsonConverters;
internal class EnumDescriptionJsonConverter<TEnum> : JsonConverter<TEnum>
    where TEnum : struct, Enum
{
    public override TEnum ReadJson(JsonReader reader, Type objectType, TEnum existingValue, bool hasExistingValue, JsonSerializer serializer)
    {
        var enumDescription = reader.Value as string;

        var enumInstance = (TEnum)Enums.Parse(typeof(TEnum), enumDescription, ignoreCase: false, EnumFormat.Description);

        return enumInstance;
    }

    public override void WriteJson(JsonWriter writer, TEnum value, JsonSerializer serializer)
    {
        writer.WriteValue(value.AsString(EnumFormat.Description));
    }
}
