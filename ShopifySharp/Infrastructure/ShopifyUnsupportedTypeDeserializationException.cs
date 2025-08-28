#nullable enable
using System;

namespace ShopifySharp;

[Serializable]
public class ShopifyUnsupportedTypeDeserializationException(
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
        var offending = offendingType != null ? $": '{offendingType.FullName}'" : string.Empty;
        var path = !string.IsNullOrWhiteSpace(jsonPath) ? $" at JSON path '{jsonPath}'" : string.Empty;

        return
            $"Deserialization of '{root}' failed. " +
            $"An unsupported abstract or interface type was encountered{offending}{path}. " +
            "This typically indicates a Shopify API version mismatch or missing polymorphic configuration " +
            "attributes (e.g., [JsonDerivedType]/[JsonPolymorphic]) on a custom return type.";
    }

    internal static Type? TryGetOffendingTypeFromMessage(NotSupportedException exn)
    {
        var message = exn.Message;
        // Look for `Type 'Namespace.InterfaceName'`
        var start = message.IndexOf("Type '", StringComparison.Ordinal);

        if (start < 0)
            return null;

        start += "Type '".Length;
        var end = message.IndexOf('\'', start);

        if (end < 0)
            return null;

        var typeName = message.Substring(start, end - start);

        try
        {
            return Type.GetType(typeName, throwOnError: false);
        }
        catch
        {
            return null;
        }
    }
}
