#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IPartnerServiceFactory
{
    /// Creates a new instance of the <see cref="IPartnerService" /> with the given credentials.
    /// <param name="partnerOrganizationId">Your Shopify Partner organization ID. This can be found on your Shopify Partner account settings page.</param>
    /// <param name="accessToken">An API access token for the shop.</param>
    IPartnerService Create(long partnerOrganizationId, string accessToken);

    /// Creates a new instance of the <see cref="IPartnerService" /> with the given credentials.
    /// <param name="credentials">Credentials for authenticating with the Shopify API.</param>
    IPartnerService Create(ShopifyPartnerApiCredentials credentials);
}

public class PartnerServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IPartnerServiceFactory
{
    /// <inheritDoc />
    public virtual IPartnerService Create(long partnerOrganizationId, string accessToken)
    {
        var service = new PartnerService(partnerOrganizationId, accessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IPartnerService Create(ShopifyPartnerApiCredentials credentials) =>
        Create(credentials.PartnerOrganizationId, credentials.AccessToken);
}
