using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalE.Shopify.Service.APIs.ShopifyAPI.Infrastructure.Policies
{
    public class GraphQLResponseCost : ILeakyBucketState
    {
        public bool IsFull => throttleStatus.currentlyAvailable == 0;
        public double requestedQueryCost { get; set; }
        public double? actualQueryCost { get; set; }
        public GraphQLThrottleStatus throttleStatus { get; set; }

        public static GraphQLResponseCost Get<T>(ShopifySharp.RequestResult<T> requestResult)
        {
            try
            {
                if (!string.IsNullOrEmpty(requestResult.RawResult))
                {
                    JToken token = JToken.Parse(requestResult.RawResult);

                    if (token["extensions"] != null && token["extensions"]["cost"] != null)
                    {
                        var costToken = token["extensions"]["cost"];
                        var cost = costToken.ToObject<GraphQLResponseCost>();
                        return cost;
                    }
                }
            }
            catch (Exception ex)
            {
                //_logger.LogError(ex, "Failed to get bucket state from Graph response.");
            }

            return null;
        }
    }

    public class GraphQLThrottleStatus
    {
        public double maximumAvailable { get; set; }
        public double currentlyAvailable { get; set; }
        public double restoreRate { get; set; }
    }
}
