using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    public interface IRedirectService
    {
        /// <summary>
        /// Gets a count of all of the shop's redirects.
        /// </summary>
        /// <param name="filter">Options for filtering the result.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<int> CountAsync(RedirectCountFilter filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of up to 250 of the shop's redirects.
        /// </summary>
        Task<ListResult<Redirect>> ListAsync(ListFilter<Redirect> filter, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of up to 250 of the shop's redirects.
        /// </summary>
        Task<ListResult<Redirect>> ListAsync(RedirectListFilter filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the <see cref="Redirect"/> with the given id.
        /// </summary>
        /// <param name="redirectId">The id of the redirect to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="Redirect"/>.</returns>
        Task<Redirect> GetAsync(long redirectId, string fields = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new <see cref="Redirect"/> on the store. The redirect always starts out with a role of
        /// "unpublished." If the redirect has a different role, it will be assigned that only after all of its
        /// files have been extracted and stored by Shopify (which might take a couple of minutes).
        /// </summary>
        /// <param name="redirect">The new <see cref="Redirect"/>.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="Redirect"/>.</returns>
        Task<Redirect> CreateAsync(Redirect redirect, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the given <see cref="Redirect"/>.
        /// </summary>
        /// <param name="redirectId">Id of the object being updated.</param>
        /// <param name="redirect">The <see cref="Redirect"/> to update.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The updated <see cref="Redirect"/>.</returns>
        Task<Redirect> UpdateAsync(long redirectId, Redirect redirect, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes a redirect with the given Id.
        /// </summary>
        /// <param name="redirectId">The redirect object's Id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task DeleteAsync(long redirectId, CancellationToken cancellationToken = default);
    }
}