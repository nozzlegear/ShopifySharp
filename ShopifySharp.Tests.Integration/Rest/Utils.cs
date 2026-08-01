using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using FakeItEasy;
using ShopifySharp.Credentials;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Policies.ExponentialRetry;

namespace ShopifySharp.Tests.Integration.Rest;

/// <summary>
/// A utility class for running tests.
/// </summary>
public static class Utils
{
    /// <summary>
    /// Attempts to get an environment variable first by the key, then from configuration.
    /// All keys must be uppercased!
    /// </summary>
    private static string Get(string key) => ConfigurationHelper.Get(key);

    public static string ApiKey => Get("API_KEY");

    public static string SecretKey => Get("SECRET_KEY");

    public static string AccessToken => Get("ACCESS_TOKEN");

    public static string MultipassSecret => Get("MULTIPASS_SECRET");

    public static string MyShopifyUrl => Get("MY_SHOPIFY_URL");

    public static ShopifyApiCredentials Credentials => new(MyShopifyUrl, AccessToken);

    public static long OrganizationId => long.Parse(Get("ORG_ID"));

    public static string OrganizationToken => Get("ORG_TOKEN");

    public static ShopifyPartnerApiCredentials PartnerCredentials  => new(OrganizationId, OrganizationToken);

    #nullable enable

    /// <summary>
    /// Creates a list of faked execution policies which can be further configured using FakeItEasy.
    /// </summary>
    /// <example>
    /// <code lang="cs">
    /// A.CallTo(policy)
    ///     .WithReturnType&lt;Task&lt;RequestResult&lt;string&gt;&gt;&gt;()
    ///     .Returns(response);
    /// </code>
    /// </example>
    /// <returns></returns>
    public static IRequestExecutionPolicy[] MakeFakedExecutionPoliciesList()
    {
        return
        [
            A.Fake<IRequestExecutionPolicy>(x => x.Wrapping(new DefaultRequestExecutionPolicy())),
            A.Fake<IRequestExecutionPolicy>(x => x.Wrapping(new RetryExecutionPolicy())),
            A.Fake<IRequestExecutionPolicy>(x => x.Wrapping(new LeakyBucketExecutionPolicy())),
            A.Fake<IRequestExecutionPolicy>(x => x.Wrapping(new ExponentialRetryPolicy(ExponentialRetryPolicyOptions.Default())))
        ];
    }

    public static HttpResponseMessage MakeHttpResponseMessage(string responseJson, Action<HttpResponseMessage>? customize = null)
    {
        var response = new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = new StringContent(responseJson, Encoding.UTF8, "application/json")
        };
        customize?.Invoke(response);
        return response;
    }

    public static RequestResult<string> MakeRequestResult(string responseJson, Action<TestUtilsRequestResult>? customize = null)
    {
        var response = new HttpResponseMessage(HttpStatusCode.OK);
        var result = new TestUtilsRequestResult(
            "some-request-info",
            response.Headers,
            responseJson,
            responseJson,
            "some-raw-link-header-value",
            HttpStatusCode.OK
        );
        customize?.Invoke(result);
        return result;
    }

    public class TestUtilsRequestResult : RequestResult<string>
    {
        private const string HeaderName = "X-Request-Id";

        public string? RequestId
        {
            set
            {
                if (ResponseHeaders.Contains(HeaderName))
                    ResponseHeaders.Remove(HeaderName);
                if (value is not null)
                    ResponseHeaders.Add(HeaderName, value);
            }
        }

        public TestUtilsRequestResult(string requestInfo,
            HttpResponseHeaders httpResponseHeaders,
            string result,
            string rawResult,
            string rawLinkHeaderValue,
            HttpStatusCode statusCode) : base(requestInfo, httpResponseHeaders, result, rawResult, rawLinkHeaderValue, statusCode)
        {
            RequestId = "some-request-id";
        }
    }

    // ReSharper disable once InconsistentNaming
    public static TimeSpan ms(this int v) => TimeSpan.FromMilliseconds(v);
}
