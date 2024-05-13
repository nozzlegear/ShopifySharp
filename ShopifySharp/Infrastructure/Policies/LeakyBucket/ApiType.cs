namespace ShopifySharp.Infrastructure.Policies.LeakyBucket;

internal enum ApiType : byte
{
    RestAdmin,
    GraphQlAdmin,
    GraphQlPartner,
}
