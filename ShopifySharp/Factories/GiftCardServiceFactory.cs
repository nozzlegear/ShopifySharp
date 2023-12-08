using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IGiftCardServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IGiftCardService Create(ShopifyRestApiCredentials credentials);
}

public class GiftCardServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IGiftCardServiceFactory
{
    public virtual IGiftCardService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new GiftCardService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
