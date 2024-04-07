#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ShopifySharp.Graph;

[Serializable]
public class GraphUserError
{
    /// The path to the input field that caused the error.
    [JsonProperty("field"), JsonPropertyName("field")]
    public IEnumerable<string>? Field { get; set; }
    /// The error message.
    [JsonProperty("message"), JsonPropertyName("message")]
    public string? Message { get; set; }
}
