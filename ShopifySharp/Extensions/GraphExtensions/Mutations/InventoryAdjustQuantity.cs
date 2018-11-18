using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace ShopifySharp
{
    public static partial class GraphExtensions
    {
        /// <summary>
        /// Adjust inventory quantity for a single Inventory Level item.
        /// </summary>
        /// <param name="graphService">The GraphService.</param>
        /// <param name="graphInventoryLevelId">The ID for the inventory level item, in format: gid://shopify/InventoryLevel/11111?inventory_item_id=11111</param>
        /// <param name="availableDelta">The amount to adjust inventory by, may be positive or negative.</param>
        /// <returns>The data object including the new quantity</returns>
        public static async Task<GraphMutationResponse> InventoryAdjustQuantityAsync(this GraphService graphService, string graphInventoryLevelId, int availableDelta)
        {
            string body = @"
                mutation {
                  inventoryAdjustQuantity(input: {
                inventoryLevelId: """ + graphInventoryLevelId + @""",
                        availableDelta: " + availableDelta + @"
                  }) {
                    userErrors {field, message
                    },
                    inventoryLevel { available
                }
                  }  
                }
                ";            

            JToken response = await graphService.PostAsync(body);

            GraphMutationResponse mutationResponse = new GraphMutationResponse();
            GraphKeyValuePair valuePair = new GraphKeyValuePair();

            valuePair.Id = graphInventoryLevelId;
            valuePair.Value = (int?)response.SelectToken("inventoryAdjustQuantity.inventoryLevel.available");
            mutationResponse.Values = new List<GraphKeyValuePair> { valuePair };

            mutationResponse.UserErrors = new List<GraphUserError>();
            JArray userErrors = (JArray)response.SelectToken("inventoryAdjustQuantity.userErrors");

            if (userErrors.Count > 0)
            {
                mutationResponse.UserErrors = userErrors.ToObject<IEnumerable<GraphUserError>>();
            }

            return mutationResponse;
        }
    }
}
