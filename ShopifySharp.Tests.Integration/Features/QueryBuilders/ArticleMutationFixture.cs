using Microsoft.Extensions.DependencyInjection;
using ShopifySharp.Extensions.DependencyInjection;
using ShopifySharp.Factories;
using ShopifySharp.GraphQL.QueryBuilders.Operations;

namespace ShopifySharp.Tests.Integration.Features.QueryBuilders;

public class ArticleMutationFixture : IAsyncLifetime
{
    public string BlogId { get; private set; } = null!;

    public async System.Threading.Tasks.ValueTask InitializeAsync()
    {
        var credentials = TestConfigurationFixture.Current.Credentials;

        var serviceCollection = new ServiceCollection();
        serviceCollection.AddShopifySharp<LeakyBucketExecutionPolicy>();
        var serviceProvider = serviceCollection.BuildServiceProvider();

        var factory = serviceProvider.GetRequiredService<IGraphServiceFactory>();
        var service = factory.Create(credentials);

        // Query for a blog ID
        var blogsQuery = new BlogsOperationQueryBuilder();
        blogsQuery.Arguments.First(1);
        blogsQuery.Nodes(nodes => nodes.Id());

        var request = GraphRequest.FromQueryBuilder(blogsQuery);
        var result = await service.PostAsync(request);

        BlogId = result.Data.nodes?.FirstOrDefault()?.id
                 ?? throw new InvalidOperationException("No blog found - a blog must exist to run article mutation tests");
    }

    public System.Threading.Tasks.ValueTask DisposeAsync() => default;
}