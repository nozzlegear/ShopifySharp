using ShopifySharp.Filters;
using ShopifySharp.Lists;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Utilities;

namespace ShopifySharp;

/// <summary>
/// A service for manipulating Shopify webhooks.
/// </summary>
public class WebhookService : ShopifyService, IWebhookService
{
    /// <summary>
    /// Creates a new instance of <see cref="WebhookService" />.
    /// </summary>
    /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
    /// <param name="shopAccessToken">An API access token for the shop.</param>
    public WebhookService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
    internal WebhookService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
    /// <inheritdoc />
    public virtual async Task<int> CountAsync(WebhookCountFilter filter = null, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<int>("webhooks/count.json", "count", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<Webhook>> ListAsync(ListFilter<Webhook> filter, CancellationToken cancellationToken = default) =>
        await ExecuteGetListAsync("webhooks.json", "webhooks", filter, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<ListResult<Webhook>> ListAsync(WebhookListFilter filter = null, CancellationToken cancellationToken = default) =>
        await ListAsync(filter?.AsListFilter(), cancellationToken);

    /// <inheritdoc />
    public virtual async Task<Webhook> GetAsync(long webhookId, string fields = null, CancellationToken cancellationToken = default) =>
        await ExecuteGetAsync<Webhook>($"webhooks/{webhookId}.json", "webhook", fields, cancellationToken);

    /// <inheritdoc />
    public virtual async Task<Webhook> CreateAsync(Webhook webhook, CancellationToken cancellationToken = default) =>
        await ExecutePostAsync<Webhook>("webhooks.json", "webhook", cancellationToken, new { webhook = webhook });

    /// <inheritdoc />
    public virtual async Task<Webhook> UpdateAsync(long webhookId, Webhook webhook, CancellationToken cancellationToken = default) =>
        await ExecutePutAsync<Webhook>($"webhooks/{webhookId}.json", "webhook", cancellationToken, new { webhook = webhook });

    /// <inheritdoc />
    public virtual async Task DeleteAsync(long webhookId, CancellationToken cancellationToken = default) =>
        await ExecuteDeleteAsync($"webhooks/{webhookId}.json", cancellationToken);
}