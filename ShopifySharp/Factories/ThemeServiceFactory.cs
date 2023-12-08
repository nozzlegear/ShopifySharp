using ShopifySharp.Credentials;

namespace ShopifySharp.Factories;

public interface IThemeServiceFactory
{
    // ReSharper disable once UnusedMember.Global
    IThemeService Create(ShopifyRestApiCredentials credentials);
}

public class ThemeServiceFactory(IRequestExecutionPolicy? requestExecutionPolicy = null) : IThemeServiceFactory
{
    public virtual IThemeService Create(ShopifyRestApiCredentials credentials)
    {
        var service = new ThemeService(credentials.ShopDomain, credentials.AccessToken);

        if (requestExecutionPolicy is not null)
        {
            service.SetExecutionPolicy(requestExecutionPolicy);
        }

        return service;
    }
}
