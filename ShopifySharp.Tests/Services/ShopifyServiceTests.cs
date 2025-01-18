#nullable enable
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FakeItEasy;
using FluentAssertions;
using JetBrains.Annotations;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Policies.ExponentialRetry;
using ShopifySharp.Tests.TestClasses;
using Xunit;

namespace ShopifySharp.Tests.Services;

[Trait("Category", "ShopifyService"), Trait("Category", "DotNetFramework")]
[TestSubject(typeof(ShopifyService))]
public class ShopifyServiceTests
{
    public static HttpMethod[] MakeHttpMethodList() => [HttpMethod.Get, HttpMethod.Post, HttpMethod.Put, HttpMethod.Delete, HttpMethod.Head];

    public static Func<IRequestExecutionPolicy>[] MakeFakedExecutionPoliciesList() =>
        [
            () => A.Fake<IRequestExecutionPolicy>(x => x.Wrapping(new DefaultRequestExecutionPolicy())),
            () => A.Fake<IRequestExecutionPolicy>(x => x.Wrapping(new RetryExecutionPolicy())),
            () => A.Fake<IRequestExecutionPolicy>(x => x.Wrapping(new LeakyBucketExecutionPolicy())),
            () => A.Fake<IRequestExecutionPolicy>(x => x.Wrapping(new ExponentialRetryPolicy(ExponentialRetryPolicyOptions.Default())))
        ];

    #region PrepareRequest(string path) and BuildRequestUri

    [Fact]
    public void BuildRequestUri_ShouldReturnOverridenUri()
    {
        // Setup
        var expectedUri = new Uri("https://some-expected-uri.com", UriKind.Absolute);
        var service = new TestBuildRequestUriShopifyService(expectedUri);

        // Act
        var result = service.BuildRequestUriProxy();

        // Assert
        result.ToUri().Should().Be(expectedUri);
    }

    #endregion

    #region internal ExecuteRequestCoreAsync

    [Theory]
    [CombinatorialData]
    public async Task Internal_ExecuteRequestCoreAsync_WhenRunningTheExecutionPolicy_ShouldNotDisposeTheBaseRequestMessageContent(
        [CombinatorialMemberData(nameof(MakeHttpMethodList))] HttpMethod httpMethod,
        [CombinatorialMemberData(nameof(MakeFakedExecutionPoliciesList))] Func<IRequestExecutionPolicy> makePolicy
    )
    {
        // Setup
        var sut = new TestShopifyServiceWithExposedExecuteRequestCoreAsync();
        var handler = A.Fake<HttpMessageHandler>();
        var content = A.Fake<HttpContent>(x => x.Wrapping(new StringContent("""{"foo":"bar"}""")));
        var policy = makePolicy();

        sut.SetExecutionPolicy(policy);
        sut.SetHttpClient(new HttpClient(handler));

        var callToHandler = A.CallTo(handler)
            .WithReturnType<Task<HttpResponseMessage>>()
            .Where(call => call.Method.Name == "SendAsync");
        var callToPolicy = A.CallTo(policy)
            .WithReturnType<Task<RequestResult<string>>>()
            .Where(call => call.Method.Name == "Run");
        var callToDisposeContent = A.CallTo(content)
            .WithVoidReturnType()
            .Where(call => call.Method.Name == "Dispose");

        callToHandler.ReturnsLazily(() => new HttpResponseMessage
        {
            Content = new JsonContent(new { products = true }),
            StatusCode = HttpStatusCode.OK
        });

        // Act
        var act = async () => await sut.ExecuteRequestCoreAsync(
            new RequestUri(new Uri("https://example.com")),
            httpMethod,
            content,
            [],
            null);

        // Assert
        var result = await act.Should().NotThrowAsync();

        result.Subject.Result.Should().Be("""{"products":true}""");

        callToPolicy.MustHaveHappenedOnceExactly();
        callToHandler.MustHaveHappenedOnceExactly();
        // Dispose may be called more than once depending on the framework (DNF, .Net, Mono, etc.)
        callToDisposeContent.MustHaveHappenedOnceOrMore();
    }

    #endregion
}
