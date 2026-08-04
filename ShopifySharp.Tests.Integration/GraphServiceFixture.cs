using JetBrains.Annotations;
using Microsoft.Extensions.DependencyInjection;
using ShopifySharp.Extensions.DependencyInjection;
using ShopifySharp.Factories;
using ShopifySharp.Tests.Integration.Rest;

namespace ShopifySharp.Tests.Integration;

[UsedImplicitly]
public class GraphServiceFixture
{
    public readonly IGraphService Service;

    public GraphServiceFixture()
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddShopifySharp<LeakyBucketExecutionPolicy>();

        IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider(new ServiceProviderOptions
        {
            ValidateScopes = true,
            ValidateOnBuild = true
        });

        var factory = serviceProvider.GetRequiredService<IGraphServiceFactory>();

        Service = factory.Create(Utils.Credentials);
    }
}
