using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    public interface IGiftCardService
    {
        /// <summary>
        /// Gets a count of all of the gift cards on the shop.
        /// </summary>
        /// <param name="filter">Options for filtering the count.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<int> CountAsync(GiftCardCountFilter filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of up to 250 of the gift cards.
        /// </summary>
        /// <param name="filter">Options for filtering the list.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<ListResult<GiftCard>> ListAsync(ListFilter<GiftCard> filter, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of up to 250 of the gift cards.
        /// </summary>
        /// <param name="filter">Options for filtering the list.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<ListResult<GiftCard>> ListAsync(GiftCardListFilter filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the <see cref="GiftCard"/> with the given id.
        /// </summary>
        /// <param name="giftCardId">The id of the GiftCard to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="GiftCard"/>.</returns>
        Task<GiftCard> GetAsync(long giftCardId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new <see cref="GiftCard"/>.
        /// </summary>
        /// <param name="giftCard">A new <see cref="GiftCard"/>. Id should be set to null.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="GiftCard"/>.</returns>
        Task<GiftCard> CreateAsync(GiftCard giftCard, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the given <see cref="GiftCard"/>.
        /// </summary>
        /// <param name="giftCardId">Id of the object being updated.</param>
        /// <param name="giftCard">The <see cref="GiftCard"/> to update.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The updated <see cref="GiftCard"/>.</returns>
        Task<GiftCard> UpdateAsync(long giftCardId, GiftCard giftCard, CancellationToken cancellationToken = default);

        /// <summary>
        /// Disables the <see cref="GiftCard"/> with the given id.
        /// </summary>
        /// <param name="giftCardId">The id of the GiftCard to disable.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="GiftCard"/>.</returns>
        Task<GiftCard> DisableAsync(long giftCardId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Search for gift cards matching supplied query
        /// </summary>
        /// <param name="filter">Options for searching and filtering the results.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<ListResult<GiftCard>> SearchAsync(GiftCardSearchFilter filter, CancellationToken cancellationToken = default);
    }
}