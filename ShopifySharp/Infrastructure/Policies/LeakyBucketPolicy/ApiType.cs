namespace ShopifySharp.Infrastructure.Policies.LeakyBucketPolicy;

internal enum ApiType : byte
{
    RestAdmin,
    GraphQlAdmin,
    GraphQlPartner,
}
