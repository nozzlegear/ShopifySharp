#nullable enable
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using FakeItEasy;
using FluentAssertions;
using JetBrains.Annotations;
using Microsoft.Extensions.DependencyInjection;
using ShopifySharp.Entities;
using ShopifySharp.Enums;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
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

    private readonly IShopifyDomainUtility _shopifyDomainUtility = A.Fake<IShopifyDomainUtility>(x => x.Wrapping(new ShopifyDomainUtility()).CallsBaseMethods());
    private readonly IJsonSerializer _jsonSerializer = new SystemJsonSerializer(Serializer.RestSerializerOptions);
    private readonly IServiceProvider _serviceProvider = A.Fake<IServiceProvider>(x => x.Strict());
    private readonly FakeHttpClient _httpClient = A.Fake<FakeHttpClient>(x => x.Strict());

    private readonly ShopifyOauthUtility _sut;

    public ShopifyOauthUtilityTests()
    {
        var httpClientFactory = new FakeHttpClientFactory(_httpClient);

        A.CallTo(() => _serviceProvider.GetService(typeof(IShopifyDomainUtility)))
            .Returns(_shopifyDomainUtility);
        A.CallTo(() => _serviceProvider.GetService(typeof(IHttpClientFactory)))
            .Returns(httpClientFactory);
        A.CallTo(() => _serviceProvider.GetService(typeof(IJsonSerializer)))
            .Returns(_jsonSerializer);

        _sut = new ShopifyOauthUtility(_serviceProvider);
    }

    [Fact]
    public void ShopifyOauthUtility_ShouldUseDomainUtilityFromDependencyInjection()
    {
        // Setup
        IServiceCollection container = new ServiceCollection();
        var domainUtility = A.Fake<IShopifyDomainUtility>();
        container.AddSingleton(domainUtility);
        container.AddSingleton<ShopifyOauthUtility>();

        // Mock
        A.CallTo(() => domainUtility.BuildShopDomainUri(ShopDomain))
            .Throws<TestException>();

        // Act
        var utility = container.BuildServiceProvider().GetService<ShopifyOauthUtility>()!;
        var act = () => utility.BuildAuthorizationUrl([ "some-scope" ], ShopDomain, ClientId, RedirectUrl, "some-state", [ "some-grant" ]);

        // Assert
        act.Should().Throw<TestException>();
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

        // Act
        var result = _sut.BuildAuthorizationUrl(scopes, ShopDomain, ClientId, RedirectUrl, state, grants);

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
    public void BuildAuthorizationUrl_WhenGivenEnumScopes_ReturnsTheUrl(string? state, string[]? grants)
    {
        // Setup
        string[] expectedEnumStrings = ["read_customers", "write_customers"];
        AuthorizationScope[] scopes = [ AuthorizationScope.ReadCustomers, AuthorizationScope.WriteCustomers ];

        // Act
        var result = _sut.BuildAuthorizationUrl(scopes, ShopDomain, ClientId, RedirectUrl, state, grants);

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

    [Theory]
    [InlineData(null, AuthorizationAccessMode.Offline)]
    [InlineData("some-state", AuthorizationAccessMode.Offline)]
    [InlineData(null, AuthorizationAccessMode.Online)]
    [InlineData("some-state", AuthorizationAccessMode.Online)]
    public void BuildAuthorizationUrl_WhenGivenAuthorizationUrlOptions_ReturnsTheUrl(string? state, AuthorizationAccessMode authorizationAccessMode)
    {
        // Setup
        var scopes = new[] { "some-permission-1", "some-permission-2" };

        // Act
        var result = _sut.BuildAuthorizationUrl(new AuthorizationUrlOptions
        {
            Scopes = scopes,
            ShopDomain = ShopDomain,
            ClientId = ClientId,
            RedirectUrl = RedirectUrl,
            State = state,
            AuthorizationAccessMode = authorizationAccessMode
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

        if (authorizationAccessMode == AuthorizationAccessMode.Online)
            result.Query.Should().Contain("grant_options[]=per_user");
        else
            result.Query.Should().NotContain("grant_options[]=");
    }

    [Fact]
    public void BuildAuthorizationUrl_WhenOptionsSetGrantsArray_ShouldAddGrantOptionsToUri()
    {
        // Setup
        string[] grants = ["some-grant-1", "some-grant-2"];

        // Act
        var result = _sut.BuildAuthorizationUrl(new AuthorizationUrlOptions
        {
            Scopes = ["some-permission-1"],
            ShopDomain = ShopDomain,
            ClientId = ClientId,
            RedirectUrl = RedirectUrl,
            State = "some-state",
#pragma warning disable CS0618 // Type or member is obsolete
            Grants = grants
#pragma warning restore CS0618 // Type or member is obsolete
        });

        // Assert
        result.Query.Should().ContainAll(string.Join("&", grants.Select(g => "grant_options[]=" + g)));
    }

    [Fact]
    public void BuildAuthorizationUrl_WhenAuthorizationUrlOptionsContainsBothGrantsAndAuthorizationAccessMode_ShouldThrow()
    {
        // Act
        var act = () => _sut.BuildAuthorizationUrl(new AuthorizationUrlOptions
        {
            Scopes = ["some-permission-1"],
            ShopDomain = ShopDomain,
            ClientId = ClientId,
            RedirectUrl = RedirectUrl,
            State = "some-state",
#pragma warning disable CS0618 // Type or member is obsolete
            Grants = ["per-user"],
#pragma warning restore CS0618 // Type or member is obsolete
            AuthorizationAccessMode = AuthorizationAccessMode.Online
        });

        // Assert
        act.Should().Throw<ArgumentException>()
            .WithMessage("Invalid AuthorizationUrlOptions. Cannot use the obsolete Grants alongside AuthorizationAccessMode.");
    }

    [Fact(DisplayName = "AuthorizeAsync(AuthorizeOptions) should call the base AuthorizeAsync(string, string, string, string) method")]
    public async Task AuthorizeAsync_WithAuthorizeOptionsParameters_ShouldCallBaseAuthorizeAsyncMethodAndPassOptionsToMethod()
    {
        // Setup
        const string expectedDomain = "authorize-options-domain-test";
        var authorizeOptions = new AuthorizeOptions
        {
            Code = "some-code",
            ShopDomain = expectedDomain,
            ClientId = "some-client-id",
            ClientSecret = "some-client-secret"
        };
        //lang=json

        var callToDomainUtil = A.CallTo(() => _shopifyDomainUtility.BuildShopDomainUri(expectedDomain));
        callToDomainUtil.Throws<TestException>();

        // Act
        var act = async () => await _sut.AuthorizeAsync(authorizeOptions);

        // Assert
        await act.Should().ThrowAsync<TestException>();
        callToDomainUtil.MustHaveHappenedOnceExactly();
    }

    [Fact]
    public async Task AuthorizeAsync_WhenAnErrorIsReturned_ShouldThrow()
    {
        // Setup
        const HttpStatusCode expectedStatusCode = HttpStatusCode.BadRequest;
        const string expectedErrorMessage = "some-error-message";
        const string json = $$"""{ "error": "{{expectedErrorMessage}}" }""";
        var result = Utils.MakeHttpResponseMessage(json, x => x.StatusCode = expectedStatusCode);

        A.CallTo(() => _httpClient.SendAsync(A<HttpRequestMessage>._, CancellationToken.None))
            .Returns(result);

        // Act
        var act = async () => await _sut.AuthorizeAsync("some-code", ShopDomain, ClientId, "some-secret");

        // Assert
        var exn = await act.Should().ThrowAsync<ShopifyHttpException>()
            .WithMessage("(400 Bad Request) " + expectedErrorMessage);
        exn.Which.HttpStatusCode.Should().Be(expectedStatusCode);
    }

    [Theory]
    [CombinatorialData]
    public async Task AuthorizeAsync_WhenTheResponseDoesNotContainAUserObject_ShouldReturnAnAuthorizationResultWithNullOnlineAccess(bool includeNullValue)
    {
        // Setup
        const string accessToken = "some-access-token";
        var json = includeNullValue
            //lang=json
            ? $$"""
              { 
                "access_token": "{{accessToken}}",
                "scope": "",
                "user": null
              }
              """
            //lang=json
            : $$"""
              { 
                "access_token": "{{accessToken}}",
                "scope": ""
              }
              """;
        var result = Utils.MakeHttpResponseMessage(json);

        A.CallTo(() => _httpClient.SendAsync(A<HttpRequestMessage>._, CancellationToken.None))
            .Returns(result);

        // Act
        var authorizationResult = await _sut.AuthorizeAsync("some-code", ShopDomain, ClientId, "some-secret");

        // Assert
        authorizationResult.AccessToken.Should().Be(accessToken);
        authorizationResult.GrantedScopes.Should().BeEmpty();
        authorizationResult.OnlineAccess.Should().BeNull();
        authorizationResult.IsOnlineAccess.Should().BeFalse();
    }

    [Theory]
    [InlineData(true, null)]
    [InlineData(true, "")]
    [InlineData(true, " ", "", "    ")]
    [InlineData(true, " ", "", " ", "   ", "    ")]
    [InlineData(false, "granted_scope_1", "granted_scope_2", "granted_scope_3")]
    public async Task AuthorizeAsync_WhenGivenGrantedScopes_ShouldParseTheScopesAndReturnThemWithTheAuthorizedResult(bool expectEmpty, params string[]? scopes)
    {
        // Setup
        const string accessToken = "some-access-token";
        var json = scopes is null ?
            //lang=json
            $$"""
              { 
                "access_token": "{{accessToken}}",
                "scope": ""
              }
              """
            // lang=json
            : $$"""
              { 
                "access_token": "{{accessToken}}",
                "scope": "{{string.Join(",", scopes)}}"
              }
              """;
        var result = Utils.MakeHttpResponseMessage(json);

        A.CallTo(() => _httpClient.SendAsync(A<HttpRequestMessage>._, CancellationToken.None))
            .Returns(result);

        // Act
        var authorizationResult = await _sut.AuthorizeAsync("some-code", ShopDomain, ClientId, "some-secret");

        // Assert
        authorizationResult.AccessToken.Should().Be(accessToken);
        authorizationResult.OnlineAccess.Should().BeNull();
        authorizationResult.IsOnlineAccess.Should().BeFalse();

        if (expectEmpty)
            authorizationResult.GrantedScopes.Should().BeEmpty();
        else
            authorizationResult.GrantedScopes.Should().BeEquivalentTo(scopes);
    }

    [Theory]
    [CombinatorialData]
    public async Task AuthorizeAsync_WhenTheResponseContainsAUserObject_AndExpiresInIsNullOrMissing_ShouldThrow(bool valueIsMissing)
    {
        // Setup
        const string accessToken = "some-access-token";
        var expectedUser = new AssociatedUser
        {
            Id = 7,
            FirstName = "some-first-name",
            LastName = "some-last-name",
            Email = "some-email",
            EmailVerified = true,
            AccountOwner = true,
            Locale = "some-locale",
            Collaborator = true
        };
        var userJson =
            //lang=json
            $$"""
            {
              "id": {{expectedUser.Id}},
              "first_name": "{{expectedUser.FirstName}}",
              "last_name": "{{expectedUser.LastName}}",
              "email": "{{expectedUser.Email}}",
              "email_verified": {{expectedUser.EmailVerified.ToString().ToLower()}},
              "account_owner": {{expectedUser.AccountOwner.ToString().ToLower()}},
              "locale": "{{expectedUser.Locale}}",
              "collaborator": {{expectedUser.Collaborator.ToString().ToLower()}}
            }
            """;
        var json = valueIsMissing ?
            //lang=json
            $$"""
              { 
                "access_token": "{{accessToken}}",
                "scope": "",
                "associated_user_scope": "",
                "associated_user": {{userJson}}
              }
              """
            // lang=json
            : $$"""
              { 
                "access_token": "{{accessToken}}",
                "scope": "",
                "associated_user_scope": "",
                "expires_in": null,
                "associated_user": {{userJson}}
              }
              """;

        var result = Utils.MakeHttpResponseMessage(json);

        A.CallTo(() => _httpClient.SendAsync(A<HttpRequestMessage>._, CancellationToken.None))
            .Returns(result);

        // Act
        var act = async () => await _sut.AuthorizeAsync("some-code", ShopDomain, ClientId, "some-secret");

        // Assert
        var exn = await act.Should().ThrowAsync<ShopifyJsonParseException>()
            .WithMessage("The JSON response from Shopify does not contain a valid 'expires_in' property. The property was null or missing.");
        exn.Which.JsonPropertyName.Should().Be("expires_in");
    }

    [Fact]
    public async Task AuthorizeAsync_WhenTheResponseContainsAUserObject_AndExpiresInIsValid_ShouldReturnAnAuthorizationResultWithOnlineAccessAndExpiresInTimeSpan()
    {
        // Setup
        const int expiresIn = 123;
        const string accessToken = "some-access-token";
        var expectedUser = new AssociatedUser
        {
            Id = 7,
            FirstName = "some-first-name",
            LastName = "some-last-name",
            Email = "some-email",
            EmailVerified = true,
            AccountOwner = true,
            Locale = "some-locale",
            Collaborator = true
        };
        var json =
            //lang=json
            $$"""
              { 
                "access_token": "{{accessToken}}",
                "scope": "",
                "associated_user_scope": "",
                "expires_in": {{expiresIn}},
                "associated_user": {
                  "id": {{expectedUser.Id}},
                  "first_name": "{{expectedUser.FirstName}}",
                  "last_name": "{{expectedUser.LastName}}",
                  "email": "{{expectedUser.Email}}",
                  "email_verified": {{expectedUser.EmailVerified.ToString().ToLower()}},
                  "account_owner": {{expectedUser.AccountOwner.ToString().ToLower()}},
                  "locale": "{{expectedUser.Locale}}",
                  "collaborator": {{expectedUser.Collaborator.ToString().ToLower()}}
                }
              }
              """;
        var result = Utils.MakeHttpResponseMessage(json);

        A.CallTo(() => _httpClient.SendAsync(A<HttpRequestMessage>._, CancellationToken.None))
            .Returns(result);

        // Act
        var authorizationResult = await _sut.AuthorizeAsync("some-code", ShopDomain, ClientId, "some-secret");

        // Assert
        authorizationResult.IsOnlineAccess.Should().BeTrue();
        authorizationResult.OnlineAccess.Should().NotBeNull();

        var onlineAccess = authorizationResult.OnlineAccess!;
        onlineAccess.ExpiresIn.Should().BeCloseTo(TimeSpan.FromSeconds(expiresIn), TimeSpan.FromSeconds(3), "expiration should be within 3 seconds of test value");
        onlineAccess.AssociatedUserScopes.Should().BeEmpty();
        onlineAccess.AssociatedUser.Should().BeEquivalentTo(expectedUser);
    }

    [Theory]
    [InlineData(true, null)]
    [InlineData(true, "")]
    [InlineData(true, " ", "", "    ")]
    [InlineData(true, " ", "", " ", "   ", "    ")]
    [InlineData(false, "granted_scope_1", "granted_scope_2", "granted_scope_3")]
    public async Task AuthorizeAsync_WhenTheResponseContainsAUserObject_AndTheUserAssociatedUserScopesIsNullOrEmpty_ShouldReturnAnAuthorizationResultWithOnlineAccessPopulatedAndTheExpectedAssociatedUserScopes(bool expectEmpty, params string[]? scopes)
    {
        // Setup
        const int expiresIn = 123;
        const string accessToken = "some-access-token";
        var expectedUser = new AssociatedUser
        {
            Id = 7,
            FirstName = "some-first-name",
            LastName = "some-last-name",
            Email = "some-email",
            EmailVerified = true,
            AccountOwner = true,
            Locale = "some-locale",
            Collaborator = true
        };
        var associatedUserJson =
            //lang=json
            $$"""
              { 
                "id": {{expectedUser.Id}},
                "first_name": "{{expectedUser.FirstName}}",
                "last_name": "{{expectedUser.LastName}}",
                "email": "{{expectedUser.Email}}",
                "email_verified": {{expectedUser.EmailVerified.ToString().ToLower()}},
                "account_owner": {{expectedUser.AccountOwner.ToString().ToLower()}},
                "locale": "{{expectedUser.Locale}}",
                "collaborator": {{expectedUser.Collaborator.ToString().ToLower()}}
              }
              """;
        var json = scopes is null ?
            //lang=json
            $$"""
              { 
                "access_token": "{{accessToken}}",
                "scope": "",
                "expires_in": {{expiresIn}},
                "associated_user": {{associatedUserJson}}
              }
              """
            // lang=json
            : $$"""
              { 
                "access_token": "{{accessToken}}",
                "scope": "",
                "expires_in": {{expiresIn}},
                "associated_user": {{associatedUserJson}},
                "associated_user_scope": "{{string.Join(",", scopes)}}"
              }
              """;
        var result = Utils.MakeHttpResponseMessage(json);

        A.CallTo(() => _httpClient.SendAsync(A<HttpRequestMessage>._, CancellationToken.None))
            .Returns(result);

        // Act
        var authorizationResult = await _sut.AuthorizeAsync("some-code", ShopDomain, ClientId, "some-secret");

        // Assert
        authorizationResult.AccessToken.Should().Be(accessToken);
        authorizationResult.GrantedScopes.Should().BeEmpty();
        authorizationResult.OnlineAccess.Should().NotBeNull();
        authorizationResult.IsOnlineAccess.Should().BeTrue();

        var onlineAccess = authorizationResult.OnlineAccess!;
        onlineAccess.ExpiresIn.Should().BeCloseTo(TimeSpan.FromSeconds(expiresIn), TimeSpan.FromSeconds(3), "expiration should be within 3 seconds of test value");
        onlineAccess.AssociatedUser.Should().BeEquivalentTo(expectedUser);

        if (expectEmpty)
            onlineAccess.AssociatedUserScopes.Should().BeEmpty();
        else
            onlineAccess.AssociatedUserScopes.Should().BeEquivalentTo(scopes);
    }

    #region RefreshAccessTokenAsync tests

    [Fact]
    public async Task RefreshAccessTokenAsync_WhenAnErrorIsReturned_ShouldThrow()
    {
        // Setup
        const HttpStatusCode expectedStatusCode = HttpStatusCode.BadRequest;
        const string expectedErrorMessage = "some-error-message";
        const string json = $$"""{ "error": "{{expectedErrorMessage}}" }""";
        var result = Utils.MakeHttpResponseMessage(json, x => x.StatusCode = expectedStatusCode);

        A.CallTo(() => _httpClient.SendAsync(A<HttpRequestMessage>._, CancellationToken.None))
            .Returns(result);

        // Act
        var act = async () => await _sut.RefreshAccessTokenAsync(
            ShopDomain,
            ClientId,
            "some-client-secret",
            "some-refresh-token",
            "some-existing-store-access-token"
        );

        // Assert
        var exn = await act.Should().ThrowAsync<ShopifyHttpException>()
            .WithMessage("(400 Bad Request) " + expectedErrorMessage);
        exn.Which.HttpStatusCode.Should().Be(expectedStatusCode);
    }

    [Theory]
    [CombinatorialData]
    public async Task RefreshAccessTokenAsync_WhenNoAssociatedUserIsPresent_ShouldPass(bool includeNullValue)
    {
        // Setup
        const string accessToken = "some-access-token";
        var json = includeNullValue
            //lang=json
            ? $$"""
              { 
                "access_token": "{{accessToken}}",
                "scope": "",
                "user": null
              }
              """
            //lang=json
            : $$"""
              { 
                "access_token": "{{accessToken}}",
                "scope": ""
              }
              """;
        var result = Utils.MakeHttpResponseMessage(json);

        A.CallTo(() => _httpClient.SendAsync(A<HttpRequestMessage>._, CancellationToken.None))
            .Returns(result);

        // Act
        var authorizationResult = await _sut.RefreshAccessTokenAsync(
            ShopDomain,
            ClientId,
            "some-client-secret",
            "some-refresh-token",
            "some-existing-store-access-token"
        );

        // Assert
        authorizationResult.AccessToken.Should().Be(accessToken);
        authorizationResult.GrantedScopes.Should().BeEmpty();
        authorizationResult.OnlineAccess.Should().BeNull();
        authorizationResult.IsOnlineAccess.Should().BeFalse();
    }

    [Fact]
    public async Task RefreshAccessTokenAsync_WhenAnAssociatedUserIsPresent_ShouldPassAndReturnAnAuthorizationResultWithAnAssociatedUser()
    {
        // Setup
        const int expiresIn = 123;
        const string accessToken = "some-access-token";
        var expectedUser = new AssociatedUser
        {
            Id = 7,
            FirstName = "some-first-name",
            LastName = "some-last-name",
            Email = "some-email",
            EmailVerified = true,
            AccountOwner = true,
            Locale = "some-locale",
            Collaborator = true
        };
        var json =
            //lang=json
            $$"""
              { 
                "access_token": "{{accessToken}}",
                "scope": "",
                "associated_user_scope": "",
                "expires_in": {{expiresIn}},
                "associated_user": {
                  "id": {{expectedUser.Id}},
                  "first_name": "{{expectedUser.FirstName}}",
                  "last_name": "{{expectedUser.LastName}}",
                  "email": "{{expectedUser.Email}}",
                  "email_verified": {{expectedUser.EmailVerified.ToString().ToLower()}},
                  "account_owner": {{expectedUser.AccountOwner.ToString().ToLower()}},
                  "locale": "{{expectedUser.Locale}}",
                  "collaborator": {{expectedUser.Collaborator.ToString().ToLower()}}
                }
              }
              """;
        var result = Utils.MakeHttpResponseMessage(json);

        A.CallTo(() => _httpClient.SendAsync(A<HttpRequestMessage>._, CancellationToken.None))
            .Returns(result);

        // Act
        var authorizationResult = await _sut.RefreshAccessTokenAsync(
            ShopDomain,
            ClientId,
            "some-client-secret",
            "some-refresh-token",
            "some-existing-store-access-token"
        );

        // Assert
        authorizationResult.IsOnlineAccess.Should().BeTrue();
        authorizationResult.OnlineAccess.Should().NotBeNull();

        var onlineAccess = authorizationResult.OnlineAccess!;
        onlineAccess.ExpiresIn.Should().BeCloseTo(TimeSpan.FromSeconds(expiresIn), TimeSpan.FromSeconds(3), "expiration should be within 3 seconds of test value");
        onlineAccess.AssociatedUserScopes.Should().BeEmpty();
        onlineAccess.AssociatedUser.Should().BeEquivalentTo(expectedUser);
    }

    [Theory]
    [InlineData(true, null)]
    [InlineData(true, "")]
    [InlineData(true, " ", "", "    ")]
    [InlineData(true, " ", "", " ", "   ", "    ")]
    [InlineData(false, "granted_scope_1", "granted_scope_2", "granted_scope_3")]
    public async Task RefreshAccessTokenAsync_ShouldParseScopesAndPass(bool expectEmpty, params string[]? scopes)
    {
        // Setup
        const string accessToken = "some-access-token";
        var json = scopes is null ?
            //lang=json
            $$"""
              { 
                "access_token": "{{accessToken}}",
                "scope": ""
              }
              """
            // lang=json
            : $$"""
              { 
                "access_token": "{{accessToken}}",
                "scope": "{{string.Join(",", scopes)}}"
              }
              """;
        var result = Utils.MakeHttpResponseMessage(json);

        var callToClient = A.CallTo(() => _httpClient.SendAsync(A<HttpRequestMessage>._, CancellationToken.None));
        callToClient.Returns(result);

        // Act
        var authorizationResult = await _sut.RefreshAccessTokenAsync(
            ShopDomain,
            ClientId,
            "some-client-secret",
            "some-refresh-token",
            "some-existing-store-access-token"
        );

        // Assert
        authorizationResult.AccessToken.Should().Be(accessToken);
        authorizationResult.OnlineAccess.Should().BeNull();
        authorizationResult.IsOnlineAccess.Should().BeFalse();

        if (expectEmpty)
            authorizationResult.GrantedScopes.Should().BeEmpty();
        else
            authorizationResult.GrantedScopes.Should().BeEquivalentTo(scopes);
    }

    [Theory]
    [InlineData(true, null)]
    [InlineData(true, "")]
    [InlineData(true, " ", "", "    ")]
    [InlineData(true, " ", "", " ", "   ", "    ")]
    [InlineData(false, "granted_scope_1", "granted_scope_2", "granted_scope_3")]
    public async Task RefreshAccessTokenAsync_WhenAnAssociatedUserIsPresent_ShouldParseAssociatedUserScopeAndPass(bool expectEmpty, params string[]? scopes)
    {
        // Setup
        const int expiresIn = 123;
        const string accessToken = "some-access-token";
        var expectedUser = new AssociatedUser
        {
            Id = 7,
            FirstName = "some-first-name",
            LastName = "some-last-name",
            Email = "some-email",
            EmailVerified = true,
            AccountOwner = true,
            Locale = "some-locale",
            Collaborator = true
        };
        var associatedUserJson =
            //lang=json
            $$"""
              { 
                "id": {{expectedUser.Id}},
                "first_name": "{{expectedUser.FirstName}}",
                "last_name": "{{expectedUser.LastName}}",
                "email": "{{expectedUser.Email}}",
                "email_verified": {{expectedUser.EmailVerified.ToString().ToLower()}},
                "account_owner": {{expectedUser.AccountOwner.ToString().ToLower()}},
                "locale": "{{expectedUser.Locale}}",
                "collaborator": {{expectedUser.Collaborator.ToString().ToLower()}}
              }
              """;
        var json = scopes is null ?
            //lang=json
            $$"""
              { 
                "access_token": "{{accessToken}}",
                "scope": "",
                "expires_in": {{expiresIn}},
                "associated_user": {{associatedUserJson}}
              }
              """
            // lang=json
            : $$"""
              { 
                "access_token": "{{accessToken}}",
                "scope": "",
                "expires_in": {{expiresIn}},
                "associated_user": {{associatedUserJson}},
                "associated_user_scope": "{{string.Join(",", scopes)}}"
              }
              """;
        var result = Utils.MakeHttpResponseMessage(json);

        A.CallTo(() => _httpClient.SendAsync(A<HttpRequestMessage>._, CancellationToken.None))
            .Returns(result);

        // Act
        var authorizationResult = await _sut.RefreshAccessTokenAsync(
            ShopDomain,
            ClientId,
            "some-client-secret",
            "some-refresh-token",
            "some-existing-store-access-token"
        );

        // Assert
        authorizationResult.AccessToken.Should().Be(accessToken);
        authorizationResult.GrantedScopes.Should().BeEmpty();
        authorizationResult.OnlineAccess.Should().NotBeNull();
        authorizationResult.IsOnlineAccess.Should().BeTrue();

        var onlineAccess = authorizationResult.OnlineAccess!;
        onlineAccess.ExpiresIn.Should().BeCloseTo(TimeSpan.FromSeconds(expiresIn), TimeSpan.FromSeconds(3), "expiration should be within 3 seconds of test value");
        onlineAccess.AssociatedUser.Should().BeEquivalentTo(expectedUser);

        if (expectEmpty)
            onlineAccess.AssociatedUserScopes.Should().BeEmpty();
        else
            onlineAccess.AssociatedUserScopes.Should().BeEquivalentTo(scopes);
    }

    [Theory]
    [CombinatorialData]
    public async Task MethodsUsingHttpClientFactory_ShouldNotDisposeHttpClient(bool targetMethodIsAuthorizeAsync)
    {
        // This is testing the fix for the issue described in #1005 and #1006

        // Setup
        const int attempts = 3;
        const string json =
            //lang=json
            """
            {
              "access_token": "some-access-token",
              "scope": ""
            }
            """;

        var callToClient = A.CallTo(() => _httpClient.SendAsync(A<HttpRequestMessage>._, CancellationToken.None));
        // Create a new HttpResponseMessage, as it'll be disposed on each request
        callToClient.ReturnsLazily(() => Utils.MakeHttpResponseMessage(json));

        // Act
        var act = async () =>
        {
            for (var i = 0; i < attempts; i++)
            {
                if (targetMethodIsAuthorizeAsync)
                {
                    await _sut.AuthorizeAsync(new AuthorizeOptions
                    {
                        Code = "some-code",
                        ShopDomain = ShopDomain,
                        ClientId = ClientId,
                        ClientSecret = "some-client-secret"
                    });
                }
                else
                {
                    await _sut.RefreshAccessTokenAsync(new RefreshAccessTokenOptions
                    {
                        ClientId = ShopDomain,
                        ClientSecret = "some-client-secret",
                        ExistingStoreAccessToken = "some-existing-store-access-token",
                        RefreshToken = "some-refresh-token",
                        ShopDomain = ShopDomain
                    });
                }
            }
        };

        // Assert
        await act.Should().NotThrowAsync();

        callToClient.MustHaveHappened(3, Times.Exactly);
        A.CallTo(() => _httpClient.Dispose()).MustNotHaveHappened();
    }

    #endregion

    #region AuthorizeAsync – Null and invalid type tests

    [Theory]
    [InlineData("""{"access_token":null}""", true)]
    [InlineData("""{"access_token":""}""", true)]
    [InlineData("""{"access_token":" "}""", true)]
    [InlineData("""{"scope":""}""", true)]
    [InlineData("""{"access_token":true}""", false)]
    [InlineData("""{"access_token":false}""", false)]
    [InlineData("""{"access_token":123}""", false)]
    [InlineData("""{"access_token":["an array"]}""", false)]
    public async Task AuthorizeAsync_WhenTheAccessTokenIsNullOrEmptyOrAnInvalidType_ShouldThrowAShopifyJsonParseException(string json, bool expectNullOrMissing)
    {
        // Setup
        var result = Utils.MakeHttpResponseMessage(json);

        A.CallTo(() => _httpClient.SendAsync(A<HttpRequestMessage>._, CancellationToken.None))
            .Returns(result);

        // Act
        var act = async () => await _sut.AuthorizeAsync("some-code", ShopDomain, ClientId, "some-secret");

        // Assert
        var exn = await act.Should().ThrowAsync<ShopifyJsonParseException>();

        if (expectNullOrMissing)
            exn = exn.WithMessage("The JSON response from Shopify does not contain a valid 'access_token' property. The property was null or *.");
        else
            exn = exn.WithMessage("The JSON response from Shopify does not contain a valid 'access_token' property. The property type was *, which is invalid.");
        exn.Which.JsonPropertyName.Should().Be("access_token");
    }

    [Theory]
    [InlineData("true")]
    [InlineData("false")]
    [InlineData("123")]
    [InlineData("[123, 456]")]
    [InlineData("""{"foo":"bar"}""")]
    public async Task AuthorizeAsync_WhenScopeIsAnInvalidType_ShouldThrowAShopifyJsonParseException(string scopeValue)
    {
        // Setup
        var json =
            //lang=json
            $$"""
              {
                "access_token": "some-access-token",
                "scope": {{scopeValue}}
              }
              """;
        var result = Utils.MakeHttpResponseMessage(json);

        A.CallTo(() => _httpClient.SendAsync(A<HttpRequestMessage>._, CancellationToken.None))
            .Returns(result);

        // Act
        var act = async () => await _sut.AuthorizeAsync("some-code", ShopDomain, ClientId, "some-secret");

        // Assert
        var exn = await act.Should().ThrowAsync<ShopifyJsonParseException>()
            .WithMessage("The JSON response from Shopify does not contain a valid 'scope' property. The property type was *, which is invalid.");
        exn.Which.JsonPropertyName.Should().Be("scope");
    }

    [Theory]
    [InlineData("true")]
    [InlineData("false")]
    [InlineData("123")]
    [InlineData("[123, 456]")]
    [InlineData("\"hello world\"")]
    public async Task AuthorizeAsync_WhenAssociatedUserIsAnInvalidType_ShouldThrowAShopifyJsonParseException(string userValue)
    {
        // Setup
        var json =
            //lang=json
            $$"""
              {
                "access_token": "some-access-token",
                "scope": "",
                "expires_in": 123,
                "associated_user_scope": "",
                "associated_user": {{userValue}}
              }
              """;
        var result = Utils.MakeHttpResponseMessage(json);

        A.CallTo(() => _httpClient.SendAsync(A<HttpRequestMessage>._, CancellationToken.None))
            .Returns(result);

        // Act
        var act = async () => await _sut.AuthorizeAsync("some-code", ShopDomain, ClientId, "some-secret");

        // Assert
        var exn = await act.Should().ThrowAsync<ShopifyJsonParseException>()
            .WithMessage("The JSON response from Shopify does not contain a valid 'associated_user' property. The property type was *, which is invalid.");
        exn.Which.JsonPropertyName.Should().Be("associated_user");
    }

    [Theory]
    [InlineData("true")]
    [InlineData("false")]
    [InlineData("[123, 456]")]
    [InlineData("""{"foo":"bar"}""")]
    [InlineData("\"hello world\"")]
    public async Task AuthorizeAsync_WhenExpiresInIsAnInvalidType_ShouldThrowAShopifyJsonParseException(string expiresInValue)
    {
        // Setup
        var json =
            //lang=json
            $$"""
              {
                "access_token": "some-access-token",
                "scope": "",
                "expires_in": {{expiresInValue}},
                "associated_user_scope": "",
                "associated_user": { "foo": "bar" }
              }
              """;
        var result = Utils.MakeHttpResponseMessage(json);

        A.CallTo(() => _httpClient.SendAsync(A<HttpRequestMessage>._, CancellationToken.None))
            .Returns(result);

        // Act
        var act = async () => await _sut.AuthorizeAsync("some-code", ShopDomain, ClientId, "some-secret");

        // Assert
        var exn = await act.Should().ThrowAsync<ShopifyJsonParseException>()
            .WithMessage("The JSON response from Shopify does not contain a valid 'expires_in' property. The property type was *, which is invalid.");
        exn.Which.JsonPropertyName.Should().Be("expires_in");
    }

    [Theory]
    [InlineData("true")]
    [InlineData("false")]
    [InlineData("123")]
    [InlineData("[123, 456]")]
    [InlineData("""{"foo":"bar"}""")]
    public async Task AuthorizeAsync_WhenAssociatedUserScopeIsAnInvalidType_ShouldThrowAShopifyJsonParseException(string associatedUserScopeValue)
    {
        // Setup
        var json =
            //lang=json
            $$"""
              {
                "access_token": "some-access-token",
                "scope": "",
                "expires_in": 123,
                "associated_user_scope": {{associatedUserScopeValue}},
                "associated_user": { "foo": "bar" }
              }
              """;
        var result = Utils.MakeHttpResponseMessage(json);

        A.CallTo(() => _httpClient.SendAsync(A<HttpRequestMessage>._, CancellationToken.None))
            .Returns(result);

        // Act
        var act = async () => await _sut.AuthorizeAsync("some-code", ShopDomain, ClientId, "some-secret");

        // Assert
        var exn = await act.Should().ThrowAsync<ShopifyJsonParseException>()
            .WithMessage("The JSON response from Shopify does not contain a valid 'associated_user_scope' property. The property type was *, which is invalid.");
        exn.Which.JsonPropertyName.Should().Be("associated_user_scope");
    }

    #endregion

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
