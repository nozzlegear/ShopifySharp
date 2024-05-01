#nullable enable
using System.Collections.Generic;
using ShopifySharp.GraphQL;

namespace ShopifySharp;

public class ParsedGraphResult<T>
{
    public T? Data { get; set; }

    public ICollection<UserError>? UserErrors { get; set; }

    public GraphExtensions? Extensions { get; set; }
}
