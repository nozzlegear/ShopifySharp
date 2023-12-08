using System;

namespace ShopifySharp.Credentials
{
    public readonly struct ShopifyRestApiCredentials
    {
        public string ShopDomain { get; }
        public string AccessToken { get; }

        public ShopifyRestApiCredentials(string shopDomain, string accessToken)
        {
            ShopDomain = shopDomain;
            AccessToken = accessToken;
        }

        #if NETSTANDARD2_0
        public override bool Equals(object obj)
        {
            return obj is ShopifyRestApiCredentials other
                && ShopDomain == other.ShopDomain
                && AccessToken == other.AccessToken;
        }
        #else
        #nullable enable
        public override bool Equals(object? obj)
        {
            return obj is ShopifyRestApiCredentials other
                && ShopDomain == other.ShopDomain
                && AccessToken == other.AccessToken;
        }
        #nullable disable
        #endif

        public override int GetHashCode()
        {
            #if NETSTANDARD2_0
            return (ShopDomain, AccessToken).GetHashCode();
            #else
            return HashCode.Combine(ShopDomain, AccessToken);
            #endif
        }
    }
}
