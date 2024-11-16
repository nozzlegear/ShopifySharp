using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FakeItEasy;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.Graph;
using Xunit;

namespace ShopifySharp.Tests.Services.Graph;

[Trait("Category", "Graph"), TestSubject(typeof(GraphService))]
public class GraphServiceErrorHandlingTests
{
    private const string UserErrorsPropertyName = "userErrors";

    private readonly IRequestExecutionPolicy _policy = A.Fake<IRequestExecutionPolicy>(x => x.Strict());

    private readonly GraphService _sut;

    public GraphServiceErrorHandlingTests()
    {
        const string shopAccessToken = "some-shop-access-token";
        const string myShopifyUrl = "https://example.com";

        _sut = new GraphService(myShopifyUrl, shopAccessToken, null, null);
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

    [Theory]
    [CombinatorialData]
    public async Task WhenNoUserErrorsAreReturned_ShouldNotThrow(
        GraphRequestUserErrorHandling graphRequestUserErrorHandling
    )
    {
        // Setup
        const string operationPropertyName = "some-operation-property-name";
        const string expectedPropertyName1 = "foo";
        const string expectedPropertyName2 = "bar";
        const int expectedPropertyValue = 7;
        var responseJson =
            $$"""
              {
                "data": {
                  "{{expectedPropertyName1}}": {{expectedPropertyValue}},
                  "{{operationPropertyName}}": {
                    "{{expectedPropertyName2}}": {{expectedPropertyValue}}
                  }
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
            UserErrorHandling = graphRequestUserErrorHandling
        });

        // Assert
        await act.Should()
            .NotThrowAsync();

        var result = await act();
        result.RootElement.GetProperty(expectedPropertyName1)
            .GetInt32()
            .Should()
            .Be(expectedPropertyValue);

        var operation = result.RootElement.GetProperty(operationPropertyName);
        operation.Should().NotBeNull();
        operation.GetProperty(expectedPropertyName2)
            .GetInt32()
            .Should()
            .Be(expectedPropertyValue);
    }

    [Theory]
    [CombinatorialData]
    public async Task WhenUserErrorsAreReturnedFromASingleOperation_ShouldThrowAccordingToGraphRequestUserErrorHandling(
        GraphRequestUserErrorHandling userErrorHandling
    )
    {
        // Setup
        const string expectedCode = "some-expected-code";
        const string expectedMessage = "some-expected-message";
        const string expectedField = "some-expected-field";
        const string userErrorsJson =
            $$"""
            {
              "data": {
                "someOperation": {
                  "userErrors": [
                    {
                      "code": "{{expectedCode}}",
                      "message": "{{expectedMessage}}",
                      "field": ["{{expectedField}}"]
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

        // Act
        var act = () => _sut.PostAsync(new GraphRequest
        {
            Query = "some-graph-request-query",
            UserErrorHandling = userErrorHandling
        });

        // Assert
        if (userErrorHandling == GraphRequestUserErrorHandling.Throw)
        {
            var exn = await act.Should()
                .ThrowAsync<ShopifyGraphUserErrorsException>("{0} == {1}", nameof(userErrorHandling), GraphRequestUserErrorHandling.Throw);
            exn.And.GraphUserErrors.Should()
                .BeEquivalentTo([new GraphUserError
                {
                    Field = [expectedField],
                    Message = expectedMessage,
                    Code = expectedCode
                }]);
        }
        else
        {
            await act.Should()
                .NotThrowAsync("{0} != {1} (actual value == {2})", nameof(userErrorHandling), GraphRequestUserErrorHandling.Throw, userErrorHandling);
        }
    }

    [Theory]
    [CombinatorialData]
    public async Task WhenUserErrorsAreReturnedFromMultipleOperations_ShouldThrowAccordingToGraphRequestUserErrorHandling(
        GraphRequestUserErrorHandling userErrorHandling
    )
    {
        // Setup
        const string userErrorsJson =
            """
            {
              "data": {
                "someOperation1": {
                  "userErrors": [
                    {
                      "code": "some-code-1",
                      "message": "some-message-1",
                      "field": ["some-field-1"]
                    }
                  ]
                },
                "someOperation2": {
                  "userErrors": [
                    {
                      "code": "some-code-2",
                      "message": "some-message-2",
                      "field": ["some-field-2"]
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

        // Act
        var act = () => _sut.PostAsync(new GraphRequest
        {
            Query = "some-graph-request-query",
            UserErrorHandling = userErrorHandling
        });

        // Assert
        if (userErrorHandling == GraphRequestUserErrorHandling.Throw)
        {
            await act.Should()
                .ThrowAsync<ShopifyException>("{0} == {1}", nameof(userErrorHandling), GraphRequestUserErrorHandling.Throw);
        }
        else
        {
            await act.Should()
                .NotThrowAsync("{0} != {1} (actual value == {2})", nameof(userErrorHandling), GraphRequestUserErrorHandling.Throw, userErrorHandling);
        }
    }

    [Theory]
    [CombinatorialData]
    public async Task WhenUserErrorsAreReturned_AndUserErrorsJsonIsInvalidOrUnexpected_ShouldThrowShopifyJsonParseException(
        GraphRequestUserErrorHandling graphRequestUserErrorHandling
    )
    {
        // Setup
        const string userErrorsJson=
            $$"""
            {
              "data": {
                "someOperation1": {
                  "{{UserErrorsPropertyName}}": "some-user-errors"
                }
              }
            }
            """;
        var response = MakeRequestResult(userErrorsJson);

        A.CallTo(_policy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(response);

        // Act
        var act = () => _sut.PostAsync(new GraphRequest
        {
            Query = "some-graph-request-query",
            UserErrorHandling = graphRequestUserErrorHandling
        });

        // Assert
        if (graphRequestUserErrorHandling == GraphRequestUserErrorHandling.Throw)
        {
            var exn = await act.Should()
                .ThrowAsync<ShopifyJsonParseException>();

            exn.Which.JsonPropertyName.Should().Be(UserErrorsPropertyName);
        }
        else
        {
            await act.Should()
                .NotThrowAsync();
        }
    }

    [Theory]
    [CombinatorialData]
    public async Task WhenUserErrorsAreReturned_AndArrayIsEmptyWithZeroErrors_ShouldNotThrow(
        GraphRequestUserErrorHandling graphRequestUserErrorHandling
    )
    {
        // Setup
        const string operationPropertyName = "someOperation";
        const string expectedPropertyName = "foo";
        const string responseJson =
            $$"""
              {
                "data": {
                  "{{operationPropertyName}}": {
                    "{{expectedPropertyName}}": 7,
                    "{{UserErrorsPropertyName}}": []
                  }
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
            UserErrorHandling = graphRequestUserErrorHandling
        });

        // Assert
        await act.Should()
            .NotThrowAsync();

        var result = await act();
        var operation = result.RootElement.GetProperty(operationPropertyName);

        operation.Should().NotBeNull();
    }

    [Theory]
    [CombinatorialData]
    public async Task WhenUserErrorsAreReturned_AndArrayContainsAUserErrorWithEmptyValues_ShouldThrowShopifyGraphUserErrorsException(
        [CombinatorialValues("null", "\"\"")] string messageValue,
        [CombinatorialValues("null", "\"\"")] string codeValue,
        GraphRequestUserErrorHandling graphRequestUserErrorHandling
    )
    {
        // Setup
        const string operationPropertyName = "someOperation";
        const string expectedPropertyName = "foo";
        const int expectedPropertyValue = 7;
        var responseJson =
            $$"""
              {
                "data": {
                  "{{operationPropertyName}}": {
                    "{{expectedPropertyName}}": {{expectedPropertyValue}},
                    "{{UserErrorsPropertyName}}": [
                      {
                        "code": {{codeValue}},
                        "message": {{messageValue}}
                      }
                    ]
                  }
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
            UserErrorHandling = graphRequestUserErrorHandling
        });

        // Assert
        if (graphRequestUserErrorHandling == GraphRequestUserErrorHandling.Throw)
        {
            var exn = await act.Should()
                .ThrowExactlyAsync<ShopifyGraphUserErrorsException>();
            exn.And.GraphUserErrors.Should()
                .HaveCount(1);
        }
        else
        {
            await act.Should()
                .NotThrowAsync();
        }
    }

    [Theory]
    [CombinatorialData]
    public async Task WhenUserErrorsAreReturned_AndArrayContainsAnEmptyUserError_ShouldThrowShopifyGraphUserErrorsException(
        GraphRequestUserErrorHandling graphRequestUserErrorHandling
    )
    {
        // Setup
        const string operationPropertyName = "someOperation";
        const string expectedPropertyName = "foo";
        const string responseJson =
            $$"""
              {
                "data": {
                  "{{operationPropertyName}}": {
                    "{{expectedPropertyName}}": 7,
                    "{{UserErrorsPropertyName}}": [{}]
                  }
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
            UserErrorHandling = graphRequestUserErrorHandling
        });

        if (graphRequestUserErrorHandling == GraphRequestUserErrorHandling.Throw)
        {
            // Assert
            var exn = await act.Should()
                .ThrowExactlyAsync<ShopifyGraphUserErrorsException>();
            exn.And.GraphUserErrors.Should()
                .BeEquivalentTo([new GraphUserError
                {
                    Field = [],
                    Message = string.Empty,
                    Code = null
                }]);
        }
        else
        {
            await act.Should()
                .NotThrowAsync();
        }
    }
}
