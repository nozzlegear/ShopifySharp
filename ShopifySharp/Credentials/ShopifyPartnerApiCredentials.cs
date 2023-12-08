using System;

namespace ShopifySharp.Credentials
{
    public readonly struct ShopifyPartnerApiCredentials
    {
        public long PartnerOrganizationId { get; }
        public string AccessToken { get; }

        public ShopifyPartnerApiCredentials(long partnerOrganizationId, string accessToken)
        {
            PartnerOrganizationId = partnerOrganizationId;
            AccessToken = accessToken;
        }

        #if NETSTANDARD2_0
        public override bool Equals(object obj)
        {
            return obj is ShopifyPartnerApiCredentials other
                && PartnerOrganizationId == other.PartnerOrganizationId
                && AccessToken == other.AccessToken;
        }
        #else
        #nullable enable
        public override bool Equals(object? obj)
        {
            return obj is ShopifyPartnerApiCredentials other
                && PartnerOrganizationId == other.PartnerOrganizationId
                && AccessToken == other.AccessToken;
        }
        #nullable disable
        #endif

        public override int GetHashCode()
        {
            #if NETSTANDARD2_0
            return (PartnerOrganizationId, AccessToken).GetHashCode();
            #else
            return HashCode.Combine(PartnerOrganizationId, AccessToken);
            #endif
        }
    }
}
