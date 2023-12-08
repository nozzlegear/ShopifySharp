using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IPageServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IPageService Create(ShopifyRestApiCredentials credentials);
}

public class PageServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IPageServiceFactory
{
    public virtual IPageService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new PageService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
