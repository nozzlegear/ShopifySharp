using System.Text.RegularExpressions;
using ShopifySharp.Exceptions;

namespace ShopifySharp.Entities.Identifiers;

public partial interface IShopifyGraphId
{
    public string GraphId { get; }
    public string ResourceType { get; }
    public long RestId { get; }

    #if NET6_0_OR_GREATER
    public string ToString() => GraphId;
    #else
    public string ToString();
    #endif

    public static string Format(long restId, string resourceType) =>
        $"gid://shopify/{resourceType}/{restId}";

    public static (string ResourceType, long RestId) Parse(string graphId)
    {
        var match = ShopifyGraphIdRegex().Match(graphId);
        if (!match.Success)
            throw new InvalidShopifyGraphIdException(graphId);

        return (match.Groups[1].Value, long.Parse(match.Groups[2].Value));
    }

    [GeneratedRegex("gid://shopify/(\\w+)/([0-9]+)", RegexOptions.Compiled, 500)]
    private static partial Regex ShopifyGraphIdRegex();
}
