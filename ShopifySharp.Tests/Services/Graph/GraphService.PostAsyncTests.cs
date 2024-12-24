#pragma warning disable CS0618 // Type or member is obsolete
#nullable enable
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FakeItEasy;
using FluentAssertions;
using JetBrains.Annotations;
using Newtonsoft.Json.Linq;
using ShopifySharp.Infrastructure;
using ShopifySharp.Tests.TestClasses;
using Xunit;
using NewtonsoftSerializer = Newtonsoft.Json.JsonSerializer;

namespace ShopifySharp.Tests.Services.Graph;

[Trait("Category", "Graph"), TestSubject(typeof(GraphService))]
public class GraphServicePostAsyncTests
{
    private static readonly DateTimeOffset ExpectedDate = DateTimeOffset.Parse(ExpectedDateStr);

    private const string ExpectedDateStr = "2024-11-20T01:05:03Z";
    private const string ResponseJson =
        $$"""
        {
          "data" : {
            "orders" : {
              "edges" : [ {
                "node" : {
                  "updatedAt" : "{{ExpectedDateStr}}"
                }
              } ]
            }
          },
          "extensions" : {
            "cost" : {
              "requestedQueryCost" : 3,
              "actualQueryCost" : 3,
              "throttleStatus" : {
                "maximumAvailable" : 2000.0,
                "currentlyAvailable" : 1997,
                "restoreRate" : 100.0
              }
            }
          }
        }
        """;
    private const string QueryJson =
        """
        {
           orders(first: 1, query: "id: 123456") {
               edges {
                   node {
                       updatedAt
                   }
               }
           }
        }
        """;
    const string ExpectedQuery = "some-expected-query";
    const string ExpectedVariableKey1 = "foo";
    const string ExpectedVariableKey2 = "baz";
    const string ExpectedVariableValue1 = "bar";
    const string ExpectedVariableValue2 = "true";
    const string InputJson =
        $$"""
          {
            "query": "{{ExpectedQuery}}",
            "variables": {
              "{{ExpectedVariableKey1}}": "{{ExpectedVariableValue1}}",
              "{{ExpectedVariableKey2}}": {{ExpectedVariableValue2}}
            }
          }
          """;

    private readonly IRequestExecutionPolicy _executionPolicy = A.Fake<IRequestExecutionPolicy>();
    private readonly GraphService _sut;

    public GraphServicePostAsyncTests()
    {
        _sut = new GraphService(Utils.MyShopifyUrl, Utils.AccessToken);
        _sut.SetExecutionPolicy(_executionPolicy);
    }

    public static IRequestExecutionPolicy[] MakeFakedExecutionPoliciesList() => Utils.MakeFakedExecutionPoliciesList();

    [Fact]
    public async Task PostAsync_DeprecatedMethod_ShouldDeserializeDateStringsProperly()
    {
        // Setup
        var response = Utils.MakeRequestResult(ResponseJson);

        A.CallTo(_executionPolicy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(response);

        // Act
        var result = await _sut.PostAsync(QueryJson);

        // Assert
        AssertResults(result);
    }

    [Fact]
    public async Task PostAsync_DeprecatedMethodWithJTokenParameter_ShouldThrowWhenJTokenIsNull()
    {
        // Setup
        JToken? input = null;

        // Act
        var act = () => _sut.PostAsync(input);

        // Assert
        await act.Should()
            .ThrowExactlyAsync<ArgumentNullException>()
            .WithParameterName("body");
    }

    [Theory]
    [InlineData("{}", JTokenType.Null)]
    [InlineData("""{"query": null}""", JTokenType.Null)]
    [InlineData("""{"query": []}""", JTokenType.Array)]
    [InlineData("""{"query": {}}""", JTokenType.Object)]
    [InlineData("""{"query": true}""", JTokenType.Boolean)]
    [InlineData("""{"query": false}""", JTokenType.Boolean)]
    [InlineData("""{"query": 123}""", JTokenType.Integer)]
    public async Task PostAsync_DeprecatedMethodWithJTokenParameter_ShouldThrowWhenJTokenDoesNotContainAValidQueryElement(string jsonValue, JTokenType tokenType)
    {
        // Setup
        var input = JToken.Parse(jsonValue);

        // Act
        var act = () => _sut.PostAsync(input);

        // Assert
        await act.Should()
            .ThrowAsync<ArgumentException>()
            .WithMessage($"The type of the required `query` property should be String, but it was {tokenType}*")
            .WithParameterName("body");
    }

    [Theory]
    [InlineData("""{"foo": "bar"}""")]
    [InlineData("{}")]
    [InlineData("null")]
    public async Task PostAsync_DeprecatedMethodWithJTokenParameter_ShouldNotThrowWhenJTokenContainsNullOrEmptyVariablesElement(string variablesJson)
    {
        // Setup
        var inputJson =
            $$"""
              {
                "query": "some-query",
                "variables": {{variablesJson}}
              }
              """;

        A.CallTo(_executionPolicy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Throws<TestException>();

        // Act
        var act = () => _sut.PostAsync(inputJson);

        // Assert
        await act.Should().ThrowAsync<TestException>();
    }

    [Fact]
    public async Task PostAsync_DeprecatedMethodWithJTokenParameter_ShouldDeserializeDateStringsProperly()
    {
        // Setup
        var response = Utils.MakeRequestResult(ResponseJson);

        A.CallTo(_executionPolicy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(response);

        // Act
        var result = await _sut.PostAsync(InputJson);

        // Assert
        AssertResults(result);
    }

    [Theory(DisplayName = "PostAsync (deprecated methods), when using each policy, should deserialize the response to a JToken")]
    [CombinatorialData]
    public async Task PostAsync_DeprecatedMethods_WhenUsingEachPolicy_ShouldDeserializeResponseToExpectedResult(
        [CombinatorialMemberData(nameof(MakeFakedExecutionPoliciesList), null)] IRequestExecutionPolicy policy,
        bool withVariables
    )
    {
        // Setup
        var response = Utils.MakeRequestResult(ResponseJson);

        _sut.SetExecutionPolicy(policy);
        A.CallTo(policy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(response);

        // Act
        JToken result;

        if (withVariables)
            result = await _sut.PostAsync(JToken.Parse(InputJson));
        else
            result = await _sut.PostAsync(QueryJson);

        // Assert
        AssertResults(result);
    }

    [Theory]
    [CombinatorialData]
    public async Task PostAsync_DeprecatedMethods_WhenResponseContainsUserErrors_ShouldThrowShopifyGraphUserErrorsException(
        bool withVariables
    )
    {
        // Setup
        const string responseJson =
          """
          {
            "data" : {
              "orders" : {
                "userErrors": [{ "code": "foo", "message": "bar" }]
              }
            }
          }
          """;
        var response = Utils.MakeRequestResult(responseJson);

        A.CallTo(_executionPolicy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(response);

        // Act
        Func<Task<JToken>> result;

        if (withVariables)
        {
            JToken parsedToken = JToken.Parse(InputJson);
            result = () => _sut.PostAsync(parsedToken);
        }
        else
            result = () => _sut.PostAsync(QueryJson);

        // Assert
        await result.Should()
            .ThrowExactlyAsync<ShopifyGraphUserErrorsException>()
            .WithMessage("foo: bar");
    }

    [Fact(DisplayName = "Lists orders using the GraphService")]
    public async Task PostAsync_DeprecatedMethods_ShouldListOrders()
    {
        // Setup
        const string query = @"
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
        var serializerSettings = Serializer.CreateNewtonsoftSettings();
        var serializer = NewtonsoftSerializer.Create(serializerSettings);
        var requestBody =  JToken.FromObject(new
        {
            query = query,
            variables = variables
        }, serializer);

        // This is an integration test, so use a real execution policy
        _sut.SetExecutionPolicy(new DefaultRequestExecutionPolicy());

        // Act
        var jToken = await _sut.PostAsync(requestBody);
        var listResult = jToken["orders"]?.ToObject<GraphListOrdersResult>();

        // Assert
        listResult.Should().NotBeNull();
        listResult?.PageInfo.Should().NotBeNull();
        listResult?.Edges.Should().NotBeNullOrEmpty();
        listResult?.Edges.Should().AllSatisfy(edge =>
        {
            edge.Cursor.Should().NotBeNullOrWhiteSpace();
            edge.Node.Should().NotBeNull();
            edge.Node.Id.Should().NotBeNullOrWhiteSpace();
            edge.Node.Name.Should().NotBeNullOrWhiteSpace();
            edge.Node.Tags.Should().NotBeNull();
        });
    }

    /// <summary>
    /// Asserts that the results of the deprecated PostAsync methods match what is expected.
    /// </summary>
    private static void AssertResults(JToken result)
    {
        var order = result["orders"]?["edges"]?.First?["node"];

        order.Should().NotBeNull();

        order!.ToObject<TestGraphQlOrderWithString>()
            .Should()
            .BeEquivalentTo(new TestGraphQlOrderWithString { UpdatedAt = ExpectedDateStr });

        order.ToObject<TestGraphQlOrderWithDateTimeOffset>()
            .Should()
            .BeEquivalentTo(new TestGraphQlOrderWithDateTimeOffset { UpdatedAt = ExpectedDate });

        order.ToObject<TestGraphQlOrderWithDateTime>()
            .Should()
            .BeEquivalentTo(new TestGraphQlOrderWithDateTime { UpdatedAt = ExpectedDate.DateTime });
    }

    [Serializable]
    public class TestGraphQlOrderWithString
    {
        public string? UpdatedAt { get; set; }
    }

    [Serializable]
    public class TestGraphQlOrderWithDateTime
    {
        public DateTime UpdatedAt { get; set; }
    }

    [Serializable]
    public class TestGraphQlOrderWithDateTimeOffset
    {
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
