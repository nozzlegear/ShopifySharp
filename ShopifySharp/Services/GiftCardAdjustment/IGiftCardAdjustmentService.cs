using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public interface IGiftCardAdjustmentService : IShopifyService
    {
        /// <summary>
        /// Gets a list of gift card adjustments belonging to the given gift card.
        /// </summary>
        /// <param name="giftCardId">The gift card that the adjustment was applied to.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<IEnumerable<GiftCardAdjustment>> ListAsync(long giftCardId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the <see cref="GiftCardAdjustment"/> with the given id.
        /// </summary>
        /// <param name="giftCardId">The gift card that the adjustment was applied to.</param>
        /// <param name="adjustmentId">The id of the adjustment to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns></returns>
        Task<GiftCardAdjustment> GetAsync(long giftCardId, long adjustmentId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Apply an adjustment to an existing gift card <see cref="GiftCardAdjustment"/>
        /// </summary>
        /// <param name="giftCardId">The gift card that the adjustment was applied to.</param>
        /// <param name="adjustment">A new <see cref="GiftCardAdjustment"/>. Signed amount and note should be the only properties set.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns></returns>
        Task<GiftCardAdjustment> CreateAsync(long giftCardId, GiftCardAdjustment adjustment, CancellationToken cancellationToken = default);
    }
}