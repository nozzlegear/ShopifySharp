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
    [JsonPropertyName("field")]
    public IEnumerable<string> Field { get; set; } = [];
    /// The error message.
    [JsonPropertyName("message")]
    public string Message { get; set; } = string.Empty;
    [JsonPropertyName("code")]
    public string? Code { get; set; }
}
