#nullable enable
using System;
using System.Linq;
using FluentAssertions;
using JetBrains.Annotations;
using NSubstitute;
using ShopifySharp.Enums;
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

    private IShopifyDomainUtility _shopifyDomainUtility;
    private IShopifyOauthUtility _utility;

    public ShopifyOauthUtilityTests()
    {
        _shopifyDomainUtility = Substitute.For<IShopifyDomainUtility>();
        _utility = new ShopifyOauthUtility(_shopifyDomainUtility);
    }

    [Theory]
    [InlineData(null, null)]
    [InlineData("some-state", null)]
    [InlineData(null, new [] {"per-user"})]
    [InlineData("some-state", new [] { "per-user" })]
    public void BuildAuthorizationUrl_WhenGivenStringScopes_ReturnsTheUrl(string? state, string[]? grants)
    {
        // Setup
        var scopes = new[] { "some-permission-1", "some-permission-2" };

        // Mock
        _shopifyDomainUtility.BuildShopDomainUri(ShopDomain)
            .Returns(new Uri(Uri.UriSchemeHttps + Uri.SchemeDelimiter + ShopDomain, UriKind.Absolute));

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
        string[] expectedEnumStrings = ["read_customers", "write_customers"];
        AuthorizationScope[] scopes = [ AuthorizationScope.ReadCustomers, AuthorizationScope.WriteCustomers ];

        // Mock
        _shopifyDomainUtility.BuildShopDomainUri(ShopDomain)
            .Returns(new Uri(Uri.UriSchemeHttps + Uri.SchemeDelimiter + ShopDomain, UriKind.Absolute));

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
        var scopes = new[] { "some-permission-1", "some-permission-2" };

        // Mock
        _shopifyDomainUtility.BuildShopDomainUri(ShopDomain)
            .Returns(new Uri(Uri.UriSchemeHttps + Uri.SchemeDelimiter + ShopDomain, UriKind.Absolute));

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
}
