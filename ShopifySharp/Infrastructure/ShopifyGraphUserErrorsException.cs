#nullable enable
using System;
using System.Collections.Generic;
using ShopifySharp.Services.Graph;

namespace ShopifySharp;

/// <summary>
/// <p>
/// An exception thrown when the response to a mutation contains additional details for the user to fix or debug. There
/// are numerous reasons this can occur, such as insufficient API permissions; attempting to do something that isn't
/// possible (e.g. canceling an order that doesn't exist); missing or invalid parameters (e.g. creating a product
/// without supplying the title); and so on.
/// </p>
/// <p>
/// This exception is distinct from the <see cref="ShopifyGraphErrorsException"/>, which is thrown when the response
/// to a mutation/query contains additional details about a request for the developer to fix or debug.
/// </p>
/// </summary>
[Serializable]
public class ShopifyGraphUserErrorsException(
    IReadOnlyList<GraphUserError> graphUserErrors,
    string? requestId,
    // GraphRequestCostExtension? requestCost = null,
    Exception? innerException = null)
    : ShopifyException(FormatMessage(graphUserErrors), innerException)
{
    public IReadOnlyList<GraphUserError> GraphUserErrors { get; } = graphUserErrors;

    public string? RequestId { get; } = requestId;

    // TODO: add support for parsing request cost and passing to exception
    // public GraphRequestCostExtension? GraphCost { get; } = graphCost;

    private static string FormatMessage(IReadOnlyList<GraphUserError> graphUserErrors)
    {
        var firstError = graphUserErrors.Count == 0 ? null : graphUserErrors[0];

        if (!string.IsNullOrWhiteSpace(firstError?.Code))
            return $"{firstError.Code}: {firstError.Message}";

        return string.IsNullOrWhiteSpace(firstError?.Message)
            ? "GraphQL operation returned one or more user errors."
            : firstError.Message;
    }
}
