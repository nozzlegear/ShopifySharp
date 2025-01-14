#nullable enable
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using ShopifySharp.Services.Graph;

namespace ShopifySharp;

// TODO: move this to ShopifySharp.Services.Graph namespace
public class GraphRequest
{
    private string? _query { get; set; }
    private IDictionary<string, object>? _variables { get; set; }

    [Obsolete("This property is deprecated, use " + nameof(Query) + " instead.")]
    public string? query
    {
        [ExcludeFromCodeCoverage]
        get => _query;
        set => _query = value;
    }

    [Obsolete("This property is deprecated, use " + nameof(Variables) + " instead.")]
    public object? variables
    {
        [ExcludeFromCodeCoverage]
        get => _variables;
        set => _variables = value as IDictionary<string, object> ?? value?.ToDictionary();
    }

#if NET8_0_OR_GREATER
    public required string Query
    {
        get => _query ?? "";
        set => _query = value;
    }
#else
    public string Query
    {
        get => _query ?? "";
        set => _query = value;
    }
#endif

    public IDictionary<string, object>? Variables
    {
        get => _variables;
        set => _variables = value;
    }

    /// <summary>
    /// What you estimate this query will cost. Use this value to provide an estimated query cost to any <see cref="IRequestExecutionPolicy" />, to avoid sending a request that will be throttled. This value can be found in the query response data at <c>extensions.cost.requestedQueryCost</c>.
    /// </summary>
    public int? EstimatedQueryCost { get; set; }

    /// <summary>
    /// Tells the service whether it should throw an exception or not when it detects a `userErrors` list containing at least one error.
    /// </summary>
    public GraphRequestUserErrorHandling UserErrorHandling { get; set; } = GraphRequestUserErrorHandling.Throw;
}
