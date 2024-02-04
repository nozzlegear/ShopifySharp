#nullable enable
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FluentAssertions;
using JetBrains.Annotations;
using Microsoft.Extensions.DependencyInjection;
using NSubstitute;
using NSubstitute.ExceptionExtensions;
using ShopifySharp.Enums;
using ShopifySharp.Infrastructure;
using ShopifySharp.Tests.TestClasses;
using ShopifySharp.Utilities;
using Xunit;

namespace ShopifySharp.Tests.Utilities;

[TestSubject(typeof(ShopifyOauthUtility))]
[Trait("Category", "ShopifyOauthUtility")]
public class ShopifyOauthUtilityTests
{
    private const string ShopDomain = "example.myshopify.com";
    private const string RedirectUrl = "https://example.com/app";
    private const string ClientId = "some-client-id";

    private ShopifyOauthUtility? _utility;

    [Theory]
    [InlineData(null, null)]
    [InlineData("some-state", null)]
    [InlineData(null, new [] {"per-user"})]
    [InlineData("some-state", new [] { "per-user" })]
    public void BuildAuthorizationUrl_WhenGivenStringScopes_ReturnsTheUrl(string? state, string[]? grants)
    {
        // Setup
        _utility = new ShopifyOauthUtility();
        var scopes = new[] { "some-permission-1", "some-permission-2" };

        // Act
        var result = _utility.BuildAuthorizationUrl(scopes, ShopDomain, ClientId, RedirectUrl, state, grants);

        // Assert
        result.Host.Should().Be("example.myshopify.com");
        result.Port.Should().Be(443);
        result.Scheme.Should().Be(Uri.UriSchemeHttps);
        result.Fragment.Should().BeEmpty();
        result.AbsolutePath.Should().Be("/admin/oauth/authorize");
        result.Query.Should().Contain($"client_id={ClientId}");
        result.Query.Should().Contain("scope=" + string.Join(",", scopes));
        result.Query.Should().Contain($"redirect_uri={RedirectUrl}");

        if (state is not null)
            result.Query.Should().Contain($"state={state}");
        else
            result.Query.Should().NotContain("state=");

        if (grants is not null)
            result.Query.Should().ContainAll(grants.Select(grant => $"grant_options[]={grant}"));
        else
            result.Query.Should().NotContain("grant_options[]=");
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("some-state", null)]
    [InlineData(null, new [] {"per-user"})]
    [InlineData("some-state", new [] { "per-user" })]
    public void Builds_Authorization_Urls_With_Enums(string? state, string[]? grants)
    {
        // Setup
        _utility = new ShopifyOauthUtility();
        string[] expectedEnumStrings = ["read_customers", "write_customers"];
        AuthorizationScope[] scopes = [ AuthorizationScope.ReadCustomers, AuthorizationScope.WriteCustomers ];

        // Act
        var result = _utility.BuildAuthorizationUrl(scopes, ShopDomain, ClientId, RedirectUrl, state, grants);

        // Assert
        result.Host.Should().Be("example.myshopify.com");
        result.Port.Should().Be(443);
        result.Scheme.Should().Be(Uri.UriSchemeHttps);
        result.Fragment.Should().BeEmpty();
        result.AbsolutePath.Should().Be("/admin/oauth/authorize");
        result.Query.Should().Contain($"client_id={ClientId}");
        result.Query.Should().Contain("scope=" + string.Join(",", expectedEnumStrings));
        result.Query.Should().Contain($"redirect_uri={RedirectUrl}");

        if (state is not null)
            result.Query.Should().Contain($"state={state}");
        else
            result.Query.Should().NotContain("state=");

        if (grants is not null)
            result.Query.Should().ContainAll(grants.Select(grant => $"grant_options[]={grant}"));
        else
            result.Query.Should().NotContain("grant_options[]=");
    }

    #if NET8_0_OR_GREATER
    [Theory]
    [InlineData(null, null)]
    [InlineData("some-state", null)]
    [InlineData(null, new [] {"per-user"})]
    [InlineData("some-state", new [] { "per-user" })]
    public void BuildAuthorizationUrl_WhenGivenAuthorizationUrlOptions_ReturnsTheUrl(string? state, string[]? grants)
    {
        // Setup
        _utility = new ShopifyOauthUtility();
        var scopes = new[] { "some-permission-1", "some-permission-2" };

        // Act
        var result = _utility.BuildAuthorizationUrl(new AuthorizationUrlOptions
        {
            Scopes = scopes,
            ShopDomain = ShopDomain,
            ClientId = ClientId,
            RedirectUrl = RedirectUrl,
            State = state,
            Grants = grants
        });

        // Assert
        result.Host.Should().Be("example.myshopify.com");
        result.Port.Should().Be(443);
        result.Scheme.Should().Be(Uri.UriSchemeHttps);
        result.Fragment.Should().BeEmpty();
        result.AbsolutePath.Should().Be("/admin/oauth/authorize");
        result.Query.Should().Contain($"client_id={ClientId}");
        result.Query.Should().Contain("scope=" + string.Join(",", scopes));
        result.Query.Should().Contain($"redirect_uri={RedirectUrl}");

        if (state is not null)
            result.Query.Should().Contain($"state={state}");
        else
            result.Query.Should().NotContain("state=");

        if (grants is not null)
            result.Query.Should().ContainAll(grants.Select(grant => $"grant_options[]={grant}"));
        else
            result.Query.Should().NotContain("grant_options[]=");
    }
    #endif

    [Fact]
    public void ShopifyOauthUtility_ShouldUseDomainUtilityFromDependencyInjection()
    {
        // Setup
        IServiceCollection container = new ServiceCollection();
        var domainUtility = Substitute.For<IShopifyDomainUtility>();
        container.AddSingleton(domainUtility);
        container.AddSingleton<ShopifyOauthUtility>();

        // Mock
        domainUtility.BuildShopDomainUri(ShopDomain)
            .Throws<TestException>();

        // Act
        _utility = container.BuildServiceProvider().GetService<ShopifyOauthUtility>()!;
        var act = () => _utility.BuildAuthorizationUrl([ "some-scope" ], ShopDomain, ClientId, RedirectUrl, "some-state", [ "some-grant" ]);

        // Assert
        act.Should().Throw<TestException>();
    }

    #if NET8_0_OR_GREATER
    [Fact]
    public async Task RefreshAccessTokenAsync_ShouldNotDisposeHttpClient()
    {
        // This is testing the fix for the issue described in #1005 and #1006

        // Setup
        const string shopDomain = "some-shop-domain";
        _utility = new ShopifyOauthUtility();
        var factory = new InternalHttpClientFactory();
        var client = factory.CreateClient("some-name");

        // Act
        var refresh = async () => await _utility.RefreshAccessTokenAsync(new RefreshAccessTokenOptions
        {
            ClientId = "some-client-id",
            ClientSecret = "some-client-secret",
            ExistingStoreAccessToken = "some-existing-store-access-token",
            RefreshToken = "some-refresh-token",
            ShopDomain = shopDomain
        });
        var send = async () =>
        {
            var response = await client.SendAsync(new HttpRequestMessage(HttpMethod.Get, shopDomain));
            response.EnsureSuccessStatusCode();
        };

        // Assert
        await refresh.Should().ThrowAsync<HttpRequestException>();
        await send.Should().NotThrowAsync<ObjectDisposedException>();
    }
    #endif
}
