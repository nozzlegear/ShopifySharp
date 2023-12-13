using Newtonsoft.Json.Linq;

namespace ShopifySharp
{
    public class GraphQLBucketState
    {
        public int MaxAvailable { get; private set; }

        public int RestoreRate { get; private set; }

        public int CurrentlyAvailable { get; private set; }

        public int RequestedQueryCost { get; private set; }

        public int? ActualQueryCost { get; private set; }

        public static GraphQLBucketState Get(JToken response)
        {
            var cost = response.SelectToken("extensions.cost");
            if (cost == null)
                return null;

            var throttleStatus = cost["throttleStatus"];
            int maximumAvailable = (int)throttleStatus["maximumAvailable"];
            int restoreRate = (int)throttleStatus["restoreRate"];
            int currentlyAvailable = (int)throttleStatus["currentlyAvailable"];
            int requestedQueryCost = (int)cost["requestedQueryCost"];
            int? actualQueryCost = (int?)cost["actualQueryCost"];//actual query cost is null if THROTTLED

            return new GraphQLBucketState
            {
                MaxAvailable = maximumAvailable,
                RestoreRate = restoreRate,
                CurrentlyAvailable = currentlyAvailable,    
                RequestedQueryCost = requestedQueryCost,
                ActualQueryCost = actualQueryCost,
            };
        }
    }
}
