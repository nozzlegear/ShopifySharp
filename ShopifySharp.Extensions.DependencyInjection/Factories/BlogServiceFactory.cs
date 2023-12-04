using ShopifySharp.Credentials;

namespace ShopifySharp.Extensions.DependencyInjection.Factories;

public interface IBlogServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IBlogService Create(ShopifyRestApiCredentials credentials);
}

public class BlogServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IBlogServiceFactory
{
    public virtual IBlogService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new BlogService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
