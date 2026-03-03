using System.Net.Http;
using JetBrains.Annotations;
using ShopifySharp.Utilities;
using ShopifySharp.Tests.TestClasses;

namespace ShopifySharp.Tests.Utilities;

[TestSubject(typeof(ShopifyDomainUtility))]
[Trait("Category", "ShopifyDomainUtility")]
public class ShopifyDomainUtilityTest
{
    private readonly ShopifyDomainUtility _utility = new();

    [Theory]
    // ShopifySharp has never disallowed non-myshopify.com domains, despite them causing redirect issues/errors during post/put/delete operations.
    [InlineData("example.com")]
    [InlineData("example.myshopify.com")]
    [InlineData("example.myshopify.com/admin/api/2026-01/shop.json")]
    [InlineData("https://example.com")]
    [InlineData("https://example.myshopify.com")]
    [InlineData("https://example.com/path?query=thing")]
    [InlineData("https://example.myshopify.com#fragment=foo")]
    [InlineData("http://example.com")]
    [InlineData("http://example.myshopify.com")]
    [InlineData("http://example.myshopify.com:80")]
    public void BuildShopDomainUri_ReturnsTheUri(string shopDomain)
    {
        // Act
        var domain = _utility.BuildShopDomainUri(shopDomain);

        // Assert
        domain.Host.Should().NotBeEmpty();
        domain.Port.Should().Be(443);
        domain.Scheme.Should().Be(Uri.UriSchemeHttps);
        domain.PathAndQuery.Should().Be("/");
        domain.Fragment.Should().BeEmpty();
    }

    [Fact]
    public async Task IsValidShopDomainAsync_ReturnsTrueForShopifyDomains()
    {
        // Act
        var isValid = await _utility.IsValidShopDomainAsync("example.myshopify.com");

        // Assert
        isValid.Should().BeTrue();
    }

    [Theory]
    [InlineData("foo")]
    [InlineData("example.com")]
    public async Task IsValidShopDomainAsync_ReturnsFalseForNonShopifyDomains(string shopDomain)
    {
        // Act
        var isValid = await _utility.IsValidShopDomainAsync(shopDomain);

        // Assert
        isValid.Should().BeFalse();
    }

    [Theory]
    [InlineData("shopify-web-runtime", "web")]
    [InlineData("x-shopify-login-required", "true")]
    [InlineData("SHOPIFY-WEB-RUNTIME", "web")]
    [InlineData("X-SHOPIFY-LOGIN-REQUIRED", "true")]
    [InlineData("Shopify-Web-Runtime", "web")]
    [InlineData("X-Shopify-Login-Required", "true")]
    [InlineData("powered-by", "shopify")]
    [InlineData("Powered-By", "Shopify")]
    [InlineData("POWERED-BY", "SHOPIFY")]
    public async Task IsValidShopDomainAsync_ReturnsTrueForDomainWithoutXShopIdHeader(string headerKey, string headerValue)
    {
        // Setup
        var handler = A.Fake<HttpMessageHandler>(x => x.Strict());
        var serviceProvider = A.Fake<IServiceProvider>(x => x.Strict());
        var httpClient = new FakeHttpClient(handler);
        var httpClientFactory = new FakeHttpClientFactory(httpClient);

        A.CallTo(() => serviceProvider.GetService(typeof(IHttpClientFactory)))
            .Returns(httpClientFactory);
        A.CallTo(handler)
            .Where(call => call.Method.Name == "SendAsync")
            .WithReturnType<Task<HttpResponseMessage>>()
            .ReturnsLazily(() => Utils.MakeHttpResponseMessage("{}", msg =>
            {
                msg.Headers.Add(headerKey, headerValue);
            }));

        var sut = new ShopifyDomainUtility(serviceProvider);

        // Act
        var isValid = await sut.IsValidShopDomainAsync("example.myshopify.com");

        // Assert
        isValid.Should().BeTrue();
    }

    [Theory]
    [InlineData("shopify", true)]
    [InlineData("Shopify", true)]
    [InlineData("SHOPIFY", true)]
    [InlineData("caddy", false)]
    [InlineData("nginx", false)]
    [InlineData("express", false)]
    [InlineData("gearworks", false)]
    public async Task IsValidShopDomainAsync_ShouldCheckThePoweredByHeaderValue(string headerValue, bool shouldPass)
    {
        // Setup
        var handler = A.Fake<HttpMessageHandler>(x => x.Strict());
        var serviceProvider = A.Fake<IServiceProvider>(x => x.Strict());
        var httpClient = new FakeHttpClient(handler);
        var httpClientFactory = new FakeHttpClientFactory(httpClient);

        A.CallTo(() => serviceProvider.GetService(typeof(IHttpClientFactory)))
            .Returns(httpClientFactory);
        A.CallTo(handler)
            .Where(call => call.Method.Name == "SendAsync")
            .WithReturnType<Task<HttpResponseMessage>>()
            .ReturnsLazily(() => Utils.MakeHttpResponseMessage("{}", msg =>
            {
                msg.Headers.Add("powered-by", headerValue);
            }));

        var sut = new ShopifyDomainUtility(serviceProvider);

        // Act
        var isValid = await sut.IsValidShopDomainAsync("example.myshopify.com");

        // Assert
        isValid.Should().Be(shouldPass, "the header value {0} is {1}", headerValue, shouldPass ? "valid" : "not valid");
    }
}
