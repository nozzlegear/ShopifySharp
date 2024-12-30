#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using ShopifySharp.Services.Graph;

namespace ShopifySharp;

[Serializable]
public class ShopifyGraphUserErrorsException(
    ICollection<GraphUserError> graphUserErrors,
    string? requestId = null,
    // GraphRequestCostExtension? requestCost = null,
    Exception? innerException = null)
    : ShopifyException(FormatMessage(graphUserErrors), innerException)
{
    public ICollection<GraphUserError> GraphUserErrors { get; } = graphUserErrors;

    public string? RequestId { get; } = requestId;

    // TODO: add support for parsing request cost and passing to exception
    // public GraphRequestCostExtension? GraphCost { get; } = graphCost;

    private static string FormatMessage(ICollection<GraphUserError> graphUserErrors)
    {
        var firstError = graphUserErrors.FirstOrDefault();

        if (!string.IsNullOrWhiteSpace(firstError?.Code))
            return $"{firstError.Code}: {firstError.Message}";

        if (!string.IsNullOrWhiteSpace(firstError?.Message))
            return firstError.Message;

        return "GraphQL operation returned one or more errors.";
    }
}
