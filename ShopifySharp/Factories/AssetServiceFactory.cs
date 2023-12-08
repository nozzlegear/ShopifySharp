using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IAssetServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IAssetService Create(ShopifyRestApiCredentials credentials);
}

public class AssetServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IAssetServiceFactory
{
    public virtual IAssetService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new AssetService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
