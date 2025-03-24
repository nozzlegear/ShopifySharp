using System;

namespace ShopifySharp.Infrastructure;

[Serializable]
public class InvalidShopifyGraphIdException(string graphId)
    : ShopifyException($"Failed to parse string \"{graphId}\" into a valid Shopify Graph ID.")
{
    public string GraphId { get; } = graphId;
}
