namespace ShopifySharp.Infrastructure;

public sealed record DefaultShopifyApiVersion : IShopifyApiVersion
{
    public const string DefaultVersion = "2026-07";

    public string Version => DefaultVersion;
}
