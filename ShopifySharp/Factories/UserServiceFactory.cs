using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IUserServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IUserService Create(ShopifyRestApiCredentials credentials);
}

public class UserServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IUserServiceFactory
{
    public virtual IUserService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new UserService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
