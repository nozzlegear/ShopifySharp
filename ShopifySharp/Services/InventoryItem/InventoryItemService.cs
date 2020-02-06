using System;
using System.Net.Http;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;

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
        /// <param name="filterOptions">Options for filtering the result. Ids must be populated.</param>
        public virtual async Task<IEnumerable<InventoryItem>> ListAsync(IListFilter filter)
        {
            throw new Exception("not yet implemented");
            // var req = PrepareRequest($"inventory_items.json");
            //
            // if (filterOptions != null)
            // {
            //     req.QueryParams.AddRange(filterOptions.ToParameters());
            // }
            //
            // return await ExecuteRequestAsync<List<InventoryItem>>(req, HttpMethod.Get, rootElement: "inventory_items");
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
