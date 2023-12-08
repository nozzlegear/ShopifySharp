using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IGraphServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IGraphService Create(ShopifyRestApiCredentials credentials);
}

public class GraphServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IGraphServiceFactory
{
    public virtual IGraphService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new GraphService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
