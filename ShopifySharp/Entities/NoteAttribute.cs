using Newtonsoft.Json;

namespace ShopifySharp;

/// <summary>
/// An object representing a note attribute for <see cref="Order.NoteAttributes"/>
/// </summary>
public class NoteAttribute
{
    /// <summary>
    /// The name of the note attribute.
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// The value of the note attribute.
    /// </summary>
    [JsonProperty("value")]
    public object Value { get; set; }
}