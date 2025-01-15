#nullable enable
using System;
using System.Collections.Generic;
using ShopifySharp.Services.Graph;

namespace ShopifySharp;

/// <summary>
/// <p>
/// An exception thrown when the response to a mutation or query contains additional details about the request itself
/// for the developer to fix or debug. This occurs primarily due to issues with the mutation/query that must be fixed
/// by the developer, including issues such as missing parameters, missing variables, or invalid types.
/// </p>
/// <p>
/// This exception is distinct from the <see cref="ShopifyGraphUserErrorsException"/>, which is thrown when the response
/// to a mutation contains additional details for the user to fix or debug.
/// </p>
/// </summary>
[Serializable]
public class ShopifyGraphErrorsException(
    IReadOnlyList<GraphError> graphErrors,
    string? requestId,
    // GraphRequestCostExtension? requestCost = null,
    Exception? innerException = null)
    : ShopifyException(FormatMessage(graphErrors), innerException)
{
    public IReadOnlyList<GraphError> GraphErrors { get; } = graphErrors;

    public string? RequestId { get; } = requestId;

    // TODO: add support for parsing request cost and passing to exception
    // public GraphRequestCostExtension? GraphCost { get; } = graphCost;

    private static string FormatMessage(IReadOnlyList<GraphError> graphErrors)
    {
        var firstError = graphErrors.Count == 0 ? null : graphErrors[0];

        if (firstError?.Extensions is { Code: not null and not "" } ext)
            return $"{ext.Code}: {firstError.Message}";

        return string.IsNullOrWhiteSpace(firstError?.Message)
            ? "GraphQL operation returned one or more errors."
            : firstError.Message;
    }
}
