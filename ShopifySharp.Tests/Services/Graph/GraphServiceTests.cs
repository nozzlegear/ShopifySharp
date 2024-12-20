using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json;
using System.Threading.Tasks;
using FakeItEasy;
using FluentAssertions;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Http;
using ShopifySharp.Credentials;
using ShopifySharp.Tests.TestClasses;
using Xunit;

namespace ShopifySharp.Tests.Services.Graph;

[Serializable]
public class GraphOrderEdge
{
    public string Cursor { get; set; }
    public GraphOrder Node { get; set; }
}

[Serializable]
public class GraphOrder
{
    public string Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<string> Tags { get; set; }
}

[Serializable]
public class GraphPageInfo
{
    public bool HasNextPage { get; set; }
    public bool HasPreviousPage { get; set; }
}

[Serializable]
public class GraphListOrdersResult
{
    public GraphPageInfo PageInfo { get; set; }
    public Collection<GraphOrderEdge> Edges { get; set; }
}

[Trait("Category", "Graph")]
public class GraphServiceTests
{
    private readonly ShopifyApiCredentials _credentials = new("some-shopify-domain", "some-access-token");

    private readonly JsonSerializerOptions _jsonSerializerOptions = Serializer.GraphSerializerOptions;
    private readonly IRequestExecutionPolicy _executionPolicy = A.Fake<IRequestExecutionPolicy>(x => x.Wrapping(new LeakyBucketExecutionPolicy()));
    private readonly IServiceProvider _serviceProvider = A.Fake<IServiceProvider>();
    private readonly IHttpContentSerializer _httpContentSerializer;

    private readonly GraphService _sut;

    public GraphServiceTests()
    {
        _httpContentSerializer = A.Fake<IHttpContentSerializer>(x =>
            x.Wrapping(new GraphHttpContentSerializer(_jsonSerializerOptions)));

        A.CallTo(() => _serviceProvider.GetService(typeof(JsonSerializerOptions)))
            .Returns(_jsonSerializerOptions);
        A.CallTo(() => _serviceProvider.GetService(typeof(IHttpContentSerializer)))
            .Returns(_httpContentSerializer);

        _sut = new GraphService(_credentials, null, _serviceProvider);
        _sut.SetExecutionPolicy(_executionPolicy);
    }

    [Fact]
    public async Task WhenSendingGraphRequest_ShouldUseHttpContentSerializer()
    {
        // Setup
        var request = new GraphRequest
        {
            Query = "some-graph-request-query",
            Variables = new Dictionary<string, object>
            {
                { "foo", "bar" }
            }
        };

        A.CallTo(() => _httpContentSerializer.SerializeGraphRequest(A<RequestUri>._, request))
            .Throws<TestException>();

        // Act
        var act = () => _sut.PostAsync(request);

        // Assert
        await act.Should().ThrowAsync<TestException>();
    }

}
