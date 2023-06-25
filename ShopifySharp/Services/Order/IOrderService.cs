using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    public interface IOrderService : IShopifyService
    {
        /// <summary>
        /// Gets a count of all of the shop's orders.
        /// </summary>
        /// <param name="filter">Options for filtering the count.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The count of all orders for the shop.</returns>
        Task<int> CountAsync(OrderCountFilter filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of up to 250 of the shop's orders.
        /// </summary>
        /// <param name="filter">Options for filtering the list.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The list of orders matching the filter.</returns>
        Task<ListResult<Order>> ListAsync(ListFilter<Order> filter, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of up to 250 of the shop's orders.
        /// </summary>
        /// <param name="filter">Options for filtering the list.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The list of orders matching the filter.</returns>
        Task<ListResult<Order>> ListAsync(OrderListFilter filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the <see cref="Order"/> with the given id.
        /// </summary>
        /// <param name="orderId">The id of the order to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="Order"/>.</returns>
        Task<Order> GetAsync(long orderId, string fields = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Closes an order.
        /// </summary>
        /// <param name="id">The order's id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<Order> CloseAsync(long id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Opens a closed order.
        /// </summary>
        /// <param name="id">The order's id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<Order> OpenAsync(long id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new <see cref="Order"/> on the store.
        /// </summary>
        /// <param name="order">A new <see cref="Order"/>. Id should be set to null.</param>
        /// <param name="options">Options for creating the order.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="Order"/>.</returns>
        Task<Order> CreateAsync(Order order, OrderCreateOptions options = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the given <see cref="Order"/>.
        /// </summary>
        /// <param name="orderId">Id of the object being updated.</param>
        /// <param name="order">The <see cref="Order"/> to update.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The updated <see cref="Order"/>.</returns>
        Task<Order> UpdateAsync(long orderId, Order order, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes an order with the given Id.
        /// </summary>
        /// <param name="orderId">The order object's Id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task DeleteAsync(long orderId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Cancels an order.
        /// </summary>
        /// <param name="orderId">The order's id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The cancelled <see cref="Order"/>.</returns>
        Task CancelAsync(long orderId, OrderCancelOptions options = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Get MetaField's for an order.
        /// </summary>
        /// <param name="orderId">The order's id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The set of <see cref="MetaField"/> for the order.</returns>
        Task<IEnumerable<MetaField>> GetMetaFieldsAsync(long orderId, CancellationToken cancellationToken = default);
    }
}