using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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
                {"signature", "239813a42e1164a9f52e85b2119b752774fafb26d0f730359c86572e1791854a"},
            };

            bool isValid = AuthorizationService.IsAuthenticProxyRequest(qs, Utils.SecretKey);

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

        [Fact]
        public async Task Validates_Shop_Urls()
        {
            string validUrl = Utils.MyShopifyUrl;
            string invalidUrl = "https://google.com";

            Assert.True(await AuthorizationService.IsValidMyShopifyUrl(validUrl));
            Assert.False(await AuthorizationService.IsValidMyShopifyUrl(invalidUrl));
        }

        [Fact]
        public void Builds_Authorization_Urls_With_Enums()
        {
            var scopes = new List<AuthorizationScope>()
            {
                AuthorizationScope.ReadCustomers,
                AuthorizationScope.WriteCustomers
            };
            var result = AuthorizationService.BuildAuthorizationUrl(scopes, Utils.MyShopifyUrl, Utils.ApiKey);

            Assert.Contains(result.ToString(), $"/admin/oauth/authorize?client_id={Utils.ApiKey}&scope=read_customers,write_customers");
        }

        [Fact]
        public void Builds_Authorization_Urls_With_Strings()
        {
            string[] scopes = { "read_customers", "write_customers" };
            var result = AuthorizationService.BuildAuthorizationUrl(scopes, Utils.MyShopifyUrl, Utils.ApiKey);

            Assert.Contains(result.ToString(), $"/admin/oauth/authorize?client_id={Utils.ApiKey}&scope=read_customers,write_customers");
        }

        [Fact]
        public void Builds_Authorization_Urls_With_Grants_And_State()
        {
            string[] scopes = { "read_customers", "write_customers" };
            string[] grants = { "per-user" };
            string state = Guid.NewGuid().ToString();
            var result = AuthorizationService.BuildAuthorizationUrl(scopes, Utils.MyShopifyUrl, Utils.ApiKey, null, state, grants);

            Assert.Contains(result.ToString(), $"/admin/oauth/authorize?client_id={Utils.ApiKey}&scope=read_customers,write_customers&state={state}&grant_options[]=per-user");
        }
    }
}