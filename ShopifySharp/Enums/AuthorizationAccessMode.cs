#nullable enable
namespace ShopifySharp.Enums;

public enum AuthorizationAccessMode
{
    Offline = 1,
    /// <summary>
    /// Alternately referred to as "Per-User" in Shopify's documentation.
    /// </summary>
    Online = 2,
}
