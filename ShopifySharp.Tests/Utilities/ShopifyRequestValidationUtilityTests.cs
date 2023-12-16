#nullable enable
using System;
using System.Collections.Generic;
using FluentAssertions;
using JetBrains.Annotations;
using Microsoft.Extensions.Primitives;
using ShopifySharp.Utilities;
using Xunit;

namespace ShopifySharp.Tests.Utilities;

[TestSubject(typeof(ShopifyRequestValidationUtility))]
[Trait("Category", "ShopifyRequestValidationUtility")]
public class ShopifyRequestValidationUtilityTests
{
    private readonly string _secretKey = Utils.SecretKey;
    private readonly ShopifyRequestValidationUtility _utility = new();

    #region IsAuthenticProxyRequest

    [Fact]
    public void IsAuthenticProxyRequest_WhenGivenADictionary_ReturnsTrue()
    {
        // Setup
        var qs = new Dictionary<string, string>()
        {
            {"shop", "stages-test-shop-2.myshopify.com"},
            {"path_prefix", "/apps/stages-order-tracker"},
            {"timestamp", "1459781841"},
            {"logged_in_customer_id", "123456789"},
            {"signature", "4d67f9147404a4ac61ec5ca82c3fe6015497564d0c6aea7075cf23257c9b2400"},
        };

        // Act
        var isValid = _utility.IsAuthenticProxyRequest(qs, _secretKey);

        // Assert
        isValid.Should().BeTrue();
    }

    [Fact]
    public void IsAuthenticProxyRequest_WhenGivenADictionaryWithInvalidSignature_ReturnsFalse()
    {
        // Setup
        var qs = new Dictionary<string, string>()
        {
            {"shop", "stages-test-shop-2.myshopify.com"},
            {"path_prefix", "/apps/stages-order-tracker"},
            {"timestamp", "1459781841"},
            {"logged_in_customer_id", "123456789"},
            {"signature", "abcdefg"},
        };

        // Act
        var isValid = _utility.IsAuthenticProxyRequest(qs, _secretKey);

        // Assert
        isValid.Should().BeFalse();
    }

    [Fact]
    public void IsAuthenticProxyRequest_WhenGivenDictionaryWithStringValues_ReturnsTrue()
    {
        // Setup
        var qs = new Dictionary<string, StringValues>()
        {
            {"shop", "stages-test-shop-2.myshopify.com"},
            {"path_prefix", "/apps/stages-order-tracker"},
            {"timestamp", "1459781841"},
            {"logged_in_customer_id", string.Empty},
            {"signature", "c79b2e8038b24d9f12dbb6a1308f490a7c81c2d0089fb5f81a13bb4fdef230c9"},
        };

        // Act
        var isValid = _utility.IsAuthenticProxyRequest(qs, _secretKey);

        // Assert
        isValid.Should().BeTrue();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("abcdefg")]
    public void IsAuthenticProxyRequest_WhenGivenDictionaryWithStringValuesAndInvalidSignature_ReturnsFalse(string? signature)
    {
        // Setup
        var qs = new Dictionary<string, StringValues>()
        {
            {"shop", "stages-test-shop-2.myshopify.com"},
            {"path_prefix", "/apps/stages-order-tracker"},
            {"timestamp", "1459781841"},
            {"logged_in_customer_id", string.Empty},
            {"signature", signature},
        };

        // Act
        var isValid = _utility.IsAuthenticProxyRequest(qs, _secretKey);

        // Assert
        isValid.Should().BeFalse();
    }

    [Theory]
    [InlineData("shop=stages-test-shop-2.myshopify.com&path_prefix=/apps/stages-order-tracker&timestamp=1459781841&logged_in_customer_id=123456789&signature=4d67f9147404a4ac61ec5ca82c3fe6015497564d0c6aea7075cf23257c9b2400")]
    [InlineData("shop=stages-test-shop-2.myshopify.com&logged_in_customer_id=&path_prefix=%2Fapps%2Fstages-tracking-widget-1&timestamp=1661887935&signature=4876ab17e7af88772fb3f020925a98fbce10b9276db7637d285155c6c8f64e7c")]
    [InlineData("?shop=stages-test-shop-2.myshopify.com&logged_in_customer_id=&path_prefix=%2Fapps%2Fstages-tracking-widget-1&timestamp=1661887935&signature=4876ab17e7af88772fb3f020925a98fbce10b9276db7637d285155c6c8f64e7c")]
    public void IsAuthenticProxyRequest_WhenGivenAQueryString_ReturnsTrue(string queryString)
    {
        // Act
        var isValid = _utility.IsAuthenticProxyRequest(queryString, _secretKey);

        // Assert
        isValid.Should().BeTrue();
    }

    [Fact]
    public void IsAuthenticProxyRequest_WhenGivenAQueryString_WithInvalidSignature_ReturnsFalse()
    {
        // Setup
        const string qs = "shop=stages-test-shop-2.myshopify.com&path_prefix=/apps/stages-order-tracker&timestamp=1459781841&logged_in_customer_id=123456789&signature=abcdefg";

        // Act
        var isValid = _utility.IsAuthenticProxyRequest(qs, _secretKey);

        // Assert
        isValid.Should().BeFalse();
    }

    #endregion

    #region IsAuthenticRequest

    [Fact]
    public void IsAuthenticRequest_WhenGivenADictionaryWithStringValues_ReturnsTrue()
    {
        // Setup
        var qs = new Dictionary<string, StringValues>()
        {
            {"hmac", "134298b94779fc1be04851ed8f972c827d9a3b4fdf6725fe97369ef422cc5746"},
            {"shop", "stages-test-shop-2.myshopify.com"},
            {"timestamp", "1459779785"},
        };

        // Act
        var isValid = _utility.IsAuthenticRequest(qs, _secretKey);

        // Assert
        isValid.Should().BeTrue();
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("abcdefg")]
    public void IsAuthenticRequest_WhenGivenADictionaryWithStringValuesAndInvalidHmac_ReturnsFalse(string? hmac)
    {
        // Setup
        var qs = new Dictionary<string, StringValues>()
        {
            {"hmac", hmac},
            {"shop", "stages-test-shop-2.myshopify.com"},
            {"timestamp", "1459779785"},
        };

        // Act
        var isValid = _utility.IsAuthenticRequest(qs, _secretKey);

        // Assert
        isValid.Should().BeFalse();
    }

    [Fact]
    public void IsAuthenticRequest_WhenGivenADictionary_ReturnsTrue()
    {
        // Setup
        var qs = new Dictionary<string, string>()
        {
            {"hmac", "134298b94779fc1be04851ed8f972c827d9a3b4fdf6725fe97369ef422cc5746"},
            {"shop", "stages-test-shop-2.myshopify.com"},
            {"timestamp", "1459779785"},
        };

        // Act
        var isValid = _utility.IsAuthenticRequest(qs, _secretKey);

        // Assert
        isValid.Should().BeTrue();
    }

    [Fact]
    public void IsAuthenticRequest_WhenGivenADictionaryWithInvalidHmac_ReturnsFalse()
    {
        // Setup
        var qs = new Dictionary<string, string>()
        {
            {"hmac", "abcdefg"},
            {"shop", "stages-test-shop-2.myshopify.com"},
            {"timestamp", "1459779785"},
        };

        // Act
        var isValid = _utility.IsAuthenticRequest(qs, _secretKey);

        // Assert
        isValid.Should().BeFalse();
    }

    [Theory]
    [InlineData("hmac=134298b94779fc1be04851ed8f972c827d9a3b4fdf6725fe97369ef422cc5746&shop=stages-test-shop-2.myshopify.com&timestamp=1459779785")]
    [InlineData("?hmac=134298b94779fc1be04851ed8f972c827d9a3b4fdf6725fe97369ef422cc5746&shop=stages-test-shop-2.myshopify.com&timestamp=1459779785")]
    public void IsAuthenticRequest_WhenGivenAQueryString_ReturnsTrue(string queryString)
    {
        // Act
        var isValid = _utility.IsAuthenticRequest(queryString, _secretKey);

        // Assert
        isValid.Should().BeTrue();
    }

    [Fact]
    public void IsAuthenticRequest_WhenGivenAQueryStringWithInvalidHmac_ReturnsFalse()
    {
        // Setup
        var queryString = "hmac=abcdefg&shop=stages-test-shop-2.myshopify.com&timestamp=1459779785";

        // Act
        var isValid = _utility.IsAuthenticRequest(queryString, _secretKey);

        // Assert
        isValid.Should().BeFalse();
    }

    [Theory(Skip = "TODO: Generate a real query string with the shop and secret key used by the build server, which contains an ids[] parameter with a single value")]
    [InlineData("ids=1&hmac=...")]
    [InlineData("ids=1,2&hmac=...")]
    [InlineData("ids=1&ids=2&hmac=...")]
    public void Validates_Web_Requests_WithArrayParameter_SingleValue(string queryString)
    {
        // Act
        var isValid = _utility.IsAuthenticRequest(queryString, _secretKey);

        // Assert
        isValid.Should().BeTrue();
    }

    #endregion

    #region IsAuthenticWebhook

    [Fact]
    public void IsAuthenticWebhook_CanValidateHeader()
    {
        // Setup
        const string shopifyHMacHeader = "3X6clrsy+C8mmzR/MeTh6b/EcLr46WLZaU+24GrPXOM=";
        const string secretBytes = "some-secret";
        const string rawBody = "Bf";

        var headers = new[] {
            new KeyValuePair<string, StringValues>("X-Shopify-Hmac-SHA256", new StringValues(shopifyHMacHeader)),
        };

        // Act
        var actual = _utility.IsAuthenticWebhook(headers, rawBody, secretBytes);

        // Assert
        actual.Should().BeTrue();
    }

#if NET6_0_OR_GREATER
    [Fact]
    public void IsAuthenticWebhook_UsingBytes_WhenHeaderIsMissing_ReturnFalse()
    {
        // Setup
        var secretBytes = "some-secret"u8.ToArray();
        var rawBody = "Bf"u8.ToArray();

        var headers = Array.Empty<KeyValuePair<string, StringValues>>();

        // Act
        var actual = _utility.IsAuthenticWebhook(headers, rawBody, secretBytes);

        // Assert
        actual.Should().BeFalse();
    }

    [Fact]
    public void IsAuthenticWebhook_UsingBytes_CanValidateHeader()
    {
        // Setup
        const string shopifyHMacHeader = "3X6clrsy+C8mmzR/MeTh6b/EcLr46WLZaU+24GrPXOM=";
        var secretBytes = "some-secret"u8.ToArray();
        var rawBody = "Bf"u8.ToArray();

        var headers = new[] {
            new KeyValuePair<string, StringValues>("X-Shopify-Hmac-SHA256", new StringValues(shopifyHMacHeader)),
        };

        // Act
        var actual = _utility.IsAuthenticWebhook(headers, rawBody, secretBytes);

        // Assert
        actual.Should().BeTrue();
    }

    [Fact]
    public void IsAuthenticWebhook_UsingBytes_WhenHeaderIsInvalid_ReturnFalse()
    {
        // Setup
        const string shopifyHMacHeader = "3X6clrsy+C8mmzR/MeTh6b/EcLr46WLZaU+24GrPXOM=";
        var secretBytes = "some-secret-2"u8.ToArray();
        var rawBody = "Bf"u8.ToArray();

        var headers = new[] {
            new KeyValuePair<string, StringValues>("X-Shopify-Hmac-SHA256", new StringValues(shopifyHMacHeader)),
        };

        // Act
        var actual = _utility.IsAuthenticWebhook(headers, rawBody, secretBytes);

        // Assert
        actual.Should().BeFalse();
    }
    #endif

    #endregion
}
