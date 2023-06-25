using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    public interface IOrderRiskService
    {
        /// <summary>
        /// Gets a list of all order risks for an order.
        /// </summary>
        /// <param name="orderId">The order the risks belong to.</param>
        /// <param name="filter">Options for filtering the request.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<ListResult<OrderRisk>> ListAsync(long orderId, ListFilter<OrderRisk> filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the <see cref="OrderRisk"/> with the given id.
        /// </summary>
        /// <param name="orderId">The order the risk belongs to.</param>
        /// <param name="riskId">The id of the risk to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<OrderRisk> GetAsync(long orderId, long riskId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new <see cref="OrderRisk"/> on the order.
        /// </summary>
        /// <param name="orderId">The order the risk belongs to.</param>
        /// <param name="risk">A new <see cref="OrderRisk"/>. Id should be set to null.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<OrderRisk> CreateAsync(long orderId, OrderRisk risk, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the given <see cref="OrderRisk"/>.
        /// </summary>
        /// <param name="orderRiskId">Id of the object being updated.</param>
        /// <param name="orderId">The order the risk belongs to.</param>
        /// <param name="risk">The risk to update.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<OrderRisk> UpdateAsync(long orderId, long orderRiskId, OrderRisk risk, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes an order with the given Id.
        /// </summary>
        /// <param name="orderId">The order the risk belongs to.</param>
        /// <param name="riskId">The risk's id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task DeleteAsync(long orderId, long riskId, CancellationToken cancellationToken = default);
    }
}