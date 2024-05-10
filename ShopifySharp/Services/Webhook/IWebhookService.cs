using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp;

public interface IWebhookService : IShopifyService
{
    /// <summary>
    /// Gets a count of all of the shop's webhooks.
    /// </summary>
    /// <param name="filter">Options for filtering the result.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The count of all webhooks for the shop.</returns>
    Task<int> CountAsync(WebhookCountFilter filter = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a list of up to 250 of the shop's webhooks.
    /// </summary>
    /// <param name="filter">Options for filtering the list.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<ListResult<Webhook>> ListAsync(ListFilter<Webhook> filter, CancellationToken cancellationToken = default);

    /// <summary>
    /// Gets a list of up to 250 of the shop's webhooks.
    /// </summary>
    /// <param name="filter">Options for filtering the list.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<ListResult<Webhook>> ListAsync(WebhookListFilter filter = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves the <see cref="Webhook"/> with the given id.
    /// </summary>
    /// <param name="webhookId">The id of the webhook to retrieve.</param>
    /// <param name="fields">A comma-separated list of fields to return.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The <see cref="Webhook"/>.</returns>
    Task<Webhook> GetAsync(long webhookId, string fields = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a new <see cref="Webhook"/> on the store.
    /// </summary>
    /// <param name="webhook">A new <see cref="Webhook"/>. Id should be set to null.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The new <see cref="Webhook"/>.</returns>
    Task<Webhook> CreateAsync(Webhook webhook, CancellationToken cancellationToken = default);

    /// <summary>
    /// Updates the given <see cref="Webhook"/>.
    /// </summary>
    /// <param name="webhookId">Id of the object being updated.</param>
    /// <param name="webhook">The <see cref="Webhook"/> to update.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The updated <see cref="Webhook"/>.</returns>
    Task<Webhook> UpdateAsync(long webhookId, Webhook webhook, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes the webhook with the given Id.
    /// </summary>
    /// <param name="webhookId">The order object's Id.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task DeleteAsync(long webhookId, CancellationToken cancellationToken = default);
}