#nullable enable
using System;
using System.Collections.Generic;
using ShopifySharp.Graph;

namespace ShopifySharp;

[Serializable]
public class ParsedGraphResult<T>
{
    public T? Data { get; set; }
    public ICollection<GraphUserError>? UserErrors { get; set; }
    public GraphExtensions? Extensions { get; set; }
}
