using System;
using System.Collections.Generic;
using System.Net.Http;
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

        private async Task<int> _CountAsync(ICountFilter filter = null)
        {
            var req = PrepareRequest("draft_orders/count.json");
            
            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToQueryParameters());
            }
            
            var response = await ExecuteRequestAsync<int>(req, HttpMethod.Get, rootElement: "count");

            return response.Result;
        }

        /// <summary>
        /// Retrieves a count of the shop's draft orders. 
        /// </summary>
        /// <param name="filter">Options for filtering the count.</param>
        public virtual async Task<int> CountAsync(ICountFilter filter = null)
        {
            return await _CountAsync(filter);
        }

        /// <summary>
        /// Retrieves a count of the shop's draft orders. 
        /// </summary>
        /// <param name="filter">Options for filtering the count.</param>
        public virtual async Task<int> CountAsync(DraftOrderCountFilter filter = null)
        {
            return await _CountAsync(filter);
        }
        
        /// <summary>
        /// Gets a list of up to 250 of the shop's draft orders.
        /// </summary>
        public virtual async Task<IListResult<DraftOrder>> ListAsync(IListFilter filter)
        {
            var req = PrepareRequest("draft_orders.json");
            
            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToQueryParameters());
            }
            
            var response = await ExecuteRequestAsync<List<DraftOrder>>(req, HttpMethod.Get, rootElement: "draft_orders");

            return ParseLinkHeaderToListResult(response);
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's draft orders.
        /// </summary>
        public virtual async Task<IListResult<DraftOrder>> ListAsync(DraftOrderListFilter filter)
        {
            return await ListAsync((IListFilter) filter);
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

            var response = await ExecuteRequestAsync<DraftOrder>(req, HttpMethod.Get, rootElement: "draft_order");
            return response.Result;
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

            var response = await ExecuteRequestAsync<DraftOrder>(req, HttpMethod.Post, content, "draft_order");
            return response.Result;
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

            var response = await ExecuteRequestAsync<DraftOrder>(req, HttpMethod.Put, content, "draft_order");
            return response.Result;
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

            var response = await ExecuteRequestAsync<DraftOrder>(req, HttpMethod.Put, rootElement: "draft_order");
            return response.Result;
        }

        /// <summary>
        /// Send an invoice for the draft order.
        /// </summary>
        /// <param name="id">The id of the item with the invoice.</param>
        public virtual async Task<DraftOrderInvoice> SendInvoiceAsync(long id, DraftOrderInvoice customInvoice = null)
        {
            var req = PrepareRequest($"draft_orders/{id}/send_invoice.json");
            // If the custom invoice is not null, use that as the body. Else use an empty dictionary object which will send the default invoice
            var body = customInvoice?.ToDictionary() ?? new Dictionary<string, object>();
            var content = new JsonContent(new 
            {
                draft_order_invoice = body
            });

            var response = await ExecuteRequestAsync<DraftOrderInvoice>(req, HttpMethod.Post, content, "draft_order_invoice");
            return response.Result;
        }
    }
}
