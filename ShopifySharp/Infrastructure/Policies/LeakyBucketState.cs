using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace GlobalE.Shopify.Service.APIs.ShopifyAPI.Infrastructure.Policies
{
    public class LeakyBucketState : ILeakyBucketState
    {
        private const string RESPONSE_HEADER_API_CALL_LIMIT = "X-Shopify-Shop-Api-Call-Limit";

        public int Capacity { get; }

        public int CurrentFillLevel { get; }

        public bool IsFull => CurrentFillLevel == Capacity;

        private LeakyBucketState(int capacity, int currentFillLevel)
        {
            this.Capacity = capacity;
            this.CurrentFillLevel = currentFillLevel;
        }

        public static LeakyBucketState Get<T>(ShopifySharp.RequestResult<T> requestResult)
        {
            var headers = requestResult.Response.Headers.FirstOrDefault(kvp => kvp.Key == RESPONSE_HEADER_API_CALL_LIMIT);
            var apiCallLimitHeaderValue = headers.Value?.FirstOrDefault();

            if (apiCallLimitHeaderValue != null)
            {
                var split = apiCallLimitHeaderValue.Split('/');
                if (split.Length == 2 &&
                    int.TryParse(split[0], out int currentFillLevel) &&
                    int.TryParse(split[1], out int capacity))
                {
                    return new LeakyBucketState(capacity, currentFillLevel);
                }
            }

            return null;
        }
    }
}
