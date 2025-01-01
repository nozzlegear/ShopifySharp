#nullable enable
// Notice:
// This class is auto-generated from a template. Please do not edit it or change it directly.

using ShopifySharp.Credentials;
using ShopifySharp.Utilities;

namespace ShopifySharp.Factories;

public interface IGraphServiceFactory : IServiceFactory<IGraphService>;

public class GraphServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null, IShopifyDomainUtility? shopifyDomainUtility = null) : IGraphServiceFactory
{
    /// <inheritDoc />
    public virtual IGraphService Create(string shopDomain, string accessToken)
    {
        IGraphService service = shopifyDomainUtility is null ? new GraphService(shopDomain, accessToken, null, null) : new GraphService(shopDomain, accessToken, shopifyDomainUtility);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }

    /// <inheritDoc />
    public virtual IGraphService Create(ShopifyApiCredentials credentials) =>
        Create(credentials.ShopDomain, credentials.AccessToken);
}
