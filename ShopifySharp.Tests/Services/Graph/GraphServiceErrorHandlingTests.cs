using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FakeItEasy;
using FluentAssertions;
using JetBrains.Annotations;
using Xunit;

namespace ShopifySharp.Tests.Services.Graph;

[Trait("Category", "Graph"), TestSubject(typeof(GraphService))]
public class GraphServiceErrorHandlingTests
{
    private readonly IRequestExecutionPolicy _policy = A.Fake<IRequestExecutionPolicy>(x => x.Strict());

    private readonly GraphService _sut;

    public GraphServiceErrorHandlingTests()
    {
        const string shopAccessToken = "some-shop-access-token";
        const string myShopifyUrl = "https://example.com";

        _sut = new GraphService(myShopifyUrl, shopAccessToken);
        _sut.SetExecutionPolicy(_policy);
    }

    private static RequestResult<string> MakeRequestResult(string responseJson)
    {
        var response = new HttpResponseMessage(HttpStatusCode.OK);
        var result = new RequestResult<string>(
            "some-request-info",
            response.Headers,
            responseJson,
            responseJson,
            "some-raw-link-header-value",
            HttpStatusCode.OK
        );
        return result;
    }

    [Fact]
    public async Task WhenErrorHandlingIsEnabled_AndUserErrorsAreReturned_ShouldThrow()
    {
        const string userErrorsJson =
            """
            {
              "data": {
                "someOperation": {
                  "userErrors": [
                    {
                      "code": "some-code",
                      "message": "some-message",
                      "field": "some-field"
                    }
                  ]
                }
              }
            }
            """;
        var response = MakeRequestResult(userErrorsJson);

        A.CallTo(_policy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(response);

        var act = () => _sut.PostAsync(new GraphRequest
        {
            Query = "some-graph-request-query",
            UserErrorHandling = GraphRequestUserErrorHandling.Throw
        });

        await act.Should()
            .ThrowAsync<ShopifyException>();
    }

    [Fact]
    public async Task WhenErrorHandlingIsEnabled_AndUserErrorsAreReturnedInMultipleOperations_ShouldThrow()
    {
        const string userErrorsJson =
            """
            {
              "data": {
                "someOperation1": {
                  "userErrors": [
                    {
                      "code": "some-code-1",
                      "message": "some-message-1",
                      "field": "some-field-1"
                    }
                  ]
                },
                "someOperation2": {
                  "userErrors": [
                    {
                      "code": "some-code-2",
                      "message": "some-message-2",
                      "field": "some-field-2"
                    }
                  ]
                }
              }
            }
            """;
        var response = MakeRequestResult(userErrorsJson);

        A.CallTo(_policy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(response);

        var act = () => _sut.PostAsync(new GraphRequest
        {
            Query = "some-graph-request-query",
            UserErrorHandling = GraphRequestUserErrorHandling.Throw
        });

        await act.Should()
            .ThrowAsync<ShopifyException>();
    }

    [Fact]
    public async Task WhenErrorHandlingIsEnabled_AndNoUserErrorsAreReturned_ShouldNotThrow()
    {
        // Setup
        const int expectedFoo = 7;
        var responseJson =
            $$"""
              {
                "data": {
                  "foo": {{expectedFoo}}
                }
              }
              """;
        var response = MakeRequestResult(responseJson);

        A.CallTo(_policy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(response);

        // Act
        var act = async () => await _sut.PostAsync(new GraphRequest
        {
            Query = "some-graph-request-query",
            UserErrorHandling = GraphRequestUserErrorHandling.Throw
        });

        // Assert
        await act.Should()
            .NotThrowAsync<ShopifyException>();

        var result = await act();
        result.RootElement.GetProperty("foo")
            .GetInt32()
            .Should()
            .Be(expectedFoo);
    }

    [Fact]
    public async Task WhenErrorHandlingIsDisabled_AndUserErrorsAreReturned_ShouldNotThrow()
    {
        Assert.Fail("nyi");
    }

    [Fact]
    public async Task WhenErrorHandlingIsDisabled_AndUserErrorsAreReturnedInMultipleOperations_ShouldNotThrow()
    {
        Assert.Fail("nyi");
    }

    [Fact]
    public async Task WhenErrorHandlingIsDisabled_AndNoUserErrorsAreReturned_ShouldNotThrow()
    {
        Assert.Fail("nyi");
    }
}
