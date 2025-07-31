#nullable enable
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using FakeItEasy;
using FluentAssertions;
using JetBrains.Annotations;
using Microsoft.Extensions.DependencyInjection;
using ShopifySharp.Credentials;
using ShopifySharp.Tests.TestClasses;
using ShopifySharp.Utilities;
using Xunit;

namespace ShopifySharp.Tests.Utilities;

[TestSubject(typeof(ShopifyGraphqlUtility))]
[Trait("Category", "ShopifyGraphqlUtilityTest")]
public class ShopifyGraphqlUtilityTest
{
    private const string ApiVersion = "2025-07";
    private readonly ShopifyApiCredentials _credentials = new("example.myshopify.com", "some-access-token");

    private readonly IServiceProvider _serviceProvider = A.Fake<IServiceProvider>(x => x.Strict());
    private readonly FakeHttpClient _httpClient = A.Fake<FakeHttpClient>(x => x.Strict());

    private readonly ShopifyGraphqlUtility _sut;

    public ShopifyGraphqlUtilityTest()
    {
        var httpClientFactory = new FakeHttpClientFactory(_httpClient);
        var shopifyDomainUtility = new ShopifyDomainUtility();

        A.CallTo(() => _serviceProvider.GetService(typeof(IHttpClientFactory)))
            .Returns(httpClientFactory);
        A.CallTo(() => _serviceProvider.GetService(typeof(IShopifyDomainUtility)))
            .Returns(shopifyDomainUtility);

        _sut = new ShopifyGraphqlUtility(_serviceProvider);
    }

    [Fact]
    public void ShopifyGraphqlUtility_WhenServicesAreNotProvidedViaServiceProvider_ShouldUseDefaultServices()
    {
        // Setup
        var serviceProvider = A.Fake<IServiceProvider>(x => x.Strict());
        var callToGetDomainUtility = A.CallTo(() => serviceProvider.GetService(typeof(IShopifyDomainUtility)));
        var callToGetClientFactory = A.CallTo(() => serviceProvider.GetService(typeof(IHttpClientFactory)));

        callToGetDomainUtility.Returns(null);
        callToGetClientFactory.Returns(null);

        // Act
        var act = () => new ShopifyGraphqlUtility(serviceProvider);

        // Assert
        act.Should().NotThrow();
        callToGetClientFactory.MustHaveHappenedOnceExactly();
        callToGetDomainUtility.MustHaveHappenedOnceExactly();
    }

    [Theory]
    [InlineData("")]
    [InlineData(" ")]
    [InlineData(null)]
    public async Task GetJsonSchemaAsync_WhenGivenAnEmptyApiVersion_ShouldThrow(string? apiVersion)
    {
        // Act
        var act = async () => await _sut.GetSchemaAsJsonStringAsync(_credentials, apiVersion!);

        // Assert
        var exn = await act.Should().ThrowAsync<ArgumentNullException>();
        exn.WithParameterName("apiVersion");
    }

    [Fact]
    public async Task GetSchemaAsJsonStringAsync_WhenGivenAValidApiVersion_ShouldReturnTheJsonString()
    {
        // Setup
        const string json = """{"foo":"bar"}""";
        var expectedUri = new UriBuilder(_credentials.ShopDomain)
        {
            Port = -1,
            Scheme = Uri.UriSchemeHttps,
            Path = $"admin/api/{ApiVersion}/graphql.json"
        };
        Uri? capturedUri = null;

        A.CallTo(() => _httpClient.SendAsync(A<HttpRequestMessage>._, CancellationToken.None))
            .Invokes(call =>
            {
                capturedUri = call.GetArgument<HttpRequestMessage>(0)?.RequestUri;
            })
            .Returns(Utils.MakeHttpResponseMessage(json));

        // Act
        var jsonSchema = await _sut.GetSchemaAsJsonStringAsync(_credentials, ApiVersion);

        // Assert
        jsonSchema.Should().Be(json);
        capturedUri.Should().Be(expectedUri.Uri);
    }

    [Fact]
    public async Task GetSchemaAsJsonStringAsync_WhenTheRequestFails_ShouldThrow()
    {
        // Setup
        const HttpStatusCode expectedStatusCode = HttpStatusCode.BadRequest;
        const string expectedErrorMessage = "some-error-message";
        const string json = $$"""{ "error": "{{expectedErrorMessage}}" }""";
        var result = Utils.MakeHttpResponseMessage(json, x => x.StatusCode = expectedStatusCode);

        A.CallTo(() => _httpClient.SendAsync(A<HttpRequestMessage>._, CancellationToken.None))
            .Returns(result);

        // Act
        var act = async () => await _sut.GetSchemaAsJsonStringAsync(_credentials, ApiVersion);

        // Assert
        var exn = await act.Should().ThrowAsync<ShopifyHttpException>()
            .WithMessage("(400 Bad Request) " + expectedErrorMessage);
        exn.Which.HttpStatusCode.Should().Be(expectedStatusCode);
    }

    [Fact]
    public async Task GetSchemaAsJsonStringAsync_ShouldNotDisposeHttpClient()
    {
        // This is testing the fix for the issue described in #1005 and #1006
        // Setup
        const int attempts = 3;

        var callToClient = A.CallTo(() => _httpClient.SendAsync(A<HttpRequestMessage>._, CancellationToken.None));
        // Create a new HttpResponseMessage, as it'll be disposed on each request
        callToClient.ReturnsLazily(() => Utils.MakeHttpResponseMessage("""{"foo":"bar"}"""));

        // Act
        var act = async () =>
        {
            for (var i = 0; i < attempts; i++)
            {
                await _sut.GetSchemaAsJsonStringAsync(_credentials, ApiVersion);
            }
        };

        // Assert
        await act.Should().NotThrowAsync();

        callToClient.MustHaveHappened(3, Times.Exactly);
        A.CallTo(() => _httpClient.Dispose()).MustNotHaveHappened();
    }

    [UsedImplicitly]
    public class FakeHttpClient : HttpClient, IDisposable
    {
        public new virtual void Dispose()
        {
            base.Dispose();
        }

        public override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException("This method should be mocked.");
        }
    }

    private class FakeHttpClientFactory(FakeHttpClient fakeClient) : IHttpClientFactory
    {
        public HttpClient CreateClient(string name)
        {
            return fakeClient;
        }
    }
}
