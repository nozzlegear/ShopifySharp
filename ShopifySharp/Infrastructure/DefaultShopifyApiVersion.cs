namespace ShopifySharp.Infrastructure;

public sealed record DefaultShopifyApiVersion : IShopifyApiVersion
{
    public const string DefaultVersion = "2026-01";
    public string Version => DefaultVersion;
}
