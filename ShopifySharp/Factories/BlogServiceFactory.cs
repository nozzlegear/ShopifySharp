#if NETSTANDARD2_0
#nullable disable
#else
#nullable enable
#endif

using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IBlogServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IBlogService Create(ShopifyRestApiCredentials credentials);
}

public class BlogServiceFactory(
    #if NETSTANDARD2_0
    IRequestExecutionPolicy requestExecutionPolicy = null
    #else
    IRequestExecutionPolicy? requestExecutionPolicy = null
    #endif
) : IBlogServiceFactory
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
