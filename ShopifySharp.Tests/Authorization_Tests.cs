using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Primitives;
using ShopifySharp.Enums;
using Xunit;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Authorization")]
    public class Authorization_Tests
    {
        [Fact]
        public void Validates_Proxy_Requests()
        {
            //Configure querystring
            var qs = new Dictionary<string, StringValues>()
            {
                {"shop", "stages-test-shop-2.myshopify.com"},
                {"path_prefix", "/apps/stages-order-tracker"},
                {"timestamp", "1459781841"},
                {"logged_in_customer_id", string.Empty},
                {"signature", "c79b2e8038b24d9f12dbb6a1308f490a7c81c2d0089fb5f81a13bb4fdef230c9"},
            };

            var isValid = AuthorizationService.IsAuthenticProxyRequest(qs, Utils.SecretKey);

            Assert.True(isValid);
        }

        [Fact]
        public void Validates_Proxy_Requests_With_Dictionary_QueryString()
        {
            //Configure querystring
            var qs = new Dictionary<string, string>()
            {
                {"shop", "stages-test-shop-2.myshopify.com"},
                {"path_prefix", "/apps/stages-order-tracker"},
                {"timestamp", "1459781841"},
                {"logged_in_customer_id", "123456789"},
                {"signature", "4d67f9147404a4ac61ec5ca82c3fe6015497564d0c6aea7075cf23257c9b2400"},
            };

            var isValid = AuthorizationService.IsAuthenticProxyRequest(qs, Utils.SecretKey);

            Assert.True(isValid);
        }

        [Fact]
        public void Validates_Proxy_Requests_With_Raw_QueryString()
        {
            //Configure querystring
            var qs = "shop=stages-test-shop-2.myshopify.com&path_prefix=/apps/stages-order-tracker&timestamp=1459781841&logged_in_customer_id=123456789&signature=4d67f9147404a4ac61ec5ca82c3fe6015497564d0c6aea7075cf23257c9b2400";

            var isValid = AuthorizationService.IsAuthenticProxyRequest(qs, Utils.SecretKey);

            Assert.True(isValid);
        }

        [Fact]
        public void Validates_Proxy_Requests_With_Raw_QueryString_And_Null_Customer_Id()
        {
            var qs = "shop=stages-test-shop-2.myshopify.com&logged_in_customer_id=&path_prefix=%2Fapps%2Fstages-tracking-widget-1&timestamp=1661887935&signature=4876ab17e7af88772fb3f020925a98fbce10b9276db7637d285155c6c8f64e7c";
            var isValid = AuthorizationService.IsAuthenticProxyRequest(qs, Utils.SecretKey);

            Assert.True(isValid);
        }

        [Fact]
        public void Validates_Proxy_Requests_With_Raw_QueryString_Beginning_With_Question_Mark()
        {
            var qs = "?shop=stages-test-shop-2.myshopify.com&logged_in_customer_id=&path_prefix=%2Fapps%2Fstages-tracking-widget-1&timestamp=1661887935&signature=4876ab17e7af88772fb3f020925a98fbce10b9276db7637d285155c6c8f64e7c";
            var isValid = AuthorizationService.IsAuthenticProxyRequest(qs, Utils.SecretKey);

            Assert.True(isValid);
        }

        [Fact]
        public void Validates_Web_Requests()
        {
            var qs = new Dictionary<string, StringValues>()
            {
                {"hmac", "134298b94779fc1be04851ed8f972c827d9a3b4fdf6725fe97369ef422cc5746"},
                {"shop", "stages-test-shop-2.myshopify.com"},
                {"signature", "f477a85f3ed6027735589159f9da74da"},
                {"timestamp", "1459779785"},
            };

            bool isValid = AuthorizationService.IsAuthenticRequest(qs, Utils.SecretKey);

            Assert.True(isValid);
        }

        [Fact(Skip = "TODO: Generate a real query string with the shop and secret key used by the build server, which contains an ids[] parameter")]
        public void Validates_Web_Requests_WithArrayParameter()
        {
            string query = "hmac=...";
            var qs = QueryHelpers.ParseQuery(query);
            bool isValid = AuthorizationService.IsAuthenticRequest(qs, Utils.SecretKey);
            Assert.True(isValid);
        }

        [Fact(Skip = "TODO: Generate a real query string with the shop and secret key used by the build server, which contains an ids[] parameter with a single value")]
        public void Validates_Web_Requests_WithArrayParameter_SingleValue()
        {
            string query = "hmac=...";
            var qs = QueryHelpers.ParseQuery(query);
            bool isValid = AuthorizationService.IsAuthenticRequest(qs, Utils.SecretKey);
            Assert.True(isValid);
        }

        [Fact]
        public void Validates_Web_Requests_With_Dictionary_Querystring()
        {
            // Note that this method differes from Validates_Web_Requests() in that the aforementioned's dictionary is Dictionary<string, stringvalues> and this is Dictionary<string, string>.
            var qs = new Dictionary<string, string>()
            {
                {"hmac", "134298b94779fc1be04851ed8f972c827d9a3b4fdf6725fe97369ef422cc5746"},
                {"shop", "stages-test-shop-2.myshopify.com"},
                {"signature", "f477a85f3ed6027735589159f9da74da"},
                {"timestamp", "1459779785"},
            };

            bool isValid = AuthorizationService.IsAuthenticRequest(qs, Utils.SecretKey);

            Assert.True(isValid);
        }

        [Fact]
        public void Validates_Web_Requests_With_Raw_Querystring()
        {
            var qs = "hmac=134298b94779fc1be04851ed8f972c827d9a3b4fdf6725fe97369ef422cc5746&shop=stages-test-shop-2.myshopify.com&signature=f477a85f3ed6027735589159f9da74da&timestamp=1459779785";

            bool isValid = AuthorizationService.IsAuthenticRequest(qs, Utils.SecretKey);
        }

        [Fact]
        public async Task Validates_Shop_Urls()
        {
            string validUrl = Utils.MyShopifyUrl;
            string invalidUrl = "https://google.com";

            Assert.True(await AuthorizationService.IsValidShopDomainAsync(validUrl));
            Assert.False(await AuthorizationService.IsValidShopDomainAsync(invalidUrl));
        }

        [Fact]
        public async Task Validates_Shop_Malfunctioned_Urls()
        {
            string invalidUrl = "foo";

            Assert.False(await AuthorizationService.IsValidShopDomainAsync(invalidUrl));
        }

        [Fact]
        public void Builds_Authorization_Urls_With_Enums()
        {
            var scopes = new List<AuthorizationScope>()
            {
                AuthorizationScope.ReadCustomers,
                AuthorizationScope.WriteCustomers
            };
            string redirectUrl = "http://example.com";
            string result = AuthorizationService.BuildAuthorizationUrl(scopes, Utils.MyShopifyUrl, Utils.ApiKey, redirectUrl).ToString();

            Assert.Contains($"/admin/oauth/authorize?", result);
            Assert.Contains($"client_id={Utils.ApiKey}", result);
            Assert.Contains($"scope=read_customers,write_customers", result);
            Assert.Contains($"redirect_uri={redirectUrl}", result);
        }

        [Fact]
        public void Builds_Authorization_Urls_With_Strings()
        {
            string[] scopes = { "read_customers", "write_customers" };
            string redirectUrl = "http://example.com";
            string result = AuthorizationService.BuildAuthorizationUrl(scopes, Utils.MyShopifyUrl, Utils.ApiKey, redirectUrl).ToString();

            Assert.Contains($"/admin/oauth/authorize?", result);
            Assert.Contains($"client_id={Utils.ApiKey}", result);
            Assert.Contains($"scope=read_customers,write_customers", result);
            Assert.Contains($"redirect_uri={redirectUrl}", result);
        }

        [Fact]
        public void Builds_Authorization_Urls_With_Grants_And_State()
        {
            string[] scopes = { "read_customers", "write_customers" };
            string redirectUrl = "http://example.com";
            string[] grants = { "per-user" };
            string state = Guid.NewGuid().ToString();
            string result = AuthorizationService.BuildAuthorizationUrl(scopes, Utils.MyShopifyUrl, Utils.ApiKey, redirectUrl, state, grants).ToString();

            Assert.Contains($"/admin/oauth/authorize?", result);
            Assert.Contains($"client_id={Utils.ApiKey}", result);
            Assert.Contains($"scope=read_customers,write_customers", result);
            Assert.Contains($"redirect_uri={redirectUrl}", result);
            Assert.Contains($"state={state}", result);
            Assert.Contains($"grant_options[]=per-user", result);
        }
    }
}
