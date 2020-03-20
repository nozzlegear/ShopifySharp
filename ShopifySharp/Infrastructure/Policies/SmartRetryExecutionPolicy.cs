using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Text;
using Newtonsoft.Json.Linq;
using GlobalE.Shopify.Service.APIs.Models;
using ShopifySharp;
using GlobalE.Shopify.Service.APIs.ShopifyAPI.Infrastructure.Policies;

namespace Globale.Shopify.Service.APIs.ShopifyAPI.Infrastructure.Policies
{
    /// <summary>
    /// A retry policy that attemps to pro-actively limit the number of requests that will result in a ShopifyRateLimitException
    /// by implementing the leaky bucket algorithm.
    /// For example: if 100 requests are created in parallel, only 40 should be immediately sent, and the subsequent 60 requests
    /// should be throttled at 1 per 500ms.
    /// </summary>
    /// <remarks>
    /// In comparison, the naive retry policy will issue the 100 requests immediately:
    /// 60 requests will fail and be retried after 500ms,
    /// 59 requests will fail and be retried after 500ms,
    /// 58 requests will fail and be retried after 500ms.
    /// See https://help.shopify.com/api/guides/api-call-limit
    /// https://en.wikipedia.org/wiki/Leaky_bucket
    /// </remarks>
    public partial class SmartRetryExecutionPolicy : IRequestExecutionPolicy
    {
        private const string REQUEST_HEADER_ACCESS_TOKEN = "X-Shopify-Access-Token";

        private static readonly TimeSpan THROTTLE_DELAY = TimeSpan.FromMilliseconds(500);

        private static ConcurrentDictionary<string, LeakyBucket> _shopAccessTokenToLeakyBucket = new ConcurrentDictionary<string, LeakyBucket>();
        private static ConcurrentDictionary<string, GraphLeakyBucket> _shopAccessTokenToGraphLeakyBucket = new ConcurrentDictionary<string, GraphLeakyBucket>();

        private readonly bool _retryOnlyIfLeakyBucketFull;

        public SmartRetryExecutionPolicy(bool retryOnlyIfLeakyBucketFull = true)
        {
            _retryOnlyIfLeakyBucketFull = retryOnlyIfLeakyBucketFull;
        }

        public static Dictionary<string, Tuple<LeakyBucketStateModel, LeakyBucketStateModel>> GetLeakyBucketStates() {
            var keys = _shopAccessTokenToLeakyBucket.Keys.ToList();
            keys.AddRange(_shopAccessTokenToGraphLeakyBucket.Keys.ToList());

            var dict = new Dictionary<string, Tuple<LeakyBucketStateModel, LeakyBucketStateModel>>();
            foreach (string key in keys)
            {
                LeakyBucketStateModel state1 = null, state2 = null;
                if (_shopAccessTokenToLeakyBucket.ContainsKey(key))
                    state1 = _shopAccessTokenToLeakyBucket[key].GetState();

                if (_shopAccessTokenToGraphLeakyBucket.ContainsKey(key))
                    state2 = _shopAccessTokenToGraphLeakyBucket[key].GetState();

                dict[key] = new Tuple<LeakyBucketStateModel, LeakyBucketStateModel>(state1, state2);
            }

            return dict;
        }

        ILogger _logger;
        public SmartRetryExecutionPolicy(ILogger logger) {
            _logger = logger;
        }

        public async Task<ShopifySharp.RequestResult<T>> Run<T>(ShopifySharp.Infrastructure.CloneableRequestMessage baseRequest, ExecuteRequestAsync<T> executeRequestAsync)
        {
            var accessToken = GetAccessToken(baseRequest);
            var isGraphRequest = IsGraphRequest(baseRequest);
            ILeakyBucket bucket = null;

            if (accessToken != null)
            {
                bucket = isGraphRequest 
                    ? (ILeakyBucket)_shopAccessTokenToGraphLeakyBucket.GetOrAdd(accessToken, _ => new GraphLeakyBucket(_logger))
                    : (ILeakyBucket)_shopAccessTokenToLeakyBucket.GetOrAdd(accessToken, _ => new LeakyBucket());
            }

            while (true)
            {
                var request = baseRequest.Clone();

                int expectedQueryCost = 0;
                if (accessToken != null)
                {
                    expectedQueryCost = await bucket.GrantAsync(request);
                }

                try
                {
                    var fullResult = await executeRequestAsync(request);
                    bucket?.UpdateState(fullResult, expectedQueryCost);
                    return fullResult;
                }
                catch (ShopifyRateLimitException ex) when (ex.Reason == ShopifyRateLimitReason.BucketFull || !_retryOnlyIfLeakyBucketFull)
                {
                    //Only retry if breach caused by full bucket
                    //Other limits will bubble the exception because it's not clear how long the program should wait
                    //Even if there is a Retry-After header, we probably don't want the thread to sleep for potentially many hours
                    //
                    //An exception may still occur:
                    //-Shopify may have a slightly different algorithm
                    //-Shopify may change to a different algorithm in the future
                    //-There may be timing and latency delays
                    //-Multiple programs may use the same access token
                    //-Multiple instances of the same program may use the same access token
                    _logger.LogWarning(ex, "Shopify API call rate limit reached. Task delayed. {RequestUri}", request.RequestUri);
                    await Task.Delay(THROTTLE_DELAY);
                }
            }
        }

        private bool IsGraphRequest(ShopifySharp.Infrastructure.CloneableRequestMessage baseRequest)
        {
            return baseRequest.RequestUri.ToString().EndsWith("/graphql.json");
        }

        private string GetAccessToken(HttpRequestMessage client)
        {
            return client.Headers.TryGetValues(REQUEST_HEADER_ACCESS_TOKEN, out var values) ?
                values.FirstOrDefault() :
                null;
        }
    }
}
