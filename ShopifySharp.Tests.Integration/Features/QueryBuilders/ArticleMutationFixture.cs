using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ShopifySharp.Extensions.DependencyInjection;
using ShopifySharp.Factories;
using ShopifySharp.GraphQL.QueryBuilders.Operations;

namespace ShopifySharp.Tests.Integration.Features.QueryBuilders;

public class ArticleMutationFixture : IAsyncLifetime
{
    public string BlogId { get; private set; } = null!;

    public async Task InitializeAsync()
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.local.json", false)
            .Build();

        var credentials = config.GetRequiredSection("ShopifySharp")
            .GetRequiredSection("Credentials")
            .Get<CredentialsRecord>() ?? throw new InvalidOperationException("Missing credentials");

        var serviceCollection = new ServiceCollection();
        serviceCollection.AddShopifySharp<LeakyBucketExecutionPolicy>();
        var serviceProvider = serviceCollection.BuildServiceProvider();

        var factory = serviceProvider.GetRequiredService<IGraphServiceFactory>();
        var service = factory.Create(new ShopifyApiCredentials(credentials.ShopDomain, credentials.AccessToken));

        // Query for a blog ID
        var blogsQuery = new BlogsOperationQueryBuilder();
        blogsQuery.Arguments.First(1);
        blogsQuery.Nodes(nodes => nodes.Id());

        var request = GraphRequest.FromQueryBuilder(blogsQuery);
        var result = await service.PostAsync(request);

        BlogId = result.Data.nodes?.FirstOrDefault()?.id
                 ?? throw new InvalidOperationException("No blog found - a blog must exist to run article mutation tests");
    }

    public Task DisposeAsync() => Task.CompletedTask;

    private record CredentialsRecord
    {
        public required string ShopDomain { get; init; }
        public required string AccessToken { get; init; }
    }
}