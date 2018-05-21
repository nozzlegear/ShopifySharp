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

        /// <summary>
        /// Retrieves the object with the given id.
        /// </summary>
        /// <param name="id">The id of the object to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        public virtual async Task<DraftOrder> GetAsync(long id, string fields = null)
        {
            var req = PrepareRequest($"draft_orders/{id}.json");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.QueryParams.Add("fields", fields);
            }

            return await ExecuteRequestAsync<DraftOrder>(req, HttpMethod.Get, rootElement: "draft_order");
        }

        /// <summary>
        /// Creates a new draft order.
        /// </summary>
        /// <param name="order">A new DraftOrder. Id should be set to null.</param>
        /// <param name="useCustomerDefaultAddress">Optional boolean that you can send as part of a draft order object to load customer shipping information. Defaults to false.</param>
        public virtual async Task<DraftOrder> CreateAsync(DraftOrder order, bool useCustomerDefaultAddress = false)
        {
            var req = PrepareRequest("draft_orders.json");
            var body = order.ToDictionary();

            body.Add("use_customer_default_address", useCustomerDefaultAddress);

            var content = new JsonContent(new 
            {
                draft_order = body
            });

            return await ExecuteRequestAsync<DraftOrder>(req, HttpMethod.Post, content, "draft_order");
        }

        /// <summary>
        /// Updates the draft order with the given id.
        /// </summary>
        /// <param name="id">The id of the item being updated.</param>
        /// <param name="order">The updated draft order.</param>
        public virtual async Task<DraftOrder> UpdateAsync(long id, DraftOrder order)
        {
            var req = PrepareRequest($"draft_orders/{id}.json");
            var content = new JsonContent(new 
            {
                draft_order = order.ToDictionary()
            });

            return await ExecuteRequestAsync<DraftOrder>(req, HttpMethod.Put, content, "draft_order");
        }

        /// <summary>
        /// Deletes the draft order with the given id.
        /// </summary>
        /// <param name="id">The id of the item being deleted.</param>
        public virtual async Task DeleteAsync(long id)
        {
            var req = PrepareRequest($"draft_orders/{id}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }

        /// <summary>
        /// Completes the draft order, transitioning it to a full order.
        /// </summary>
        /// <param name="id">The id of the item being completed.</param>
        /// <param name="paymentPending">A bool indicating whether payment is pending or not. True if payment is pending, false if payment is not pending and order has been paid. Defaults to false (payment not pending).</param>
        public virtual async Task<DraftOrder> CompleteAsync(long id, bool paymentPending = false)
        {
            var req = PrepareRequest($"draft_orders/{id}/complete.json");
            req.QueryParams.Add("payment_pending", paymentPending);

            return await ExecuteRequestAsync<DraftOrder>(req, HttpMethod.Put, rootElement: "draft_order");
        }

        /// <summary>
        /// Send an invoice for the draft order.
        /// </summary>
        /// <param name="id">The id of the item with the invoice.</param>
        public virtual async Task<DraftOrder> SendInvoice(long id)
        {
            var req = PrepareRequest($"draft_orders/{id}/send_invoice.json");

            return await ExecuteRequestAsync<DraftOrder>(req, HttpMethod.Put, rootElement: "draft_order");
        }
    }
}