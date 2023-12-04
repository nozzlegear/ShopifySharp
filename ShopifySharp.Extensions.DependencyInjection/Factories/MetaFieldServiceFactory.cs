using ShopifySharp.Credentials;

namespace ShopifySharp.Extensions.DependencyInjection.Factories;

public interface IMetaFieldServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IMetaFieldService Create(ShopifyRestApiCredentials credentials);
}

public class MetaFieldServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IMetaFieldServiceFactory
{
    public virtual IMetaFieldService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new MetaFieldService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
