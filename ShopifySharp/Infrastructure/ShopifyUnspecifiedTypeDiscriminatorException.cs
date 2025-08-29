#nullable enable
using System;

namespace ShopifySharp;

[Serializable]
public class ShopifyUnspecifiedTypeDiscriminatorException(
    Type rootType,
    string? jsonPath = null,
    Type? offendingType = null,
    string? requestId = null,
    Exception? innerException = null)
    : ShopifyJsonParseException(BuildMessage(rootType, jsonPath, offendingType),
        jsonPath,
        requestId,
        innerException)
{
    public Type RootType { get; } = rootType;
    public Type? OffendingType { get; } = offendingType;
    public string? JsonPath { get; } = jsonPath;

    private static string BuildMessage(Type rootType, string? jsonPath, Type? offendingType)
    {
        var root = rootType.FullName ?? rootType.Name;
        var offending = offendingType != null ? $" '{offendingType.FullName}'" : string.Empty;
        var path = !string.IsNullOrWhiteSpace(jsonPath) ? $" at JSON path '{jsonPath}'" : string.Empty;

        return
            $"Deserialization of '{root}' failed. " +
            $"The JSON payload for the GraphQL union or interface type{offending}{path} " +
            "does not include the required type discriminator ('__typename'). " +
            "Add '__typename' to your query selection for this type to enable polymorphic deserialization.";
    }
}
