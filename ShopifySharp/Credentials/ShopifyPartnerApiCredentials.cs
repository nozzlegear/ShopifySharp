#nullable enable
using System;

namespace ShopifySharp.Credentials;

public abstract class ShopifyPartnerApiCredentials
{
    public virtual long PartnerOrganizationId { get; }
    public virtual string AccessToken { get; }

    public ShopifyPartnerApiCredentials(long partnerOrganizationId, string accessToken)
    {
        PartnerOrganizationId = partnerOrganizationId;
        AccessToken = accessToken;
    }

    protected virtual bool Equals(ShopifyPartnerApiCredentials other)
    {
        return PartnerOrganizationId == other.PartnerOrganizationId && AccessToken == other.AccessToken;
    }

    public override bool Equals(object? obj)
    {
        return obj is ShopifyPartnerApiCredentials other && Equals(other);
    }

    protected virtual int ComputeHashCode()
    {
#if NETSTANDARD2_0
        return (PartnerOrganizationId, AccessToken).GetHashCode();
#else
        return HashCode.Combine(PartnerOrganizationId, AccessToken);
#endif
    }

    public override int GetHashCode()
    {
        return ComputeHashCode();
    }
}

