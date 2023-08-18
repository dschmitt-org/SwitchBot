namespace SwitchBot.Options;
public class SwitchBotRestOptions
{
    /// <summary>
    /// Default options for new clients
    /// </summary>
    public static SwitchBotRestOptions Default { get; set; } = new SwitchBotRestOptions()
    {
        Timeout = TimeSpan.FromSeconds(5),
    };

    public TimeSpan Timeout { get; set; }

    public string Token { get; set; }

    public string Secret { get; set; }
}