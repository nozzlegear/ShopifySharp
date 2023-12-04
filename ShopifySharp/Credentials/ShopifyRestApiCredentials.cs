#nullable enable
using System;
namespace ShopifySharp.Credentials;

public abstract class ShopifyRestApiCredentials
{
    public virtual string ShopDomain { get; }
    public virtual string AccessToken { get; }

    public ShopifyRestApiCredentials(string shopDomain, string accessToken)
    {
        ShopDomain = shopDomain;
        AccessToken = accessToken;
    }

    protected virtual bool Equals(ShopifyRestApiCredentials other)
    {
        return ShopDomain == other.ShopDomain && AccessToken == other.AccessToken;
    }

    public override bool Equals(object? obj)
    {
        return obj is ShopifyRestApiCredentials other && Equals(other);
    }

    protected virtual int ComputeHashCode()
    {
#if NETSTANDARD2_0
        return (ShopDomain, AccessToken).GetHashCode();
#else
        return HashCode.Combine(ShopDomain, AccessToken);
#endif
    }

    public override int GetHashCode()
    {
        return ComputeHashCode();
    }
}

