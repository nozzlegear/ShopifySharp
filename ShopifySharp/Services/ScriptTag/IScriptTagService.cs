using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    public interface IScriptTagService : IShopifyService
    {
        /// <summary>
        /// Gets a count of all of the shop's <see cref="ScriptTag"/>s.
        /// </summary>
        /// <param name="filter">Options for filtering the result.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<int> CountAsync(ScriptTagCountFilter filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of up to 250 of the shop's script tags.
        /// </summary>
        Task<ListResult<ScriptTag>> ListAsync(ListFilter<ScriptTag> filter, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of up to 250 of the shop's script tags.
        /// </summary>
        Task<ListResult<ScriptTag>> ListAsync(ScriptTagListFilter filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the <see cref="ScriptTag"/> with the given id.
        /// </summary>
        /// <param name="tagId">The id of the <see cref="ScriptTag"/> to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="ScriptTag"/>.</returns>
        Task<ScriptTag> GetAsync(long tagId, string fields = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new <see cref="ScriptTag"/> on the store.
        /// </summary>
        /// <param name="tag">A new <see cref="ScriptTag"/>. Id should be set to null.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="ScriptTag"/>.</returns>
        Task<ScriptTag> CreateAsync(ScriptTag tag, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the given <see cref="ScriptTag"/>.
        /// </summary>
        /// <param name="scriptTagId">Id of the object being updated.</param>
        /// <param name="tag">The <see cref="ScriptTag"/> to update.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The updated <see cref="ScriptTag"/>.</returns>
        Task<ScriptTag> UpdateAsync(long scriptTagId, ScriptTag tag, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the <see cref="ScriptTag"/> with the given Id.
        /// </summary>
        /// <param name="tagId">The tag's Id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task DeleteAsync(long tagId, CancellationToken cancellationToken = default);
    }
}