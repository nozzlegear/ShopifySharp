using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Xunit;

namespace ShopifySharp.Tests
{
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
    public class Graph_Tests : IClassFixture<Graph_Tests_Fixture>
    {
        private readonly Graph_Tests_Fixture _fixture;

        public Graph_Tests(Graph_Tests_Fixture fixture)
        {
            _fixture = fixture;
            _fixture.Service.SetExecutionPolicy(new LeakyBucketExecutionPolicy());
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
            var serializerSettings = ShopifySharp.Infrastructure.Serializer.CreateNewtonsoftSettings();
            var serializer = JsonSerializer.Create(serializerSettings);
            var requestBody =  JToken.FromObject(new
            {
                query = query,
                variables = variables
            }, serializer);
            // Send the request. For now this must be sent as a JToken, or else the service will assume it is a GraphQL
            // string and send it with the wrong content type.
            var jToken = await _fixture.Service.PostAsync(requestBody);
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

    public class Graph_Tests_Fixture : IAsyncLifetime
    {
        public readonly GraphService Service = new GraphService(Utils.MyShopifyUrl, Utils.AccessToken);

        public Task InitializeAsync()
        {
            return Task.CompletedTask;
        }

        public Task DisposeAsync()
        {
            return Task.CompletedTask;
        }
    }
}
