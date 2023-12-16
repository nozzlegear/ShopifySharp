using System;
#if NET6_0_OR_GREATER
using System.Buffers;
#endif
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Extensions.Primitives;

namespace ShopifySharp.Utilities;

public interface IShopifyRequestValidationUtility
{
    /// <summary>
    /// Determines if an incoming request is authentic.
    /// </summary>
    /// <param name="querystring">The collection of querystring parameters from the request. Hint: use Request.QueryString if you're calling this from an ASP.NET MVC controller.</param>
    /// <param name="shopifySecretKey">Your app's secret key.</param>
    /// <returns>A boolean indicating whether the request is authentic or not.</returns>
    bool IsAuthenticRequest(IEnumerable<KeyValuePair<string, StringValues>> querystring, string shopifySecretKey);

    /// <summary>
    /// Determines if an incoming request is authentic.
    /// </summary>
    /// <param name="querystring">A dictionary containing the keys and values from the request's querystring.</param>
    /// <param name="shopifySecretKey">Your app's secret key.</param>
    /// <returns>A boolean indicating whether the request is authentic or not.</returns>
    bool IsAuthenticRequest(IDictionary<string, string> querystring, string shopifySecretKey);

    /// <summary>
    /// Determines if an incoming request is authentic.
    /// </summary>
    /// <param name="querystring">The request's raw querystring.</param>
    /// <param name="shopifySecretKey">Your app's secret key.</param>
    /// <returns>A boolean indicating whether the request is authentic or not.</returns>
    bool IsAuthenticRequest(string querystring, string shopifySecretKey);

    /// <summary>
    /// Determines if an incoming proxy page request is authentic. Conceptually similar to <see cref="IsAuthenticRequest(NameValueCollection, string)"/>,
    /// except that proxy requests use HMACSHA256 rather than MD5.
    /// </summary>
    /// <param name="querystring">The collection of querystring parameters from the request. Hint: use Request.QueryString if you're calling this from an ASP.NET MVC controller.</param>
    /// <param name="shopifySecretKey">Your app's secret key.</param>
    /// <returns>A boolean indicating whether the request is authentic or not.</returns>
    bool IsAuthenticProxyRequest(IEnumerable<KeyValuePair<string, StringValues>> querystring, string shopifySecretKey);

    /// <summary>
    /// Determines if an incoming proxy page request is authentic. Conceptually similar to <see cref="AuthorizationService.IsAuthenticRequest(string,string)"/>,
    /// except that proxy requests use HMACSHA256 rather than MD5.
    /// </summary>
    /// <param name="querystring">A dictionary containing the keys and values from the request's querystring.</param>
    /// <param name="shopifySecretKey">Your app's secret key.</param>
    /// <returns>A boolean indicating whether the request is authentic or not.</returns>
    bool IsAuthenticProxyRequest(IDictionary<string, string> querystring, string shopifySecretKey);

    /// <summary>
    /// Determines if an incoming proxy page request is authentic. Conceptually similar to <see cref="IsAuthenticRequest(NameValueCollection, string)"/>,
    /// except that proxy requests use HMACSHA256 rather than MD5.
    /// </summary>
    /// <param name="querystring">The request's raw querystring.</param>
    /// <param name="shopifySecretKey">Your app's secret key.</param>
    /// <returns>A boolean indicating whether the request is authentic or not.</returns>
    bool IsAuthenticProxyRequest(string querystring, string shopifySecretKey);

    /// <summary>
    /// Determines if an incoming webhook request is authentic.
    /// </summary>
    /// <param name="requestHeaders">The request's headers. Hint: use Request.Headers if you're calling this from an ASP.NET MVC controller.</param>
    /// <param name="inputStream">The request's input stream. This method does NOT dispose the stream.
    /// Hint: use Request.InputStream if you're calling this from an ASP.NET MVC controller.</param>
    /// <param name="shopifySecretKey">Your app's secret key.</param>
    /// <returns>A boolean indicating whether the webhook is authentic or not.</returns>
    Task<bool> IsAuthenticWebhookAsync(IEnumerable<KeyValuePair<string, StringValues>> requestHeaders, Stream inputStream, string shopifySecretKey);

    /// <summary>
    /// Determines if an incoming webhook request is authentic.
    /// </summary>
    /// <param name="requestHeaders">The request's headers. Hint: use Request.Headers if you're calling this from an ASP.NET MVC controller.</param>
    /// <param name="requestBody">The body of the request.</param>
    /// <param name="shopifySecretKey">Your app's secret key.</param>
    /// <returns>A boolean indicating whether the webhook is authentic or not.</returns>
    bool IsAuthenticWebhook(IEnumerable<KeyValuePair<string, StringValues>> requestHeaders, string requestBody, string shopifySecretKey);

    /// <summary>
    /// Determines if an incoming webhook request is authentic.
    /// </summary>
    /// <param name="requestHeaders">The request's headers.</param>
    /// <param name="requestBody">The body of the request.</param>
    /// <param name="shopifySecretKey">Your app's secret key.</param>
    /// <returns>A boolean indicating whether the webhook is authentic or not.</returns>
    bool IsAuthenticWebhook(HttpRequestHeaders requestHeaders, string requestBody, string shopifySecretKey);

    #if NET6_0_OR_GREATER
    bool IsAuthenticWebhook(
        IEnumerable<KeyValuePair<string, StringValues>> requestHeaders,
        ReadOnlyMemory<byte> requestBody,
        ReadOnlyMemory<byte> shopifySecretKey
    );
    #endif
}

public class ShopifyRequestValidationUtility : IShopifyRequestValidationUtility
{
    /// <inheritdoc />
    public bool IsAuthenticRequest(IEnumerable<KeyValuePair<string, StringValues>> querystring, string shopifySecretKey)
    {
        // To calculate HMAC signature:
        // 1. Cast querystring to KVP pairs.
        // 2. Remove `signature` and `hmac` keys.
        // 3. Replace & with %26, % with %25 in keys and values.
        // 4. Replace = with %3D in keys only.
        // 5. Join each key and value with = (key=value).
        // 6. Sort kvps alphabetically.
        // 7. Join kvps together with & (key=value&key=value&key=value).
        // 8. Compute the kvps with an HMAC-SHA256 using the secret key.
        // 9. Request is authentic if the computed string equals the `hash` in query string.
        // Reference: https://docs.shopify.com/api/guides/authentication/oauth#making-authenticated-requests
        var hmacValues = querystring.FirstOrDefault(kvp => kvp.Key == "hmac").Value;

        if (string.IsNullOrEmpty(hmacValues) || hmacValues.Count() < 1)
        {
            return false;
        }

        string hmac = hmacValues.First();
        string kvps = PrepareQuerystring(querystring, "&");
        var hmacHasher = new HMACSHA256(Encoding.UTF8.GetBytes(shopifySecretKey));
        var hash = hmacHasher.ComputeHash(Encoding.UTF8.GetBytes(string.Join("&", kvps)));

        //Convert bytes back to string, replacing dashes, to get the final signature.
        var calculatedSignature = BitConverter.ToString(hash).Replace("-", "");

        //Request is valid if the calculated signature matches the signature from the querystring.
        return calculatedSignature.ToUpper() == hmac.ToUpper();
    }

    /// <inheritdoc />
    public bool IsAuthenticRequest(IDictionary<string, string> querystring, string shopifySecretKey)
    {
        var qs = querystring.Select(kvp => new KeyValuePair<string, StringValues>(kvp.Key, kvp.Value));

        return IsAuthenticRequest(qs, shopifySecretKey);
    }

    /// <inheritdoc />
    public bool IsAuthenticRequest(string querystring, string shopifySecretKey)
    {
        return IsAuthenticRequest(ParseRawQuerystring(querystring), shopifySecretKey);
    }

    /// <inheritdoc />
    public bool IsAuthenticProxyRequest(IEnumerable<KeyValuePair<string, StringValues>> querystring, string shopifySecretKey)
    {
        // To calculate signature, order all querystring parameters by alphabetical (exclude the
        // signature itself). Then, hash it with the secret key.
        var signatureValues = querystring.FirstOrDefault(kvp => kvp.Key == "signature").Value;

        if (string.IsNullOrEmpty(signatureValues) || signatureValues.Count() < 1)
        {
            return false;
        }

        string signature = signatureValues.First();
        string kvps = PrepareQuerystring(querystring, string.Empty);
        var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(shopifySecretKey));
        var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(string.Join(null, kvps)));

        //Convert bytes back to string, replacing dashes, to get the final signature.
        var calculatedSignature = BitConverter.ToString(hash).Replace("-", "");

        //Request is valid if the calculated signature matches the signature from the querystring.
        return calculatedSignature.ToUpper() == signature.ToUpper();
    }

    /// <inheritdoc />
    public bool IsAuthenticProxyRequest(IDictionary<string, string> querystring, string shopifySecretKey)
    {
        var qs = querystring.Select(kvp => new KeyValuePair<string, StringValues>(kvp.Key, kvp.Value));

        return IsAuthenticProxyRequest(qs, shopifySecretKey);
    }

    /// <inheritdoc />
    public bool IsAuthenticProxyRequest(string querystring, string shopifySecretKey)
    {
        return IsAuthenticProxyRequest(ParseRawQuerystring(querystring), shopifySecretKey);
    }

    /// <inheritdoc />
    public async Task<bool> IsAuthenticWebhookAsync(IEnumerable<KeyValuePair<string, StringValues>> requestHeaders, Stream inputStream, string shopifySecretKey)
    {
        //Input stream may have already been read when a controller determines parameters to
        //pass to an action. Reset position to 0.
        inputStream.Position = 0;

        //We do not dispose the StreamReader because disposing it will also dispose the input stream,
        //and disposing a request's input stream can cause major headaches for the developer.
        string requestBody = await new StreamReader(inputStream).ReadToEndAsync();

        return IsAuthenticWebhook(requestHeaders, requestBody, shopifySecretKey);
    }

    /// <inheritdoc />
    public bool IsAuthenticWebhook(IEnumerable<KeyValuePair<string, StringValues>> requestHeaders, string requestBody, string shopifySecretKey)
    {
        var hmacHeaderValues = requestHeaders.FirstOrDefault(kvp => kvp.Key.Equals("X-Shopify-Hmac-SHA256", StringComparison.OrdinalIgnoreCase)).Value;

        if (string.IsNullOrEmpty(hmacHeaderValues) || hmacHeaderValues.Count() < 1)
        {
            return false;
        }

        //Compute a hash from the apiKey and the request body
        string hmacHeader = hmacHeaderValues.First();
        HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(shopifySecretKey));
        string hash = Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(requestBody)));

        //Webhook is valid if computed hash matches the header hash
        return hash == hmacHeader;
    }

    /// <inheritdoc />
    public bool IsAuthenticWebhook(HttpRequestHeaders requestHeaders, string requestBody, string shopifySecretKey)
    {
        var hmacHeaderValue = requestHeaders.FirstOrDefault(kvp => kvp.Key.Equals("X-Shopify-Hmac-SHA256", StringComparison.OrdinalIgnoreCase)).Value.FirstOrDefault();

        if (string.IsNullOrEmpty(hmacHeaderValue))
        {
            return false;
        }

        //Compute a hash from the apiKey and the request body
        string hmacHeader = hmacHeaderValue;
        HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(shopifySecretKey));
        string hash = Convert.ToBase64String(hmac.ComputeHash(Encoding.UTF8.GetBytes(requestBody)));

        //Webhook is valid if computed hash matches the header hash
        return hash == hmacHeader;
    }

    #if NET6_0_OR_GREATER
    /// <inheritdoc />
    public bool IsAuthenticWebhook(IEnumerable<KeyValuePair<string, StringValues>> requestHeaders, ReadOnlyMemory<byte> requestBody, ReadOnlyMemory<byte> shopifySecretKey)
    {
        var hmacHeaderValue = requestHeaders.FirstOrDefault(kvp => kvp.Key.Equals("X-Shopify-Hmac-SHA256", StringComparison.OrdinalIgnoreCase)).Value.FirstOrDefault();
        if (string.IsNullOrEmpty(hmacHeaderValue))
        {
            return false;
        }

        var hmacHeaderBytes = ArrayPool<byte>.Shared.Rent(32);
        var hmacBytes = ArrayPool<byte>.Shared.Rent(32);
        try
        {
            //Compute a hash from the apiKey and the request body
            if (!HMACSHA256.TryHashData(shopifySecretKey.Span, requestBody.Span, hmacBytes, out var bytesWritten))
            {
                return false;
            }

            if (bytesWritten != 32)
            {
                return false;
            }

            var hmacBytesSpan = new ReadOnlyMemory<byte>(hmacBytes, 0, bytesWritten);
            if (!Convert.TryFromBase64String(hmacHeaderValue, hmacHeaderBytes, out var headerBytesWrittern))
            {
                return false;
            }

            if (headerBytesWrittern != 32)
            {
                return false;
            }

            //Webhook is valid if computed hash matches the header hash
            return hmacBytesSpan.Span.SequenceEqual(new Span<byte>(hmacHeaderBytes, 0, headerBytesWrittern));
        }
        finally
        {
            ArrayPool<byte>.Shared.Return(hmacBytes);
            ArrayPool<byte>.Shared.Return(hmacHeaderBytes);
        }
    }
    #endif

    private static string PrepareQuerystring(IEnumerable<KeyValuePair<string, StringValues>> querystring, string joinWith)
    {
        var kvps = querystring.Select(kvp => new
        {
            Key = EncodeQuery(kvp.Key, kvp.Value, true),
            Value = EncodeQuery(kvp.Key, kvp.Value, false)
        })
            .Where(kvp => kvp.Key != "signature" && kvp.Key != "hmac")
            .OrderBy(kvp => kvp.Key, StringComparer.Ordinal)
            .Select(kvp => $"{kvp.Key}={kvp.Value}");

        return string.Join(joinWith, kvps);
    }

    private static string EncodeQuery(string key, StringValues values, bool isKey)
    {
        string result = null;

        if (isKey)
        {
            result = key;
        }
        else
        {
            //array parameters are handled differently: see https://community.shopify.com/c/Shopify-APIs-SDKs/HMAC-calculation-vs-ids-arrays/td-p/261154
            //https://github.com/nozzlegear/ShopifySharp/pull/437
            //https://github.com/nozzlegear/ShopifySharp/issues/530
            result = values.Count <= 1 && !key.EndsWith("[]") ?
                        values.FirstOrDefault() :
                        '[' + string.Join(", ", values.Select(v => '"' + v + '"')) + ']';
        }

        if (string.IsNullOrEmpty(result))
            return "";

        //Important: Replace % before replacing &. Else second replace will replace those %25s.
        result = (result.Replace("%", "%25").Replace("&", "%26")) ?? "";

        if (isKey)
        {
            result = result.Replace("=", "%3D").Replace("[]", "");
        }

        return result;
    }

    private static IDictionary<string, string> ParseRawQuerystring(string qs)
    {
        var parsed = HttpUtility.ParseQueryString(qs);
        return parsed.AllKeys.ToDictionary(k => k, k => parsed[k]);
    }
}
