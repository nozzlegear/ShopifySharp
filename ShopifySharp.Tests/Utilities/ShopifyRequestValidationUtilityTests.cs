#nullable enable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
    private readonly string _secretKey = "some-secret-key";
    private readonly ShopifyRequestValidationUtility _utility = new();

    private static string ComputeShopifyRequestHmac(IDictionary<string, string> queryParams, string secretKey)
    {
        // Per Shopify docs: remove hmac/signature, sort keys, join as "key=value&key=value", HMAC-SHA256 -> lowercase hex
        var filtered = queryParams
            .Where(kvp => kvp.Key != "hmac" && kvp.Key != "signature")
            .OrderBy(kvp => kvp.Key, StringComparer.Ordinal)
            .Select(kvp => $"{kvp.Key}={kvp.Value}");

        var message = string.Join("&", filtered);
        var keyBytes = Encoding.UTF8.GetBytes(secretKey);
        var messageBytes = Encoding.UTF8.GetBytes(message);
        using (var hmac = new HMACSHA256(keyBytes))
        {
            var hash = hmac.ComputeHash(messageBytes);
            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }
    }

    private static string ComputeShopifyProxySignature(IDictionary<string, string> queryParams, string secretKey)
    {
        // Per Shopify proxy docs: remove signature/hmac, sort keys, concat as "key=valuekey=value" (no separator), HMAC-SHA256 -> lowercase hex
        var filtered = queryParams
            .Where(kvp => kvp.Key != "signature" && kvp.Key != "hmac")
            .OrderBy(kvp => kvp.Key, StringComparer.Ordinal)
            .Select(kvp => $"{kvp.Key}={kvp.Value}");

        var message = string.Concat(filtered);
        var keyBytes = Encoding.UTF8.GetBytes(secretKey);
        var messageBytes = Encoding.UTF8.GetBytes(message);
        using (var hmac = new HMACSHA256(keyBytes))
        {
            var hash = hmac.ComputeHash(messageBytes);
            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }
    }

    private static string ComputeShopifyWebhookHmac(string requestBody, string secretKey)
    {
        // Per Shopify docs: HMAC-SHA256 of raw request body with client secret -> base64
        var keyBytes = Encoding.UTF8.GetBytes(secretKey);
        var bodyBytes = Encoding.UTF8.GetBytes(requestBody);
        using (var hmac = new HMACSHA256(keyBytes))
        {
            var hash = hmac.ComputeHash(bodyBytes);
            return Convert.ToBase64String(hash);
        }
    }

    #region IsAuthenticProxyRequest

    [Fact]
    public void IsAuthenticProxyRequest_WhenGivenADictionary_ReturnsTrue()
    {
        // Setup
        var expectedSig = ComputeShopifyProxySignature(new Dictionary<string, string>
        {
            {"shop", "stages-test-shop-2.myshopify.com"},
            {"path_prefix", "/apps/stages-order-tracker"},
            {"timestamp", "1459781841"},
            {"logged_in_customer_id", "123456789"},
        }, _secretKey);

        var qs = new Dictionary<string, string>()
        {
            {"shop", "stages-test-shop-2.myshopify.com"},
            {"path_prefix", "/apps/stages-order-tracker"},
            {"timestamp", "1459781841"},
            {"logged_in_customer_id", "123456789"},
            {"signature", expectedSig},
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
        var expectedSig = ComputeShopifyProxySignature(new Dictionary<string, string>
        {
            {"shop", "stages-test-shop-2.myshopify.com"},
            {"path_prefix", "/apps/stages-order-tracker"},
            {"timestamp", "1459781841"},
            {"logged_in_customer_id", ""},
        }, _secretKey);

        var qs = new Dictionary<string, StringValues>()
        {
            {"shop", "stages-test-shop-2.myshopify.com"},
            {"path_prefix", "/apps/stages-order-tracker"},
            {"timestamp", "1459781841"},
            {"logged_in_customer_id", string.Empty},
            {"signature", expectedSig},
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

    [Fact]
    public void IsAuthenticProxyRequest_WhenGivenAQueryString_ReturnsTrue()
    {
        var expectedSig = ComputeShopifyProxySignature(new Dictionary<string, string>
        {
            {"shop", "stages-test-shop-2.myshopify.com"},
            {"path_prefix", "/apps/stages-order-tracker"},
            {"timestamp", "1459781841"},
            {"logged_in_customer_id", "123456789"},
        }, _secretKey);
        var queryString = $"shop=stages-test-shop-2.myshopify.com&path_prefix=/apps/stages-order-tracker&timestamp=1459781841&logged_in_customer_id=123456789&signature={expectedSig}";

        // Act
        var isValid = _utility.IsAuthenticProxyRequest(queryString, _secretKey);

        // Assert
        isValid.Should().BeTrue();
    }

    [Fact]
    public void IsAuthenticProxyRequest_WhenGivenAQueryString_WithUrlEncodedPath_ReturnsTrue()
    {
        var expectedSig = ComputeShopifyProxySignature(new Dictionary<string, string>
        {
            {"shop", "stages-test-shop-2.myshopify.com"},
            {"logged_in_customer_id", ""},
            {"path_prefix", "/apps/stages-tracking-widget-1"},
            {"timestamp", "1661887935"},
        }, _secretKey);
        var queryString = $"shop=stages-test-shop-2.myshopify.com&logged_in_customer_id=&path_prefix=%2Fapps%2Fstages-tracking-widget-1&timestamp=1661887935&signature={expectedSig}";

        // Act
        var isValid = _utility.IsAuthenticProxyRequest(queryString, _secretKey);

        // Assert
        isValid.Should().BeTrue();
    }

    [Fact]
    public void IsAuthenticProxyRequest_WhenGivenAQueryString_WithLeadingQuestionMark_ReturnsTrue()
    {
        var expectedSig = ComputeShopifyProxySignature(new Dictionary<string, string>
        {
            {"shop", "stages-test-shop-2.myshopify.com"},
            {"logged_in_customer_id", ""},
            {"path_prefix", "/apps/stages-tracking-widget-1"},
            {"timestamp", "1661887935"},
        }, _secretKey);
        var queryString = $"?shop=stages-test-shop-2.myshopify.com&logged_in_customer_id=&path_prefix=%2Fapps%2Fstages-tracking-widget-1&timestamp=1661887935&signature={expectedSig}";

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
        var expectedHmac = ComputeShopifyRequestHmac(new Dictionary<string, string>
        {
            {"shop", "stages-test-shop-2.myshopify.com"},
            {"timestamp", "1459779785"},
        }, _secretKey);

        var qs = new Dictionary<string, StringValues>()
        {
            {"hmac", expectedHmac},
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
        var expectedHmac = ComputeShopifyRequestHmac(new Dictionary<string, string>
        {
            {"shop", "stages-test-shop-2.myshopify.com"},
            {"timestamp", "1459779785"},
        }, _secretKey);

        var qs = new Dictionary<string, string>()
        {
            {"hmac", expectedHmac},
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

    [Fact]
    public void IsAuthenticRequest_WhenGivenAQueryString_ReturnsTrue()
    {
        var expectedHmac = ComputeShopifyRequestHmac(new Dictionary<string, string>
        {
            {"shop", "stages-test-shop-2.myshopify.com"},
            {"timestamp", "1459779785"},
        }, _secretKey);
        var queryString = $"hmac={expectedHmac}&shop=stages-test-shop-2.myshopify.com&timestamp=1459779785";

        // Act
        var isValid = _utility.IsAuthenticRequest(queryString, _secretKey);

        // Assert
        isValid.Should().BeTrue();
    }

    [Fact]
    public void IsAuthenticRequest_WhenGivenAQueryString_WithLeadingQuestionMark_ReturnsTrue()
    {
        var expectedHmac = ComputeShopifyRequestHmac(new Dictionary<string, string>
        {
            {"shop", "stages-test-shop-2.myshopify.com"},
            {"timestamp", "1459779785"},
        }, _secretKey);
        var queryString = $"?hmac={expectedHmac}&shop=stages-test-shop-2.myshopify.com&timestamp=1459779785";

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
        var shopifyHMacHeader = ComputeShopifyWebhookHmac("Bf", "some-secret");
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
        var shopifyHMacHeader = ComputeShopifyWebhookHmac("Bf", "some-secret");
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
        const string shopifyHMacHeader = "some-invalid-header";
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
