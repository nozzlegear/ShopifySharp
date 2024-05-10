using Newtonsoft.Json;

namespace ShopifySharp;

public class OptionValue
{
    /// <summary>
    /// Custom property option id 
    /// </summary>
    [JsonProperty("option_id")]
    public long OptionId { get; set; }

    /// <summary>
    /// Custom property option name
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// Custom property option value
    /// </summary>
    [JsonProperty("value")]
    public string Value { get; set; }
}