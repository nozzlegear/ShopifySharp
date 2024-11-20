#pragma warning disable CS0618 // Type or member is obsolete
#nullable enable
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FakeItEasy;
using FluentAssertions;
using Newtonsoft.Json.Linq;
using ShopifySharp.Infrastructure.Policies.ExponentialRetry;
using ShopifySharp.Tests.TestClasses;
using Xunit;

namespace ShopifySharp.Tests.Services.Graph;

[Trait("Category", "DateTime"), Trait("Category", "DotNetFramework"), Collection("DotNetFramework tests")]
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

    public static IRequestExecutionPolicy[] GetTestPolicies()
    {
        return
        [
            A.Fake<IRequestExecutionPolicy>(x => x.Wrapping(new DefaultRequestExecutionPolicy())),
            A.Fake<IRequestExecutionPolicy>(x => x.Wrapping(new RetryExecutionPolicy())),
            A.Fake<IRequestExecutionPolicy>(x => x.Wrapping(new LeakyBucketExecutionPolicy())),
            A.Fake<IRequestExecutionPolicy>(x => x.Wrapping(new ExponentialRetryPolicy(ExponentialRetryPolicyOptions.Default())))
        ];
    }

    private static RequestResult<string> MakeRequestResult(string responseJson)
    {
        var response = new HttpResponseMessage(HttpStatusCode.OK);
        return new RequestResult<string>(
            "some-request-info",
            response.Headers,
            responseJson,
            responseJson,
            "some-raw-link-header-value",
            HttpStatusCode.OK
        );
    }

    [Fact]
    public async Task PostAsync_DeprecatedMethod_ShouldDeserializeDateStringsProperly()
    {
        // Setup
        var response = MakeRequestResult(ResponseJson);

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
        var response = MakeRequestResult(ResponseJson);

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
        [CombinatorialMemberData(nameof(GetTestPolicies), null)] IRequestExecutionPolicy policy,
        bool withVariables
    )
    {
        // Setup
        var response = MakeRequestResult(ResponseJson);

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
        var response = MakeRequestResult(responseJson);

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
