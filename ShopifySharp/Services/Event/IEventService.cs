using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp;

public interface IEventService : IShopifyService
{
    /// <summary>
    /// Gets a count of all site events.
    /// </summary>
    /// <param name="filter">Options for filtering the result.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<int> CountAsync(EventCountFilter filter = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves the <see cref="Event"/> with the given id.
    /// </summary>
    /// <param name="eventId">The id of the event to retrieve.</param>
    /// <param name="fields">A comma-separated list of fields to return.</param>
    /// <param name="cancellationToken">Cancellation Token</param>
    /// <returns>The <see cref="Event"/>.</returns>
    Task<Event> GetAsync(long eventId, string fields = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns a list of events for the given subject and subject type. A full list of supported subject types can be found at https://help.shopify.com/api/reference/event
    /// </summary>
    /// <param name="subjectId">Restricts results to just one subject item, e.g. all changes on a product.</param>
    /// <param name="subjectType">The subject's type, e.g. 'Order' or 'Product'. Known subject types are 'Articles', 'Blogs', 'Custom_Collections', 'Comments', 'Orders', 'Pages', 'Products' and 'Smart_Collections'.  A current list of subject types can be found at https://help.shopify.com/api/reference/event </param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<ListResult<Event>> ListAsync(long subjectId, string subjectType, ListFilter<Event> filter = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns a list of events.
    /// </summary>
    Task<ListResult<Event>> ListAsync(ListFilter<Event> filter, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns a list of events for the given subject and subject type. A full list of supported subject types can be found at https://help.shopify.com/api/reference/event
    /// </summary>
    /// <param name="subjectId">Restricts results to just one subject item, e.g. all changes on a product.</param>
    /// <param name="subjectType">The subject's type, e.g. 'Order' or 'Product'. Known subject types are 'Articles', 'Blogs', 'Custom_Collections', 'Comments', 'Orders', 'Pages', 'Products' and 'Smart_Collections'.  A current list of subject types can be found at https://help.shopify.com/api/reference/event </param>
    /// <param name="cancellationToken">Cancellation Token</param>
    Task<ListResult<Event>> ListAsync(long subjectId, string subjectType, EventListFilter filter, CancellationToken cancellationToken = default);

    /// <summary>
    /// Returns a list of events.
    /// </summary>
    Task<ListResult<Event>> ListAsync(EventListFilter filter = null, CancellationToken cancellationToken = default);
}