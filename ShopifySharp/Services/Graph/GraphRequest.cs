#nullable enable
using System.Collections.Generic;
using ShopifySharp.Services.Graph;

namespace ShopifySharp;

// TODO: move this to ShopifySharp.Services.Graph namespace
public class GraphRequest
{
    #if NET8_0_OR_GREATER
    [System.Diagnostics.CodeAnalysis.StringSyntax("graphql")]
    #endif
    public string Query { get; set; } = "";

    public IDictionary<string, object>? Variables { get; set; }

    /// <summary>
    /// What you estimate this query will cost. Use this value to provide an estimated query cost to any <see cref="IRequestExecutionPolicy" />, to avoid sending a request that will be throttled. This value can be found in the query response data at <c>extensions.cost.requestedQueryCost</c>.
    /// </summary>
    public int? EstimatedQueryCost { get; set; }

    /// <summary>
    /// Tells the service whether it should throw an exception or not when it detects a `userErrors` list containing at least one error.
    /// </summary>
    public GraphRequestUserErrorHandling UserErrorHandling { get; set; } = GraphRequestUserErrorHandling.Throw;
}
