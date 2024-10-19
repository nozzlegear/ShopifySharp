#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace ShopifySharp.Graph;

[Serializable]
public record GraphUserError
{
    /// The path to the input field that caused the error.
    [JsonPropertyName("field")]
    public ICollection<string> Field { get; set; } = [];

    /// The error message.
    [JsonPropertyName("message")]
    public string Message { get; set; } = string.Empty;

    [JsonPropertyName("code")]
    public string? Code { get; set; }
}
