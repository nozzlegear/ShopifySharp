using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.Json;
using System.Threading.Tasks;
using FakeItEasy;
using FluentAssertions;
using Newtonsoft.Json.Linq;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Http;
using ShopifySharp.Tests.TestClasses;
using Xunit;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

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
    private readonly JsonSerializerOptions _serializerSettings = Serializer.SerializerDefaults;
    private readonly IRequestExecutionPolicy _executionPolicy = A.Fake<IRequestExecutionPolicy>(x => x.Wrapping(new LeakyBucketExecutionPolicy()));
    private readonly IDependencyContainer _dependencyContainer = A.Fake<IDependencyContainer>();
    private readonly IHttpContentSerializer _httpContentSerializer;
    private readonly GraphService _sut;

    public GraphServiceTests()
    {
        _httpContentSerializer = A.Fake<IHttpContentSerializer>(x =>
            x.Wrapping(new GraphHttpContentSerializer(_serializerSettings)));

        A.CallTo(() => _dependencyContainer.TryGetService<JsonSerializerOptions>())
            .Returns(_serializerSettings);
        A.CallTo(() => _dependencyContainer.TryGetService<IHttpContentSerializer>())
            .Returns(_httpContentSerializer);

        _sut = new GraphService(Utils.MyShopifyUrl,
            Utils.AccessToken,
            null,
            _dependencyContainer);
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

    [Fact(DisplayName = "Lists orders using the GraphService")]
    public async Task ListsOrdersUsingGraphService()
    {
        var query = @"
              query listOrdersWithTag($limit: Int!) {
                orders(first: $limit) {
                  pageInfo {
                    hasNextPage
                    hasPreviousPage
                  }
                  edges {
                    cursor
                    node {
                      id
                      name
                      tags
                    }
                  }
                }
              }
            ";
        var variables = new Dictionary<string, object>
        {
            { "limit", 10 }
        };
        // Serialize the GraphQL query and the variables into a JToken. Must use a JToken for now, or else the service
        // will assume we are using a GraphQL string and send with the wrong content type.
        var serializerSettings = Serializer.CreateNewtonsoftSettings();
        var serializer = JsonSerializer.Create(serializerSettings);
        var requestBody =  JToken.FromObject(new
        {
            query = query,
            variables = variables
        }, serializer);
        // Send the request. For now this must be sent as a JToken, or else the service will assume it is a GraphQL
        // string and send it with the wrong content type.
        var jToken = await _sut.PostAsync(requestBody);
        var listResult = jToken["orders"]?.ToObject<GraphListOrdersResult>();

        Assert.NotNull(listResult);
        Assert.NotNull(listResult.PageInfo);
        Assert.NotEmpty(listResult.Edges);
        Assert.All(listResult.Edges, edge =>
        {
            Assert.NotEmpty(edge.Cursor);
            Assert.NotNull(edge.Node);
            Assert.NotNull(edge.Node.Id);
            Assert.NotNull(edge.Node.Name);
            Assert.NotNull(edge.Node.Tags);
        });
    }
}
