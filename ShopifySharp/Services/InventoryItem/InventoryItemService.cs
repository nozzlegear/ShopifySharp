using System;
using System.Net.Http;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating a Shopify inventory items.
    /// </summary>
    public class InventoryItemService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="InventoryItemService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public InventoryItemService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of inventory items.
        /// </summary>
        /// <param name="ids">Show only inventory items specified by a list of IDs. Maximum: 100.</param>
        public virtual async Task<IListResult<InventoryItem>> ListAsync(IEnumerable<long> ids, IListFilter filter)
        {
            var req = PrepareRequest($"inventory_items.json");

            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToQueryParameters());
            }
            
            req.QueryParams.Add("ids", string.Join(",", ids));
            
            var response = await ExecuteRequestAsync<List<InventoryItem>>(req, HttpMethod.Get, rootElement: "inventory_items");

            return ParseLinkHeaderToListResult(response);
        }

        /// <summary>
        /// Retrieves the <see cref="InventoryItem"/> with the given id.
        /// </summary>
        /// <param name="inventoryItemId">The id of the inventory item to retrieve.</param>
        public virtual async Task<InventoryItem> GetAsync(long inventoryItemId)
        {
            var req = PrepareRequest($"inventory_items/{inventoryItemId}.json");

            var response = await ExecuteRequestAsync<InventoryItem>(req, HttpMethod.Get, rootElement: "inventory_item");
            return response.Result;
        }


        /// <summary>
        /// Updates an existing <see cref="InventoryItem"/>.
        /// </summary>
        /// <param name="inventoryItemId">The id of the inventory item to retrieve.</param>
        public virtual async Task<InventoryItem> UpdateAsync( long inventoryItemId, InventoryItem inventoryItem )
        {
            var req = PrepareRequest( $"inventory_items/{inventoryItemId}.json" );
            var content = new JsonContent( new
            {
                inventory_item = inventoryItem
            } );

            var response = await ExecuteRequestAsync<InventoryItem>( req, HttpMethod.Put, content, rootElement: "inventory_item" );
            return response.Result;
        }
    }
}
