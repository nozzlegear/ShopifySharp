using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using Humanizer;
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
            string signature = querystring.Get("signature");

            //Convert the querystring to a dictionary, which lets us query it with LINQ
            IDictionary<string, string> parameters = querystring
                .Cast<string>()
                .Select(s => new { Key = s, Value = querystring[s] })
                .ToDictionary(d => d.Key, d => d.Value);

            //To calculate signature, order all querystring parameters by alphabetical (exclude the signature itself), and append it to the secret key.
            string calculatedSignature = shopifySecretKey + string.Join(null, parameters
                .Where(x => x.Key != "signature")
                .OrderBy(x => x.Key)
                .Select(x => string.Format("{0}={1}", x.Key, x.Value)));

            //Convert calculated signature to bytes
            Byte[] sigBytes = Encoding.UTF8.GetBytes(calculatedSignature);

            //Runt hose bytes through an MD5 hash
            using (MD5 md5 = MD5.Create())
            {
                sigBytes = md5.ComputeHash(sigBytes);
            }

            //Convert bytes back to string, replacing dashes, to get the final signature.
            calculatedSignature = BitConverter.ToString(sigBytes).Replace("-", "");

            //Request is valid if the calculated signature matches the signature from the querystring.
            return calculatedSignature.ToUpper() == signature.ToUpper();
        }

        /// <summary>
        /// Determines if an incoming webhook request is authentic.
        /// </summary>
        /// <param name="requestHeaders">The request's headers. Hint: use Request.Headers if you're calling this from an ASP.NET MVC controller.</param>
        /// <param name="inputStream">The request's input stream. Hint: use Request.InputStream if you're calling this from an ASP.NET MVC controller.</param>
        /// <param name="shopifySecretKey">Your app's secret key.</param>
        /// <returns>A boolean indicating whether the webhook is authentic or not.</returns>
        public static async Task<bool> IsAuthenticWebhook(NameValueCollection requestHeaders, Stream inputStream, string shopifySecretKey)
        {
            //Input stream may have already been read when a controller determines parameters to 
            //pass to an action. Reset position to 0.
            inputStream.Position = 0;

            //We do not dispose the input stream ourselves, as it can cause major headaches if we 
            //close a controller's request stream.
            using (StreamReader reader = new StreamReader(inputStream))
            {
                string requestBody = await reader.ReadToEndAsync();

                return IsAuthenticWebhook(requestHeaders, requestBody, shopifySecretKey);
            }
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
            else
            {
                //Compute a hash from the apiKey and the request body
                HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(shopifySecretKey));
                string hash = Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(requestBody)));

                //Webhook is valid if computed hash matches the header hash
                return hash == hmacHeader;
            }
        }

        /// <summary>
        /// Builds an authorization URL for Shopify OAuth integration.
        /// </summary>
        /// <param name="scopes">An array of <see cref="ShopifyAuthorizationScope"/> — the permissions that your app needs to run.</param>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopifyApiKey">Your app's public API key.</param>
        /// <param name="redirectUrl">An optional URL to redirect the user to after integration. Overrides the Shopify app's default redirect URL.</param>
        /// <returns>The authorization url.</returns>
        public static Uri BuildAuthorizationUrl(IEnumerable<ShopifyAuthorizationScope> scopes, string myShopifyUrl, string shopifyApiKey, string redirectUrl = null)
        {
            //Prepare a uri builder for the shop URL
            UriBuilder builder = new UriBuilder(RequestEngine.BuildShopUri(myShopifyUrl));

            //Build the querystring
            List<KeyValuePair<string, string>> qs = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("client_id", shopifyApiKey),
                new KeyValuePair<string, string>("scope", string.Join(",", scopes.Select(s => s.Humanize()))),
            };

            if (string.IsNullOrEmpty(redirectUrl) == false)
            {
                qs.Add(new KeyValuePair<string, string>("redirect_uri", redirectUrl));
            }

            builder.Path = "admin/oauth/authorize";
            builder.Query = string.Join("&", qs.Select(s => "{0}={1}".FormatWith(s.Key, s.Value)));

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
