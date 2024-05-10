using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Utilities;

namespace ShopifySharp;

/// <summary>
/// A service for manipulating Shopify draft orders.
/// </summary>
public class DraftOrderService : ShopifyService, IDraftOrderService
{
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public DraftOrderService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    internal DraftOrderService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    /// <inheritdoc />
    public virtual async Task<int> CountAsync(DraftOrderCountFilter filter = null, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<int>("draft_orders/count.json", "count", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<DraftOrder>> ListAsync(ListFilter<DraftOrder> filter = null, CancellationToken cancellationToken = default) =>
        await ExecuteGetListAsync("draft_orders.json", "draft_orders", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<DraftOrder>> ListAsync(DraftOrderListFilter filter, CancellationToken cancellationToken = default) =>
        await ListAsync((ListFilter<DraftOrder>)filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<DraftOrder> GetAsync(long id, string fields = null, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<DraftOrder>($"draft_orders/{id}.json", "draft_order", fields, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<DraftOrder> CreateAsync(DraftOrder order, bool useCustomerDefaultAddress, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri("draft_orders.json");
        var body = order.ToDictionary();

        body.Add("use_customer_default_address", useCustomerDefaultAddress);

        var content = new JsonContent(new
        {
            draft_order = body
        });

        var response = await ExecuteRequestAsync<DraftOrder>(req, HttpMethod.Post, cancellationToken, content, "draft_order");
        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task<DraftOrder> CreateAsync(DraftOrder order, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri("draft_orders.json");
        var content = new JsonContent(new
        {
            draft_order = order.ToDictionary()
        });

        var response = await ExecuteRequestAsync<DraftOrder>(req, HttpMethod.Post, cancellationToken, content, "draft_order");
        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task<DraftOrder> UpdateAsync(long id, DraftOrder order, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"draft_orders/{id}.json");
        var content = new JsonContent(new
        {
            draft_order = order.ToDictionary()
        });

        var response = await ExecuteRequestAsync<DraftOrder>(req, HttpMethod.Put, cancellationToken, content, "draft_order");
        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task DeleteAsync(long id, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"draft_orders/{id}.json");

        await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
    }

    /// <inheritdoc />
    public virtual async Task<DraftOrder> CompleteAsync(long id, bool paymentPending = false, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"draft_orders/{id}/complete.json");
        req.QueryParams.Add("payment_pending", paymentPending);

        var response = await ExecuteRequestAsync<DraftOrder>(req, HttpMethod.Put, cancellationToken, rootElement: "draft_order");
        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task<DraftOrderInvoice> SendInvoiceAsync(long id, DraftOrderInvoice customInvoice = null, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"draft_orders/{id}/send_invoice.json");
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