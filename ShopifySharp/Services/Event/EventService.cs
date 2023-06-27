using ShopifySharp.Filters;
using ShopifySharp.Lists;
using System.Threading.Tasks;
using System.Threading;
using System;

namespace ShopifySharp
{
    /// <summary>
    /// A service for getting Shopify Events
    /// Reference: https://help.shopify.com/api/reference/event
    /// </summary>
    public class EventService : ShopifyService, IEventService
    {
        /// <summary>
        /// Creates a new instance of <see cref="EventService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public EventService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <inheritdoc />
        public virtual async Task<int> CountAsync(EventCountFilter filter = null, CancellationToken cancellationToken = default) =>
            await ExecuteGetAsync<int>("events/count.json", "count", filter, cancellationToken: cancellationToken);

        /// <inheritdoc />
        public virtual async Task<Event> GetAsync(long eventId, string fields = null, CancellationToken cancellationToken = default) =>
            await ExecuteGetAsync<Event>($"events/{eventId}.json", "event", fields, cancellationToken: cancellationToken);

        /// <inheritdoc />
        public virtual async Task<ListResult<Event>> ListAsync(long subjectId, string subjectType, ListFilter<Event> filter = null, CancellationToken cancellationToken = default)
        {
            // Ensure the subject type is plural
            if (!subjectType.Substring(subjectType.Length - 1).Equals("s", StringComparison.OrdinalIgnoreCase))
            {
                subjectType = subjectType + "s";
            }
            
            return await ExecuteGetListAsync($"{subjectType?.ToLower()}/{subjectId}/events.json", "events", filter, cancellationToken: cancellationToken);
        }

        /// <inheritdoc />
        public virtual async Task<ListResult<Event>> ListAsync(ListFilter<Event> filter, CancellationToken cancellationToken = default) =>
            await ExecuteGetListAsync($"events.json", "events", filter, cancellationToken: cancellationToken);

        /// <inheritdoc />
        public virtual async Task<ListResult<Event>> ListAsync(long subjectId, string subjectType, EventListFilter filter, CancellationToken cancellationToken = default) =>
            await ListAsync(subjectId, subjectType, (ListFilter<Event>) filter, cancellationToken);

        /// <inheritdoc />
        public virtual async Task<ListResult<Event>> ListAsync(EventListFilter filter = null, CancellationToken cancellationToken = default) =>
            await ListAsync(filter?.AsListFilter(), cancellationToken);
    }
}