#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using ShopifySharp.Graph;

namespace ShopifySharp;

[Serializable]
public class ParsedGraphResult<T>
{
    [JsonProperty("data"), JsonPropertyName("data")]
    public T? Data { get; set; }

    [JsonProperty("userErrors"), JsonPropertyName("userErrors")]
    public ICollection<GraphUserError>? UserErrors { get; set; }
}
