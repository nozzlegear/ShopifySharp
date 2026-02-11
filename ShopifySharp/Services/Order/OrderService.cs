using System;
using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Utilities;
using ShopifySharp.Credentials;

namespace ShopifySharp;

/// <summary>
/// A service for manipulating Shopify orders.
/// </summary>
public class OrderService : ShopifyService, IOrderService
{
    /// <summary>
    /// Creates a new instance of <see cref="OrderService" />.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public OrderService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    #nullable enable
    internal OrderService(ShopifyApiCredentials shopifyApiCredentials, IShopifyDomainUtility? shopifyDomainUtility = null) : base(shopifyApiCredentials, shopifyDomainUtility) {}
    internal OrderService(ShopifyApiCredentials shopifyApiCredentials, IServiceProvider serviceProvider) : base(shopifyApiCredentials, serviceProvider) {}
    #nullable restore

    internal OrderService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}

    /// <inheritdoc />
    public virtual async Task<int> CountAsync(OrderCountFilter filter = null, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<int>("orders/count.json", "count", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<Order>> ListAsync(ListFilter<Order> filter, CancellationToken cancellationToken = default) => 
        await ExecuteGetListAsync("orders.json", "orders", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<Order>> ListAsync(OrderListFilter filter = null, CancellationToken cancellationToken = default) => 
        await ListAsync(filter?.AsListFilter(), cancellationToken);

    /// <inheritdoc />
    public virtual async Task<Order> GetAsync(long orderId, string fields = null, CancellationToken cancellationToken = default) => 
        await ExecuteGetAsync<Order>($"orders/{orderId}.json", "order", fields, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<Order> CloseAsync(long id, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"orders/{id}/close.json");
        var response = await ExecuteRequestAsync<Order>(req, HttpMethod.Post, cancellationToken, rootElement: "order");

        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task<Order> OpenAsync(long id, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"orders/{id}/open.json");
        var response = await ExecuteRequestAsync<Order>(req, HttpMethod.Post, cancellationToken, rootElement: "order");

        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task<Order> CreateAsync(Order order, OrderCreateOptions options = null, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri("orders.json");
        var body = order.ToDictionary();

        if (options != null)
        {
            foreach (var option in options.ToDictionary())
            {
                body.Add(option);
            }
        }

        var content = new JsonContent(new
        {
            order = body
        });
        var response = await ExecuteRequestAsync<Order>(req, HttpMethod.Post, cancellationToken, content, "order");

        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task<Order> UpdateAsync(long orderId, Order order, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"orders/{orderId}.json");
        var content = new JsonContent(new
        {
            order = order
        });
        var response = await ExecuteRequestAsync<Order>(req, HttpMethod.Put, cancellationToken, content, "order");

        return response.Result;
    }

    /// <inheritdoc />
    public virtual async Task DeleteAsync(long orderId, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"orders/{orderId}.json");

        await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
    }

    /// <inheritdoc />
    public virtual async Task CancelAsync(long orderId, OrderCancelOptions options = null, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"orders/{orderId}/cancel.json");
        var content = new JsonContent(options ?? new OrderCancelOptions());

        await ExecuteRequestAsync(req, HttpMethod.Post, cancellationToken, content);
    }

    /// <inheritdoc />
    public virtual async Task<IEnumerable<MetaField>> GetMetaFieldsAsync(long orderId, CancellationToken cancellationToken = default)
    {
        var req = BuildRequestUri($"orders/{orderId}/metafields.json");
        var response = await ExecuteRequestAsync<List<MetaField>>(req, HttpMethod.Get, cancellationToken, rootElement: "metafields");

        return response.Result;
    }
}