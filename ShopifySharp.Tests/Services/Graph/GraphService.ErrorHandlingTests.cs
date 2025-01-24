using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using FakeItEasy;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.Services.Graph;
using Xunit;

namespace ShopifySharp.Tests.Services.Graph;

[Trait("Category", "Graph"), TestSubject(typeof(GraphService))]
public class GraphServiceErrorHandlingTests
{
    private const string UserErrorsPropertyName = "userErrors";
    private const string UserErrorsPropertyPath = $"$.{UserErrorsPropertyName}";
    private const string ErrorsPropertyName = "errors";
    private const string ErrorsPropertyPath = $"$.{ErrorsPropertyName}";

    private readonly IRequestExecutionPolicy _policy = A.Fake<IRequestExecutionPolicy>(x => x.Strict());

    private readonly GraphService _sut;

    public GraphServiceErrorHandlingTests()
    {
        const string shopAccessToken = "some-shop-access-token";
        const string myShopifyUrl = "https://example.com";

        _sut = new GraphService(myShopifyUrl, shopAccessToken, apiVersion: null);
        _sut.SetExecutionPolicy(_policy);
    }

    [Theory]
    [CombinatorialData]
    public async Task WhenQueryOrMutationErrorsAreReturned_ShouldThrowRegardlessOfUserErrorHandling(
        GraphRequestUserErrorHandling userErrorHandling)
    {
        // Setup
        // This type of error is returned when something is wrong with the way the query/mutation is structured, e.g.
        // an enum value was used that doesn't exist. As the name 'userErrors' implies, this kind of error message isn't
        // intended for end users of Shopify applications, but rather for the developers.
        const string expectedMessage = "some-expected-message";
        const string expectedCode = "some-expected-code";
        const string expectedTypeName = "some-expected-type-name";
        const string expectedArgumentName = "some-expected-argument-name";

        string[] expectedPath = ["query some-query", "some-expected-path1", "some-expected-path2", "some-expected-path3" ];
        var expectedPathString = JsonSerializer.Serialize(expectedPath);

        var responseJson =
            // lang=json
            $$"""
            {
              "{{ErrorsPropertyName}}" : [ {
                "message" : "{{expectedMessage}}",
                "locations" : [ {
                  "line" : 16,
                  "column" : 13
                } ],
                "path" : {{expectedPathString}},
                "extensions" : {
                  "code" : "{{expectedCode}}",
                  "typeName" : "{{expectedTypeName}}",
                  "argumentName" : "{{expectedArgumentName}}"
                }
              } ]
            }
            """;
        const string expectedRequestId = "some-expected-request-id";
        var response = Utils.MakeRequestResult(responseJson, x => x.RequestId = expectedRequestId);

        A.CallTo(_policy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(response);

        // Act
        var act = async () => await _sut.PostAsync(new GraphRequest
        {
            Query = "some-graph-request-query",
            UserErrorHandling = userErrorHandling
        });

        // Assert
        var exn = await act.Should()
            .ThrowExactlyAsync<ShopifyGraphErrorsException>()
            .WithMessage($"{expectedCode}: {expectedMessage}");

        exn.Which.RequestId.Should().Be(expectedRequestId);
        exn.Which.InnerException.Should().BeNull();
        exn.Which.GraphErrors.Should().SatisfyRespectively(graphError =>
        {
            graphError.Message.Should().Be(expectedMessage);
            graphError.Path.Should().ContainInOrder(expectedPath);
            graphError.Extensions.Should().BeEquivalentTo(new GraphErrorExtensions
            {
                Code = expectedCode,
                TypeName = expectedTypeName,
                ArgumentName = expectedArgumentName,
            });
        });
    }

    [Theory]
    [CombinatorialData]
    public async Task WhenQueryOrMutationErrorsAreReturned_AndTheyMatchTheExtensionsHaveAValuePropAndAProblemsProp_ShouldThrowRegardlessOfUserErrorHandling(
        GraphRequestUserErrorHandling userErrorHandling)
    {
        // Setup
        const string expectedMessage = "some-expected-message";
        const string expectedProblemPath = "some-expected-path";
        const string expectedProblemExplanation = "some-expected-explanation";
        const string expectedProblemMessage = "some-expected-problem-message";
        const string expectedValueKey = "some-expected-value-key";
        const string expectedValueValue = "some-expected-value-value";

        const string responseJson =
            // lang=json
            $$"""
            {
              "{{ErrorsPropertyName}}" : [ {
                "message" : "{{expectedMessage}}",
                "locations" : [ {
                  "line" : 7,
                  "column" : 2
                } ],
                "extensions" : {
                  "value": {
                    "{{expectedValueKey}}": "{{expectedValueValue}}"
                  },
                  "problems": [{
                    "path" : [ "{{expectedProblemPath}}" ],
                    "explanation" : "{{expectedProblemExplanation}}",
                    "message" : "{{expectedProblemMessage}}"
                  }]
                }
              } ]
            }
            """;
        const string expectedRequestId = "some-expected-request-id";
        var response = Utils.MakeRequestResult(responseJson, x => x.RequestId = expectedRequestId);

        A.CallTo(_policy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(response);

        // Act
        var act = async () => await _sut.PostAsync(new GraphRequest
        {
            UserErrorHandling = userErrorHandling
        });

        // Assert
        var exn = await act.Should()
            .ThrowExactlyAsync<ShopifyGraphErrorsException>()
            .WithMessage($"{expectedMessage}");

        exn.Which.RequestId.Should().Be(expectedRequestId);
        exn.Which.InnerException.Should().BeNull();
        exn.Which.GraphErrors.Should().SatisfyRespectively(graphError =>
        {
            graphError.Message.Should().Be(expectedMessage);
            graphError.Path.Should().BeNullOrEmpty();
            graphError.Extensions.Should().BeEquivalentTo(new GraphErrorExtensions
            {
                Value = new Dictionary<string, object>{ {expectedValueKey, expectedValueValue} },
                Problems = [new GraphErrorExtensionsProblem
                {
                    Explanation = expectedProblemExplanation,
                    Message = expectedProblemMessage,
                    Path = [expectedProblemPath]
                }]
            });
        });
    }

    [Theory]
    [CombinatorialData]
    public async Task WhenQueryOrMutationErrorsAreReturned_AndTheArrayIsEmptyWithZeroErrors_ShouldNotThrow(
        GraphRequestUserErrorHandling userErrorHandling)
    {
        // Setup
        const string responseJson =
            // lang=json
            $$"""
            {
              "{{ErrorsPropertyName}}" : [],
              "data": {
                "foo": "bar"
              }
            }
            """;
        const string expectedRequestId = "some-expected-request-id";
        var response = Utils.MakeRequestResult(responseJson, x => x.RequestId = expectedRequestId);

        A.CallTo(_policy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(response);

        // Act
        var act = async () => await _sut.PostAsync(new GraphRequest
        {
            Query = "some-graph-request-query",
            UserErrorHandling = userErrorHandling
        });

        // Assert
        await act.Should()
            .NotThrowAsync();

        var result = await act();
        result.Json
            .GetProperty(ErrorsPropertyName)
            .GetArrayLength()
            .Should()
            .Be(0);
    }

    [Theory]
    [CombinatorialData]
    public async Task WhenQueryOrMutationErrorsAreReturned_AndErrorsPropertyIsNotAnArrayType_ShouldThrow(
        GraphRequestUserErrorHandling userErrorHandling)
    {
        // Setup
        const string responseJson =
            // lang=json
            """
            {
              "errors" : "some-errors-value",
              "data": {
                "foo": "bar"
              }
            }
            """;
        const string expectedRequestId = "some-expected-request-id";
        var response = Utils.MakeRequestResult(responseJson, x => x.RequestId = expectedRequestId);

        A.CallTo(_policy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(response);

        // Act
        var act = async () => await _sut.PostAsync(new GraphRequest
        {
            Query = "some-graph-request-query",
            UserErrorHandling = userErrorHandling
        });

        // Assert
        var exn = await act.Should().ThrowAsync<ShopifyJsonParseException>()
            .WithMessage("Failed to parse errors property, expected Array but got String.");
        exn.Which.RequestId.Should().Be(expectedRequestId);
        exn.Which.JsonPropertyName.Should().Be(ErrorsPropertyPath);
    }

    [Theory]
    [CombinatorialData]
    public async Task WhenQueryOrMutationErrorsAreReturned_AndTheJsonIsMalformed_ShouldThrowRegardlessOfUserErrorHandling(
        GraphRequestUserErrorHandling userErrorHandling)
    {
        // Setup
        const string responseJson =
            // lang=json
            """
            {
              "errors" : [ {
                "message" : "some-message",
                "locations" : [ {
                  "line" : 16,
                  "column" : 13
                } ],
                "path" : [[[["some", "malformed", "string", "array"]]]],
                "extensions" : {
                  "code" : "some-code",
                  "typeName" : "some-type-name",
                  "argumentName" : "some-argument-name"
                }
              } ]
            }
            """;
        const string expectedRequestId = "some-expected-request-id";
        var response = Utils.MakeRequestResult(responseJson, x => x.RequestId = expectedRequestId);

        A.CallTo(_policy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Returns(response);

        // Act
        var act = async () => await _sut.PostAsync(new GraphRequest
        {
            Query = "some-graph-request-query",
            UserErrorHandling = userErrorHandling
        });

        // Assert
        var exn = await act.Should()
            .ThrowExactlyAsync<ShopifyJsonParseException>()
            .WithMessage("An exception was thrown while checking the json document for errors returned by Shopify. Check the inner exception for more details.");

        exn.Which.RequestId.Should().Be(expectedRequestId);
        exn.Which.InnerException.Should().BeOfType<JsonException>();
        exn.Which.JsonPropertyName.Should().NotBeNullOrEmpty();
    }

    [Theory]
    [CombinatorialData]
    public async Task WhenNoUserErrorsAreReturned_ShouldNotThrow(
        GraphRequestUserErrorHandling graphRequestUserErrorHandling
    )
    {
        // Setup
        const string dataPropertyName = "data";
        const string operationPropertyName = "some-operation-property-name";
        const string expectedPropertyName1 = "foo";
        const string expectedPropertyName2 = "bar";
        const int expectedPropertyValue = 7;
        var responseJson =
            $$"""
              {
                "{{dataPropertyName}}": {
                  "{{expectedPropertyName1}}": {{expectedPropertyValue}},
                  "{{operationPropertyName}}": {
                    "{{expectedPropertyName2}}": {{expectedPropertyValue}}
                  }
                }
              }
              """;
        var response = Utils.MakeRequestResult(responseJson);

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
        result.Json
            .GetProperty(dataPropertyName)
            .GetProperty(expectedPropertyName1)
            .GetRawObject()
            .Should()
            .BeOfType<JsonElement>()
            .Which
            .GetInt32()
            .Should()
            .Be(expectedPropertyValue);
        result.Json
            .GetProperty(dataPropertyName)
            .GetProperty(operationPropertyName)
            .GetRawObject()
            .Should()
            .BeOfType<JsonElement>()
            .Which
            .GetProperty(expectedPropertyName2)
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
        var response = Utils.MakeRequestResult(userErrorsJson);

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
        var response = Utils.MakeRequestResult(userErrorsJson);

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
        var response = Utils.MakeRequestResult(userErrorsJson);

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

            exn.Which.JsonPropertyName.Should().Be(UserErrorsPropertyPath);
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
        const string dataPropertyName = "data";
        const string operationPropertyName = "someOperation";
        const string expectedPropertyName = "foo";
        const string responseJson =
            $$"""
              {
                "{{dataPropertyName}}": {
                  "{{operationPropertyName}}": {
                    "{{expectedPropertyName}}": 7,
                    "{{UserErrorsPropertyName}}": []
                  }
                }
              }
              """;
        var response = Utils.MakeRequestResult(responseJson);

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
        var operation = result.Json
            .GetProperty(dataPropertyName)
            .GetProperty(operationPropertyName);

        operation.Should()
            .NotBeNull()
            .And
            .BeOfType<SystemJsonElement>()
            .Which
            .GetRawObject()
            .Should()
            .BeOfType<JsonElement>();
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
        const string dataPropertyName = "data";
        const string operationPropertyName = "someOperation";
        const string expectedPropertyName = "foo";
        const int expectedPropertyValue = 7;
        var responseJson =
            $$"""
              {
                "{{dataPropertyName}}": {
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
        var response = Utils.MakeRequestResult(responseJson);

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
        const string dataPropertyName = "data";
        const string operationPropertyName = "someOperation";
        const string expectedPropertyName = "foo";
        const string responseJson =
            $$"""
              {
                "{{dataPropertyName}}": {
                  "{{operationPropertyName}}": {
                    "{{expectedPropertyName}}": 7,
                    "{{UserErrorsPropertyName}}": [{}]
                  }
                }
              }
              """;
        var response = Utils.MakeRequestResult(responseJson);

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
