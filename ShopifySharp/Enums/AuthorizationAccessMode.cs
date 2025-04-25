#nullable enable
namespace ShopifySharp.Enums;

public enum AuthorizationAccessMode
{
    /// <summary>
    /// The default, permanent access token mode scoped to the full permissions the shop grants to your app.
    /// </summary>
    Offline = 1,
    /// <summary>
    /// The temporary, online access token mode scoped to a single shop staff user and the permissions they hold on the shop.
    /// Alternately referred to as "Per-User" in Shopify's documentation.
    /// </summary>
    Online = 2,
}
