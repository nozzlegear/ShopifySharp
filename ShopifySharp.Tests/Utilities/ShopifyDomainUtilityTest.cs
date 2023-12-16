using System;
using System.Threading.Tasks;
using JetBrains.Annotations;
using ShopifySharp.Utilities;
using Xunit;
using FluentAssertions;

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
    [InlineData("example.myshopify.com/admin/api/2023-10/shop.json")]
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
}
