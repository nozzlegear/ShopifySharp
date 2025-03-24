using System.Text.RegularExpressions;
using ShopifySharp.Infrastructure;

namespace ShopifySharp.Identifiers;

internal static partial class ShopifyGraphIdUtil
{
    public static long Parse(string graphId)
    {
        #if NETSTANDARD2_0
        var regex = new Regex("gid://shopify/\\w+/([0-9]+)", RegexOptions.Compiled, System.TimeSpan.FromMilliseconds(500));
        #else
        var regex = ShopifyGraphIdRegex();
        #endif
        var match = regex.Match(graphId);
        if (!match.Success)
            throw new InvalidShopifyGraphIdException(graphId);

        return long.Parse(match.Groups[1].Value);
    }

    #if NET6_0_OR_GREATER
    [GeneratedRegex("gid://shopify/\\w+/([0-9]+)", RegexOptions.Compiled, 500)]
    private static partial Regex ShopifyGraphIdRegex();
    #endif
}
