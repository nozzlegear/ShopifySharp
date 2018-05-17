using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;

namespace ShopifySharp 
{
    /// <summary>
    /// A service for manipulating Shopify draft orders.
    /// </summary>
    public class DraftOrderService : ShopifyService
    {

        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public DraftOrderService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }        

        public virtual async Task<int> CountAsync(DraftOrderFilter filter = null)
        {
            var req = PrepareRequest("draft_orders/count.json");

            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToParameters());
            }

            return await ExecuteRequestAsync<int>(req, HttpMethod.Get, rootElement: "count");
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's draft orders.
        /// </summary>
        /// <param name="filter">Options for filtering the list.</param>
        public virtual async Task<IEnumerable<DraftOrder>> ListAsync(ListFilter filter = null)
        {
            var req = PrepareRequest("draft_orders.json");

            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToParameters());
            }

            return await ExecuteRequestAsync<List<DraftOrder>>(req, HttpMethod.Get, rootElement: "draft_orders");
        }


    }
}