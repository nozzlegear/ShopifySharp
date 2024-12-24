#pragma warning disable CS0618 // Type or member is obsolete
#nullable enable
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using FakeItEasy;
using FluentAssertions;
using JetBrains.Annotations;
using Newtonsoft.Json.Linq;
using ShopifySharp.Graph;
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
    private const string ExpectedQuery = "some-expected-query";
    private const string ExpectedVariableKey1 = "foo";
    private const string ExpectedVariableKey2 = "baz";
    private const string ExpectedVariableValue1 = "bar";
    private const string ExpectedVariableValue2 = "true";
    private const string InputJson =
        $$"""
          {
            "query": "{{ExpectedQuery}}",
            "variables": {
              "{{ExpectedVariableKey1}}": "{{ExpectedVariableValue1}}",
              "{{ExpectedVariableKey2}}": {{ExpectedVariableValue2}}
            }
          }
          """;

    private readonly IRequestExecutionPolicy _policy = A.Fake<IRequestExecutionPolicy>();
    private readonly GraphService _sut;

    public GraphServicePostAsyncTests()
    {
        _sut = new GraphService(Utils.MyShopifyUrl, Utils.AccessToken);
        _sut.SetExecutionPolicy(_policy);
    }

    public static IRequestExecutionPolicy[] MakeFakedExecutionPoliciesList() => Utils.MakeFakedExecutionPoliciesList();

    #region PostAsync<T>(GraphRequest graphRequest, CancellationToken cancellationToken)

    [Fact(DisplayName = "PostAsync<T>(GraphRequest graphRequest) should deserialize the data object to the desired type")]
    public async Task PostAsync_T_WithGraphRequestParameter_ShouldDeserializeTheDataObjectToTheDesiredType()
    {
        // Setup
        const string expectedFooPropertyValue = "some-expected-property-value1";
        const string expectedBarPropertyValue = "some-expected-property-value2";
        const string expectedBatPropertyValue = "some-expected-property-name4";
        DateTimeOffset? expectedQuxDatePropertyValue = null;
        const string responseJson =
            $$"""
              {
                  "data": {
                      "fooOperation": {
                          "foo": "{{expectedFooPropertyValue}}",
                          "bar": "{{expectedBarPropertyValue}}",
                          "baz": {
                              "bat": "{{expectedBatPropertyValue}}",
                              "qux": null
                          }
                      }
                  }
              }
              """;
        const string expectedRequestId = "some-expected-request-id";
        var graphRequest = GraphServiceTestUtils.MakeGraphRequest();
        var expectedResult = new TestGraphOperation
        {
            FooOperation = new TestGraphOperationData
            {
                Foo = expectedFooPropertyValue,
                Bar = expectedBarPropertyValue,
                Baz = new TestGraphOperationChildData
                {
                    Bat = expectedBatPropertyValue,
                    Qux = expectedQuxDatePropertyValue
                }
            }
        };

        A.CallTo(_policy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(Utils.MakeRequestResult(responseJson, x => x.RequestId = expectedRequestId));

        // Act
        var act = async () => await _sut.PostAsync<TestGraphOperation>(graphRequest);

        // Assert
        await act.Should()
            .NotThrowAsync();

        var result = await act();
        result.Data.Should().NotBeNull().And.BeEquivalentTo(expectedResult);
        result.RequestId.Should().Be(expectedRequestId);
    }

    [Fact(DisplayName = "PostAsync<T>(GraphRequest graphRequest) should deserialize date strings properly")]
    public async Task PostAsync_T_WithGraphRequestParameter_ShouldDeserializeDateStringsProperly()
    {
        // Setup
        const string expectedFooPropertyValue = "some-expected-property-value1";
        const string expectedBarPropertyValue = "some-expected-property-value2";
        const string expectedBatPropertyValue = "some-expected-property-name4";
        DateTimeOffset? expectedQuxDatePropertyValue = ExpectedDate;
        const string responseJson =
            $$"""
              {
                  "data": {
                      "fooOperation": {
                          "foo": "{{expectedFooPropertyValue}}",
                          "bar": "{{expectedBarPropertyValue}}",
                          "baz": {
                              "bat": "{{expectedBatPropertyValue}}",
                              "qux": "{{ExpectedDateStr}}"
                          }
                      }
                  }
              }
              """;
        const string expectedRequestId = "some-expected-request-id";
        var graphRequest = GraphServiceTestUtils.MakeGraphRequest();
        var expectedResult = new TestGraphOperation
        {
            FooOperation = new TestGraphOperationData
            {
                Foo = expectedFooPropertyValue,
                Bar = expectedBarPropertyValue,
                Baz = new TestGraphOperationChildData
                {
                    Bat = expectedBatPropertyValue,
                    Qux = expectedQuxDatePropertyValue
                }
            }
        };

        A.CallTo(_policy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(Utils.MakeRequestResult(responseJson, x => x.RequestId = expectedRequestId));

        // Act
        var act = async () => await _sut.PostAsync<TestGraphOperation>(graphRequest);

        // Assert
        await act.Should()
            .NotThrowAsync();

        var result = await act();
        result.Data
            .Should().NotBeNull();
        result.Data
            .Should().BeEquivalentTo(expectedResult);
    }

    [Fact(DisplayName = "PostAsync<T>(GraphRequest graphRequest) should deserialize the graph extensions object along with the data object")]
    public async Task PostAsync_T_WithGraphRequestParameter_ShouldDeserializeTheGraphExtensionsObjectAlongWithTheDataObject()
    {
        // Setup
        const int expectedRequestedQueryCost = 3;
        const int expectedActualQueryCost = 3;
        const double expectedMaximumAvailable = 2000.0;
        const double expectedCurrentlyAvailable = 1997;
        const double expectedRestoreRate = 100.0;
        var responseJson =
            //lang=json
            $$"""
              {
                  "data": {
                      "fooOperation": {
                          "foo": "some-expected-property-value1",
                          "bar": "some-expected-property-value2",
                          "baz": {
                              "bat": "some-expected-property-name4",
                              "qux": null
                          }
                      }
                  },
                  "extensions": {
                      "cost": {
                          "requestedQueryCost": {{expectedRequestedQueryCost}},
                          "actualQueryCost": {{expectedActualQueryCost}},
                          "throttleStatus": {
                              "maximumAvailable": {{expectedMaximumAvailable}},
                              "currentlyAvailable": {{expectedCurrentlyAvailable}},
                              "restoreRate": {{expectedRestoreRate}}
                          }
                      }
                  }
              }
              """;
        const string expectedRequestId = "some-expected-request-id";
        var graphRequest = GraphServiceTestUtils.MakeGraphRequest();
        var expectedExtensions = new GraphExtensions
        {
            Cost = new GraphRequestCostExtension
            {
                ActualQueryCost = expectedActualQueryCost,
                RequestedQueryCost = expectedRequestedQueryCost,
                ThrottleStatus = new GraphRequestCostThrottleStatusExtension
                {
                    RestoreRate = expectedRestoreRate,
                    CurrentlyAvailable = expectedCurrentlyAvailable,
                    MaximumAvailable = expectedMaximumAvailable
                }
            }
        };

        A.CallTo(_policy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(Utils.MakeRequestResult(responseJson, x => x.RequestId = expectedRequestId));

        // Act
        var act = async () => await _sut.PostAsync<TestGraphOperation>(graphRequest);

        // Assert
        await act.Should()
            .NotThrowAsync();

        var result = await act();
        result.Data
            .Should().NotBeNull();
        result.Extensions
            .Should().NotBeNull()
            .And.BeEquivalentTo(expectedExtensions);
    }

    [Theory(DisplayName = "PostAsync<T>(GraphRequest graphRequest) should throw when the root \"data\" property contains user errors and the GraphRequest is configured to throw")]
    [CombinatorialData]
    public async Task PostAsync_T_WithGraphRequestParameter_WhenTheRootDataPropertyContainsUserErrorsAndTheGraphRequestIsConfiguredToThrow_ShouldThrow(
        GraphRequestUserErrorHandling userErrorHandling
    )
    {
        // Setup
        const string expectedFooPropertyValue = "some-expected-property-value1";
        const string expectedBarPropertyValue = "some-expected-property-value2";
        const string expectedBatPropertyValue = "some-expected-property-name4";
        const string responseJson =
            $$"""
              {
                  "data": {
                      "fooOperation": {
                          "foo": "{{expectedFooPropertyValue}}",
                          "bar": "{{expectedBarPropertyValue}}",
                          "baz": {
                              "bat": "{{expectedBatPropertyValue}}",
                              "qux": null
                          },
                          "userErrors": [{ "code": "foo", "message": "bar" }]
                      }
                  }
              }
              """;
        const string expectedRequestId = "some-expected-request-id";
        var graphRequest = GraphServiceTestUtils.MakeGraphRequest(x => x.UserErrorHandling = userErrorHandling);

        A.CallTo(_policy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(Utils.MakeRequestResult(responseJson, x => x.RequestId = expectedRequestId));

        // Act
        var act = async () => await _sut.PostAsync<TestGraphOperation>(graphRequest);

        // Assert
        if (userErrorHandling == GraphRequestUserErrorHandling.Throw)
            await act.Should()
                .ThrowAsync<ShopifyGraphUserErrorsException>()
                .Where(x => x.RequestId == expectedRequestId);
        else
            await act.Should().NotThrowAsync();
    }

    [Fact(DisplayName = "PostAsync<T>(GraphRequest graphRequest) should throw a ShopifyJsonParseException when given invalid JSON")]
    public async Task PostAsync_T_WithGraphRequestParameter_WhenGivenInvalidJson_ShouldThrowAShopifyJsonParseException()
    {
        const string responseJson =
              """
              { 
                  "data": { 
                        "fooOperation": { 
                            "foo": this is an invalid json string 
                        } 
                  } 
              }
              """;
        const string expectedRequestId = "some-expected-request-id";
        var graphRequest = GraphServiceTestUtils.MakeGraphRequest();

        A.CallTo(_policy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(Utils.MakeRequestResult(responseJson, x => x.RequestId = expectedRequestId));

        // Act
        var act = async () => await _sut.PostAsync<TestGraphOperation>(graphRequest);

        // Assert
        var exn = await act.Should()
            .ThrowAsync<ShopifyJsonParseException>();
        exn.Which
            .RequestId.Should().Be(expectedRequestId);
        // The JsonPropertyName will be "$." which represents the root, because the underlying JsonException's path is null (the parse
        // exception occurs early in the parsing process, before the path is set up).
        exn.Which
            .JsonPropertyName.Should().Be("$.");
        exn.WithInnerException(typeof(JsonException))
            .Which.As<JsonException>()
            .Path.Should().BeNull(exn.Which.JsonPropertyName);
    }

    [Theory(DisplayName = "PostAsync<T>(GraphRequest graphRequest) should throw a ShopifyJsonParseException when the data object is null, missing or does not match the expected primitive type")]
    [InlineData(""" "data": null """, JsonValueKind.Null)]
    [InlineData(""" "data": true """, JsonValueKind.True)]
    [InlineData(""" "data": false """, JsonValueKind.False)]
    [InlineData(""" "data": "some string" """, JsonValueKind.String)]
    [InlineData(""" "data": 123 """, JsonValueKind.Number)]
    [InlineData(""" "data": ["an array"] """, JsonValueKind.Array)]
    [InlineData("", JsonValueKind.Undefined)]
    public async Task PostAsync_T_WithGraphRequestParameter_WhenTheDataObjectIsNullOrMissingOrDoesNotMatchTheExpectedPrimitiveType_ShouldThrowAShopifyJsonParseException(
        string dataJson,
        JsonValueKind jsonValueKind
    )
    {
        var responseJson = $$""" { {{dataJson}} } """;
        const string expectedRequestId = "some-expected-request-id";
        var graphRequest = GraphServiceTestUtils.MakeGraphRequest();

        A.CallTo(_policy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(Utils.MakeRequestResult(responseJson, x => x.RequestId = expectedRequestId));

        // Act
        var act = async () => await _sut.PostAsync<TestGraphOperation>(graphRequest);

        // Assert
        var exn = await act.Should()
            .ThrowAsync<ShopifyJsonParseException>()
            .WithMessage(jsonValueKind == JsonValueKind.Undefined
                ? "The JSON response from Shopify does not contain the expected 'data' property."
                : $"The JSON response from Shopify contains an invalid 'data' property of type '{jsonValueKind}', but a property of type 'Object' is required.");
        exn.And.JsonPropertyName.Should().Be("data");
        exn.And.RequestId.Should().Be(expectedRequestId);
        exn.And.InnerException.Should().BeNull();
    }

    #endregion
>>>>>>> 8537dcab (Add tests for GraphService.PostAsync<T>(GraphRequest graphRequest))

    [Fact]
    public async Task PostAsync_DeprecatedMethod_ShouldDeserializeDateStringsProperly()
    {
        // Setup
        var response = Utils.MakeRequestResult(ResponseJson);

        A.CallTo(_policy)
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

        A.CallTo(_policy)
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

        A.CallTo(_policy)
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

        A.CallTo(_policy)
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
            // ReSharper disable twice RedundantAnonymousTypePropertyName
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

    [Serializable]
    public class TestGraphOperation
    {
        public TestGraphOperationData FooOperation { get; set; } = null!;
    }

    [Serializable]
    public class TestGraphOperationData
    {
        public string? Foo { get; set; }
        public string? Bar { get; set; }
        public TestGraphOperationChildData Baz { get; set; } = null!;
    }

    [Serializable]
    public class TestGraphOperationChildData
    {
        public string? Bat { get; set; }
        public DateTimeOffset? Qux { get; set; }
    }
}
