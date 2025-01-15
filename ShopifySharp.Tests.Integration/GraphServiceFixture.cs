using JetBrains.Annotations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShopifySharp.Extensions.DependencyInjection;
using ShopifySharp.Factories;

namespace ShopifySharp.Tests.Integration;

[UsedImplicitly]
public class GraphServiceFixture
{
    public readonly IGraphService Service;

    public GraphServiceFixture()
    {
        var builder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.local.json", false)
            .Build();
        var serviceCollection = new ServiceCollection();
        serviceCollection.AddShopifySharp<LeakyBucketExecutionPolicy>();

        IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider(new ServiceProviderOptions
        {
            ValidateScopes = true,
            ValidateOnBuild = true
        });

        var credentials = builder.GetRequiredSection("ShopifySharp")
            .GetRequiredSection("Credentials")
            .Get<Credentials>() ?? throw new ArgumentNullException();
        var factory = serviceProvider.GetRequiredService<IGraphServiceFactory>();

        Service = factory.Create(new ShopifyApiCredentials(credentials.ShopDomain, credentials.AccessToken));
    }

    private record Credentials
    {
        public required string ShopDomain { get; init; }

        public required string AccessToken { get; init; }

        public required string ApiKey { get; init; }
    }
}
