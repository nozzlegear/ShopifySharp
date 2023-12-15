using System;
#if NET6_0_OR_GREATER
using System.Buffers;
#endif
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.Primitives;
using System.Net.Http.Headers;
using ShopifySharp.Enums;
using ShopifySharp.Utilities;

namespace ShopifySharp
{
    [Obsolete("The static AuthorizationService is obsolete and will be removed in a future version of ShopifySharp. Please use the ShopifyOauthUtility, ShopifyRequestValidationUtility or ShopifyDomainUtility classes instead.")]
    public static class AuthorizationService
    {
        private static readonly IShopifyDomainUtility ShopifyDomainUtility = new ShopifyDomainUtility();
        private static readonly IShopifyOauthUtility ShopifyOauthUtility = new ShopifyOauthUtility(ShopifyDomainUtility);
        private static readonly IShopifyRequestValidationUtility ShopifyRequestValidationUtility = new ShopifyRequestValidationUtility();

        public static bool IsAuthenticRequest(IEnumerable<KeyValuePair<string, StringValues>> querystring, string shopifySecretKey) =>
            ShopifyRequestValidationUtility.IsAuthenticRequest(querystring, shopifySecretKey);

        /// <summary>
        /// Determines if an incoming request is authentic.
        /// </summary>
        /// <param name="querystring">A dictionary containing the keys and values from the request's querystring.</param>
        /// <param name="shopifySecretKey">Your app's secret key.</param>
        /// <returns>A boolean indicating whether the request is authentic or not.</returns>
        public static bool IsAuthenticRequest(IDictionary<string, string> querystring, string shopifySecretKey) =>
            ShopifyRequestValidationUtility.IsAuthenticRequest(querystring, shopifySecretKey);

        /// <summary>
        /// Determines if an incoming request is authentic.
        /// </summary>
        /// <param name="querystring">The request's raw querystring.</param>
        /// <param name="shopifySecretKey">Your app's secret key.</param>
        /// <returns>A boolean indicating whether the request is authentic or not.</returns>
        public static bool IsAuthenticRequest(string querystring, string shopifySecretKey) =>
            ShopifyRequestValidationUtility.IsAuthenticRequest(querystring, shopifySecretKey);

        /// <summary>
        /// Determines if an incoming proxy page request is authentic.
        /// </summary>
        /// <param name="querystring">The collection of querystring parameters from the request. Hint: use Request.QueryString if you're calling this from an ASP.NET MVC controller.</param>
        /// <param name="shopifySecretKey">Your app's secret key.</param>
        /// <returns>A boolean indicating whether the request is authentic or not.</returns>
        public static bool IsAuthenticProxyRequest(IEnumerable<KeyValuePair<string, StringValues>> querystring, string shopifySecretKey) =>
            ShopifyRequestValidationUtility.IsAuthenticProxyRequest(querystring, shopifySecretKey);

        /// <summary>
        /// Determines if an incoming proxy page request is authentic.
        /// </summary>
        /// <param name="querystring">A dictionary containing the keys and values from the request's querystring.</param>
        /// <param name="shopifySecretKey">Your app's secret key.</param>
        /// <returns>A boolean indicating whether the request is authentic or not.</returns>
        public static bool IsAuthenticProxyRequest(IDictionary<string, string> querystring, string shopifySecretKey) =>
            ShopifyRequestValidationUtility.IsAuthenticProxyRequest(querystring, shopifySecretKey);

        /// <summary>
        /// Determines if an incoming proxy page request is authentic.
        /// </summary>
        /// <param name="querystring">The request's raw querystring.</param>
        /// <param name="shopifySecretKey">Your app's secret key.</param>
        /// <returns>A boolean indicating whether the request is authentic or not.</returns>
        public static bool IsAuthenticProxyRequest(string querystring, string shopifySecretKey) =>
            ShopifyRequestValidationUtility.IsAuthenticProxyRequest(querystring, shopifySecretKey);

        /// <summary>
        /// Determines if an incoming webhook request is authentic.
        /// </summary>
        /// <param name="requestHeaders">The request's headers. Hint: use Request.Headers if you're calling this from an ASP.NET MVC controller.</param>
        /// <param name="inputStream">The request's input stream. This method does NOT dispose the stream.
        /// Hint: use Request.InputStream if you're calling this from an ASP.NET MVC controller.</param>
        /// <param name="shopifySecretKey">Your app's secret key.</param>
        /// <returns>A boolean indicating whether the webhook is authentic or not.</returns>
        public static Task<bool> IsAuthenticWebhook(IEnumerable<KeyValuePair<string, StringValues>> requestHeaders, Stream inputStream, string shopifySecretKey) =>
            ShopifyRequestValidationUtility.IsAuthenticWebhookAsync(requestHeaders, inputStream, shopifySecretKey);

        /// <summary>
        /// Determines if an incoming webhook request is authentic.
        /// </summary>
        /// <param name="requestHeaders">The request's headers. Hint: use Request.Headers if you're calling this from an ASP.NET MVC controller.</param>
        /// <param name="requestBody">The body of the request.</param>
        /// <param name="shopifySecretKey">Your app's secret key.</param>
        /// <returns>A boolean indicating whether the webhook is authentic or not.</returns>
        public static bool IsAuthenticWebhook(IEnumerable<KeyValuePair<string, StringValues>> requestHeaders, string requestBody, string shopifySecretKey) =>
            ShopifyRequestValidationUtility.IsAuthenticWebhook(requestHeaders, requestBody, shopifySecretKey);

#if NET6_0_OR_GREATER
        public static bool IsAuthenticWebhook(
            IEnumerable<KeyValuePair<string, StringValues>> requestHeaders,
            ReadOnlyMemory<byte> requestBody,
            ReadOnlyMemory<byte> shopifySecretKey
        ) => ShopifyRequestValidationUtility.IsAuthenticWebhook(requestHeaders, requestBody, shopifySecretKey);
#endif

        /// <summary>
        /// Determines if an incoming webhook request is authentic.
        /// </summary>
        /// <param name="requestHeaders">The request's headers.</param>
        /// <param name="requestBody">The body of the request.</param>
        /// <param name="shopifySecretKey">Your app's secret key.</param>
        /// <returns>A boolean indicating whether the webhook is authentic or not.</returns>
        public static bool IsAuthenticWebhook(HttpRequestHeaders requestHeaders, string requestBody, string shopifySecretKey) =>
            ShopifyRequestValidationUtility.IsAuthenticWebhook(requestHeaders, requestBody, shopifySecretKey);

        /// <summary>
        /// A convenience function that tries to ensure that a given URL is a valid Shopify domain. It does this by making a HEAD request to the given domain, and returns true if the response contains an X-ShopId header.
        ///
        /// **Warning**: a domain could fake the response header, which would cause this method to return true.
        ///
        /// **Warning**: this method of validation is not officially supported by Shopify and could break at any time.
        /// </summary>
        /// <param name="shopDomain">The URL of the shop to check.</param>
        /// <returns>A boolean indicating whether the URL is valid.</returns>
        public static Task<bool> IsValidShopDomainAsync(string shopDomain) =>
            ShopifyDomainUtility.IsValidShopDomainAsync(shopDomain);

        /// <summary>
        /// Builds an authorization URL for Shopify OAuth integration.
        /// </summary>
        /// <param name="scopes">An array of <see cref="AuthorizationScope"/> — the permissions that your app needs to run.</param>
        /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
        /// <param name="clientId">Your app's public Client ID, also known as its public API key.</param>
        /// <param name="redirectUrl">URL to redirect the user to after integration.</param>
        /// <param name="state">An optional, random string value provided by your application which is unique for each authorization request. During the OAuth callback phase, your application should check that this value matches the one you provided to this method.</param>
        /// <param name="grants">Requested grant types, which will change the type of access token granted upon OAuth completion.</param>
        public static Uri BuildAuthorizationUrl(
            IEnumerable<AuthorizationScope> scopes,
            string shopDomain,
            string clientId,
            string redirectUrl,
            string state = null,
            IEnumerable<string> grants = null
        ) => ShopifyOauthUtility.BuildAuthorizationUrl(scopes, shopDomain, clientId, redirectUrl, state, grants);

        /// <summary>
        /// Builds an authorization URL for Shopify OAuth integration.
        /// </summary>
        /// <param name="scopes">An array of Shopify permission strings, e.g. 'read_orders' or 'write_script_tags'. These are the permissions that your app needs to run.</param>
        /// <param name="shopDomain">The shop's *.myshopify.com URL.</param>
        /// <param name="clientId">Your app's public Client ID, also known as its public API key.</param>
        /// <param name="redirectUrl">URL to redirect the user to after integration.</param>
        /// <param name="state">An optional, random string value provided by your application which is unique for each authorization request. During the OAuth callback phase, your application should check that this value matches the one you provided to this method.</param>
        /// <param name="grants">Requested grant types, which will change the type of access token granted upon OAuth completion.</param>
        public static Uri BuildAuthorizationUrl(
            IEnumerable<string> scopes,
            string shopDomain,
            string clientId,
            string redirectUrl,
            string state = null,
            IEnumerable<string> grants = null
        ) => ShopifyOauthUtility.BuildAuthorizationUrl(scopes, shopDomain, clientId, redirectUrl, state, grants);

        /// <summary>
        /// Authorizes an application installation, generating an access token for the given shop.
        /// </summary>
        /// <param name="code">The authorization code generated by Shopify, which should be a parameter named 'code' on the request querystring.</param>
        /// <param name="myShopifyUrl">The store's *.myshopify.com URL, which should be a parameter named 'shop' on the request querystring.</param>
        /// <param name="shopifyApiKey">Your app's secret API key.</param>
        /// <param name="shopifySecretKey">Your app's secret key.</param>
        /// <returns>The shop access token.</returns>
        public static async Task<string> Authorize(string code, string myShopifyUrl, string shopifyApiKey, string shopifySecretKey)
        {
            var result = await ShopifyOauthUtility.AuthorizeAsync(code, myShopifyUrl, shopifyApiKey, shopifySecretKey);
            return result.AccessToken;
        }

        /// <summary>
        /// Authorizes an application installation, generating an access token for the given shop.
        /// </summary>
        /// <param name="code">The authorization code generated by Shopify, which should be a parameter named 'code' on the request querystring.</param>
        /// <param name="myShopifyUrl">The store's *.myshopify.com URL, which should be a parameter named 'shop' on the request querystring.</param>
        /// <param name="shopifyApiKey">Your app's public API key.</param>
        /// <param name="shopifySecretKey">Your app's secret key.</param>
        /// <returns>The authorization result.</returns>
        public static Task<AuthorizationResult> AuthorizeWithResult(string code, string myShopifyUrl, string shopifyApiKey, string shopifySecretKey) =>
            ShopifyOauthUtility.AuthorizeAsync(code, myShopifyUrl, shopifyApiKey, shopifySecretKey);

        /// <summary>
        /// Refreshes an existing store access token using the app's client secret and a refresh token
        /// For more info on rotating tokens, see https://shopify.dev/apps/auth/oauth/rotate-revoke-client-credentials
        /// </summary>
        /// <param name="myShopifyUrl">The store's *.myshopify.com url</param>
        /// <param name="clientId">The app's client ID, also known as API key</param>
        /// <param name="clientSecret">The app's secret key</param>
        /// <param name="refreshToken">The app's refresh token</param>
        /// <param name="existingStoreAccessToken">The existing store access token</param>
        /// <returns></returns>
        public static Task<AuthorizationResult> RefreshAccessToken(string myShopifyUrl, string clientId, string clientSecret, string refreshToken, string existingStoreAccessToken) =>
            ShopifyOauthUtility.RefreshAccessToken(myShopifyUrl, clientId, clientSecret, refreshToken, existingStoreAccessToken);
    }
}
