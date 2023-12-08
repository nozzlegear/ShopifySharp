using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IArticleServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IArticleService Create(ShopifyRestApiCredentials credentials);
}

public class ArticleServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IArticleServiceFactory
{
    public virtual IArticleService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new ArticleService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
