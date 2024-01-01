# ShopifySharp.Extensions.DependencyInjection

This package adds support for injecting ShopifySharp services into .NET classes using Microsoft's Dependency Injection framework. To do this, it exposes several methods that extend the [IServiceCollection interface](https://learn.microsoft.com/en-us/dotnet/api/microsoft.extensions.dependencyinjection.iservicecollection?view=dotnet-plat-ext-8.0). Microsoft's DI framework will then make the ShopifySharp services available to the rest of your code when you add the interfaces to your class constructors.

```cs
// In your Program.cs or Startup.cs file, or wherever you register your Dependency Injection services
public class DependencyInjectionExample(IServiceCollection services)
{
    // ...
    
    // Add ShopifySharp's service factories and the LeakyBucketExecutionPolicy to your DI container
    services.AddShopifySharp<LeakyBucketExecutionPolicy>(options =>
    {
        options.RequestExecutionPolicy = new LeakyBucketExecutionPolicy(); 
    });
}

// In the class where you want to use a ShopifySharp service
public class MyClass(IOrderServiceFactory orderServiceFactory)
{
    public async Task ListOrdersForUser()
    {
        var user = await DoSomethingToGetUser();
        var credentials = new ShopifyRestApiCredentials(user.ShopDomain, user.AccessToken);
        var orderService = orderServiceFactory.Create(credentials);
        
        // Because the service was created using the injected factory class, 
        // it's automatically using the LeakyBucket request policy. That means it will
        // gracefully handle Shopify's API request limit and will wait if it hits the
        // limit (instead of throwing an exception).
        var orders = await ordrService.ListAsync();
    }
}
```

## <a href="add-service-factories"></a>`services.AddShopifySharpServiceFactories()`

This extension method adds all of ShopifySharp's [service factory classes](../ShopifySharp/Factories) to your `IServiceCollection`. All factories will be added as singletons to the container. No request execution policy will be added via this method, but the factories will pick up any other request execution policy you add to your DI container. See [`services.AddShopifySharpRequestExecutionPolicy(IRequestExecutionPolicy)`](#add-request-execution-policy) to add one explicitly.

```cs
services.AddShopifySharpServiceFactories();
```

## <a name="add-request-execution-policy"></a>`services.AddShopifySharpRequestExecutionPolicy<T>()`
`where T: IRequestExecutionPolicy`

This extension method adds the given [`IRequestExecutionPolicy`](../ShopifySharp/Infrastructure/Policies/IRequestExecutionPolicy.cs) implementation class to your DI container as a singleton. Any ShopifySharp service factories that you add to your DI container, whether manually or via the other DI methods in this package, will use this policy.

```cs
services.AddShopifySharpRequestExecutionPolicy<LeakyBucketExecutionPolicy>();
```

## <a href="add-shopifysharp"></a>`services.AddShopifySharp<T>()`
`where T: IRequestExecutionPolicy`

This is a convenience method and simply calls the other ShopifySharp DI extension methods sequentially to inject all ShopifySharp services into your DI container.

```cs
services.AddShopifySharp<LeakyBucketExecutionPolicy>();
```
