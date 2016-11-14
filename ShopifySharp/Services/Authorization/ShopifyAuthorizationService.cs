using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using RestSharp;
using Newtonsoft.Json.Linq;
using ShopifySharp.Enums;

namespace ShopifySharp
{
    public static class ShopifyAuthorizationService
    {
        #region Public, static methods

        /// <summary>
        /// Determines if an incoming request is authentic.
        /// </summary>
        /// <param name="querystring">The collection of querystring parameters from the request. Hint: use Request.QueryString if you're calling this from an ASP.NET MVC controller.</param>
        /// <param name="shopifySecretKey">Your app's secret key.</param>
        /// <returns>A boolean indicating whether the request is authentic or not.</returns>
        public static bool IsAuthenticRequest(NameValueCollection querystring, string shopifySecretKey)
        {
            string hmac = querystring.Get("hmac");

            if (string.IsNullOrEmpty(hmac))
            {
                return false;
            }

            // To calculate HMAC signature:
            // 1. Cast querystring to KVP pairs.
            // 2. Remove `signature` and `hmac` keys.
            // 3. Replace & with %26, % with %25 in keys and values.
            // 4. Replace = with %3D in keys only.
            // 5. Join each key and value with = (key=value).
            // 6. Sorty kvps alphabetically.
            // 7. Join kvps together with & (key=value&key=value&key=value).
            // 8. Compute the kvps with an HMAC-SHA256 using the secret key.
            // 9. Request is authentic if the computed string equals the `hash` in query string.
            // Reference: https://docs.shopify.com/api/guides/authentication/oauth#making-authenticated-requests

            Func<string, bool, string> replaceChars = (string s, bool isKey) =>
            {
                //Important: Replace % before replacing &. Else second replace will replace those %25s.
                string output = (s?.Replace("%", "%25").Replace("&", "%26")) ?? "";

                if (isKey)
                {
                    output = output.Replace("=", "%3D");
                }

                return output;
            };

            var kvps = querystring.Cast<string>()
                .Select(s => new { Key = replaceChars(s, true), Value = replaceChars(querystring[s], false) })
                .Where(kvp => kvp.Key != "signature" && kvp.Key != "hmac")
                .OrderBy(kvp => kvp.Key)
                .Select(kvp => $"{kvp.Key}={kvp.Value}");

            var hmacHasher = new HMACSHA256(Encoding.UTF8.GetBytes(shopifySecretKey));
            var hash = hmacHasher.ComputeHash(Encoding.UTF8.GetBytes(string.Join("&", kvps)));

            //Convert bytes back to string, replacing dashes, to get the final signature.
            var calculatedSignature = BitConverter.ToString(hash).Replace("-", "");

            //Request is valid if the calculated signature matches the signature from the querystring.
            return calculatedSignature.ToUpper() == hmac.ToUpper();
        }

        /// <summary>
        /// Determines if an incoming proxy page request is authentic. Conceptually similar to <see cref="IsAuthenticRequest(NameValueCollection, string)"/>,
        /// except that proxy requests use HMACSHA256 rather than MD5.
        /// </summary>
        /// <param name="querystring">The collection of querystring parameters from the request. Hint: use Request.QueryString if you're calling this from an ASP.NET MVC controller.</param>
        /// <param name="shopifySecretKey">Your app's secret key.</param>
        /// <returns>A boolean indicating whether the request is authentic or not.</returns>
        public static bool IsAuthenticProxyRequest(NameValueCollection querystring, string shopifySecretKey)
        {
            string signature = querystring.Get("signature");

            if (string.IsNullOrEmpty(signature))
            {
                return false;
            }

            // To calculate signature, order all querystring parameters by alphabetical (exclude the 
            // signature itself). Then, hash it with the secret key.

            Func<string, bool, string> replaceChars = (string s, bool isKey) =>
            {
                //Important: Replace % before replacing &. Else second replace will replace those %25s.
                string output = (s?.Replace("%", "%25").Replace("&", "%26")) ?? "";

                if (isKey)
                {
                    output = output.Replace("=", "%3D");
                }

                return output;
            };

            var kvps = querystring.Cast<string>()
                .Select(s => new { Key = replaceChars(s, true), Value = replaceChars(querystring[s], false) })
                .Where(kvp => kvp.Key != "signature" && kvp.Key != "hmac")
                .OrderBy(kvp => kvp.Key)
                .Select(kvp => $"{kvp.Key}={kvp.Value}");

            var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(shopifySecretKey));
            var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(string.Join(null, kvps)));

            //Convert bytes back to string, replacing dashes, to get the final signature.
            var calculatedSignature = BitConverter.ToString(hash).Replace("-", "");

            //Request is valid if the calculated signature matches the signature from the querystring.
            return calculatedSignature.ToUpper() == signature.ToUpper();
        }

        /// <summary>
        /// Determines if an incoming webhook request is authentic.
        /// </summary>
        /// <param name="requestHeaders">The request's headers. Hint: use Request.Headers if you're calling this from an ASP.NET MVC controller.</param>
        /// <param name="inputStream">The request's input stream. This method does NOT dispose the stream. 
        /// Hint: use Request.InputStream if you're calling this from an ASP.NET MVC controller.</param>
        /// <param name="shopifySecretKey">Your app's secret key.</param>
        /// <returns>A boolean indicating whether the webhook is authentic or not.</returns>
        public static async Task<bool> IsAuthenticWebhook(NameValueCollection requestHeaders, Stream inputStream, string shopifySecretKey)
        {
            //Input stream may have already been read when a controller determines parameters to 
            //pass to an action. Reset position to 0.
            inputStream.Position = 0;

            //We do not dispose the StreamReader because disposing it will also dispose the input stream,
            //and disposing a request's input stream can cause major headaches for the developer.
            string requestBody = await new StreamReader(inputStream).ReadToEndAsync();

            return IsAuthenticWebhook(requestHeaders, requestBody, shopifySecretKey);
        }

        /// <summary>
        /// Determines if an incoming webhook request is authentic.
        /// </summary>
        /// <param name="requestHeaders">The request's headers. Hint: use Request.Headers if you're calling this from an ASP.NET MVC controller.</param>
        /// <param name="requestBody">The body of the request.</param>
        /// <param name="shopifySecretKey">Your app's secret key.</param>
        /// <returns>A boolean indicating whether the webhook is authentic or not.</returns>
        public static bool IsAuthenticWebhook(NameValueCollection requestHeaders, string requestBody, string shopifySecretKey)
        {
            string hmacHeader = requestHeaders.Get("X-Shopify-Hmac-SHA256");

            if (string.IsNullOrEmpty(hmacHeader))
            {
                return false;
            }

            //Compute a hash from the apiKey and the request body
            HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(shopifySecretKey));
            string hash = Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(requestBody)));

            //Webhook is valid if computed hash matches the header hash
            return hash == hmacHeader; 
        }

        /// <summary>
        /// A convenience function that tries to ensure that a given URL is a valid Shopify store by checking the response headers for X-ShopId.
        /// </summary>
        /// <param name="url">The URL of the shop to check.</param>
        /// <returns>A boolean indicating whether the URL is valid.</returns>
        public static async Task<bool> IsValidMyShopifyUrl(string url)
        {
            Uri uri = RequestEngine.BuildShopUri(url);
            RestClient client = RequestEngine.CreateClient(uri);

            //Make request
            RestRequest request = new RestRequest("", Method.GET);
            IRestResponse response = await client.ExecuteTaskAsync(request);

            //Valid Shopify stores will have an X-ShopId header
            return response.Headers.Any(h => h.Name == "X-ShopId");
        }

        /// <summary>
        /// Builds an authorization URL for Shopify OAuth integration.
        /// </summary>
        /// <param name="scopes">An array of <see cref="ShopifyAuthorizationScope"/> — the permissions that your app needs to run.</param>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopifyApiKey">Your app's public API key.</param>
        /// <param name="redirectUrl">An optional URL to redirect the user to after integration. Overrides the Shopify app's default redirect URL.</param>
        /// <param name="state">An optional, random string value provided by your application which is unique for each authorization request. During the OAuth callback phase, your application should check that this value matches the one you provided to this method.</param>
        /// <param name="grants">Requested grant types, which will change the type of access token granted upon OAuth completion. Only known grant type is "per-user", which will give an access token restricted to the permissions of the user accepting OAuth integration and will expire when that user logs out. Leave the grants array empty or null to receive a full access token that doesn't expire.</param>
        /// <returns>The authorization url.</returns>
        public static Uri BuildAuthorizationUrl(IEnumerable<ShopifyAuthorizationScope> scopes, string myShopifyUrl, string shopifyApiKey, string redirectUrl = null, string state = null, IEnumerable<string> grants = null)
        {
            return BuildAuthorizationUrl(scopes.Select(s => s.ToSerializedString()), myShopifyUrl, shopifyApiKey, redirectUrl, state, grants);
        }

        /// <summary>
        /// Builds an authorization URL for Shopify OAuth integration.
        /// </summary>
        /// <param name="scopes">An array of Shopify permission strings, e.g. 'read_orders' or 'write_script_tags'. These are the permissions that your app needs to run.</param>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopifyApiKey">Your app's public API key.</param>
        /// <param name="redirectUrl">An optional URL to redirect the user to after integration. Overrides the Shopify app's default redirect URL.</param>
        /// <param name="state">An optional, random string value provided by your application which is unique for each authorization request. During the OAuth callback phase, your application should check that this value matches the one you provided to this method.</param>
        /// <param name="grants">Requested grant types, which will change the type of access token granted upon OAuth completion. Only known grant type is "per-user", which will give an access token restricted to the permissions of the user accepting OAuth integration and will expire when that user logs out. Leave the grants array empty or null to receive a full access token that doesn't expire.</param>
        /// <returns>The authorization url.</returns>
        public static Uri BuildAuthorizationUrl(IEnumerable<string> scopes, string myShopifyUrl, string shopifyApiKey, string redirectUrl = null, string state = null, IEnumerable<string> grants = null)
        {
            //Prepare a uri builder for the shop URL
            var builder = new UriBuilder(RequestEngine.BuildShopUri(myShopifyUrl));

            //Build the querystring
            var qs = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("client_id", shopifyApiKey),
                new KeyValuePair<string, string>("scope", string.Join(",", scopes)),
            };

            if (string.IsNullOrEmpty(redirectUrl) == false)
            {
                qs.Add(new KeyValuePair<string, string>("redirect_uri", redirectUrl));
            }

            if (string.IsNullOrEmpty(state) == false)
            {
                qs.Add(new KeyValuePair<string, string>("state", state));
            }

            if (grants != null && grants.Count() > 0)
            {
                foreach (var grant in grants)
                {
                    qs.Add(new KeyValuePair<string, string>("grant_options[]", grant));
                }
            }

            builder.Path = "admin/oauth/authorize";
            builder.Query = string.Join("&", qs.Select(s => $"{s.Key}={s.Value}"));

            return builder.Uri;
        }

        /// <summary>
        /// Authorizes an application installation, generating an access token for the given shop.
        /// </summary>
        /// <param name="code">The authorization code generated by Shopify, which should be a parameter named 'code' on the request querystring.</param>
        /// <param name="myShopifyUrl">The store's *.myshopify.com URL, which should be a paramter named 'shop' on the request querystring.</param>
        /// <param name="shopifyApiKey">Your app's public API key.</param>
        /// <param name="shopifySecretKey">Your app's secret key.</param>
        /// <returns>The shop access token.</returns>
        public static async Task<string> Authorize(string code, string myShopifyUrl, string shopifyApiKey, string shopifySecretKey)
        {
            Uri shopUri = RequestEngine.BuildShopUri(myShopifyUrl);
            RestClient client = RequestEngine.CreateClient(shopUri);
            IRestRequest req = RequestEngine.CreateRequest("oauth/access_token", Method.POST);
            JToken response;

            //Build request body
            req.AddJsonBody(new { client_id = shopifyApiKey, client_secret = shopifySecretKey, code });

            response = await RequestEngine.ExecuteRequestAsync(client, req);

            return response.Value<string>("access_token");
        }

        #endregion
    }
}
