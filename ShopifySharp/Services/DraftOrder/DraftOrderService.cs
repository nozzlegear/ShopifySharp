using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;

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

        /// <summary>
        /// Retrieves a count of the shop's draft orders. 
        /// </summary>
        /// <param name="filter">Options for filtering the count.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<int> CountAsync(DraftOrderCountFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<int>("draft_orders/count.json", "count", filter, cancellationToken);
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's draft orders.
        /// </summary>
        public virtual async Task<ListResult<DraftOrder>> ListAsync(ListFilter<DraftOrder> filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync("draft_orders.json", "draft_orders", filter, cancellationToken);
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's draft orders.
        /// </summary>
        public virtual async Task<ListResult<DraftOrder>> ListAsync(DraftOrderListFilter filter, CancellationToken cancellationToken = default)
        {
            return await ListAsync((ListFilter<DraftOrder>)filter, cancellationToken);
        }

        /// <summary>
        /// Retrieves the object with the given id.
        /// </summary>
        /// <param name="id">The id of the object to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<DraftOrder> GetAsync(long id, string fields = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<DraftOrder>($"draft_orders/{id}.json", "draft_order", fields, cancellationToken);
        }

        /// <summary>
        /// Creates a new draft order.
        /// </summary>
        /// <param name="order">A new DraftOrder. Id should be set to null.</param>
        /// <param name="useCustomerDefaultAddress">Optional boolean that you can send as part of a draft order object to load customer shipping information.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<DraftOrder> CreateAsync(DraftOrder order, bool useCustomerDefaultAddress, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest("draft_orders.json");
            var body = order.ToDictionary();

            body.Add("use_customer_default_address", useCustomerDefaultAddress);

            var content = new JsonContent(new
            {
                draft_order = body
            });

            var response = await ExecuteRequestAsync<DraftOrder>(req, HttpMethod.Post, cancellationToken, content, "draft_order");
            return response.Result;
        }

        /// <summary>
        /// Creates a new draft order.
        /// </summary>
        /// <param name="order">A new DraftOrder. Id should be set to null.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<DraftOrder> CreateAsync(DraftOrder order, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest("draft_orders.json");
            var content = new JsonContent(new
            {
                draft_order = order.ToDictionary()
            });

            var response = await ExecuteRequestAsync<DraftOrder>(req, HttpMethod.Post, cancellationToken, content, "draft_order");
            return response.Result;
        }

        /// <summary>
        /// Updates the draft order with the given id.
        /// </summary>
        /// <param name="id">The id of the item being updated.</param>
        /// <param name="order">The updated draft order.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<DraftOrder> UpdateAsync(long id, DraftOrder order, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"draft_orders/{id}.json");
            var content = new JsonContent(new
            {
                draft_order = order.ToDictionary()
            });

            var response = await ExecuteRequestAsync<DraftOrder>(req, HttpMethod.Put, cancellationToken, content, "draft_order");
            return response.Result;
        }

        /// <summary>
        /// Deletes the draft order with the given id.
        /// </summary>
        /// <param name="id">The id of the item being deleted.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"draft_orders/{id}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
        }

        /// <summary>
        /// Completes the draft order, transitioning it to a full order.
        /// </summary>
        /// <param name="id">The id of the item being completed.</param>
        /// <param name="paymentPending">A bool indicating whether payment is pending or not. True if payment is pending, false if payment is not pending and order has been paid. Defaults to false (payment not pending).</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<DraftOrder> CompleteAsync(long id, bool paymentPending = false, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"draft_orders/{id}/complete.json");
            req.QueryParams.Add("payment_pending", paymentPending);

            var response = await ExecuteRequestAsync<DraftOrder>(req, HttpMethod.Put, cancellationToken, rootElement: "draft_order");
            return response.Result;
        }

        /// <summary>
        /// Send an invoice for the draft order.
        /// </summary>
        /// <param name="id">The id of the item with the invoice.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<DraftOrderInvoice> SendInvoiceAsync(long id, DraftOrderInvoice customInvoice = null, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"draft_orders/{id}/send_invoice.json");
            // If the custom invoice is not null, use that as the body. Else use an empty dictionary object which will send the default invoice
            var body = customInvoice?.ToDictionary() ?? new Dictionary<string, object>();
            var content = new JsonContent(new
            {
                draft_order_invoice = body
            });

            var response = await ExecuteRequestAsync<DraftOrderInvoice>(req, HttpMethod.Post, cancellationToken, content, "draft_order_invoice");
            return response.Result;
        }
    }
}
