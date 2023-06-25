using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    public interface IDraftOrderService : IShopifyService
    {
        /// <summary>
        /// Retrieves a count of the shop's draft orders. 
        /// </summary>
        /// <param name="filter">Options for filtering the count.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<int> CountAsync(DraftOrderCountFilter filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of up to 250 of the shop's draft orders.
        /// </summary>
        Task<ListResult<DraftOrder>> ListAsync(ListFilter<DraftOrder> filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of up to 250 of the shop's draft orders.
        /// </summary>
        Task<ListResult<DraftOrder>> ListAsync(DraftOrderListFilter filter, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the object with the given id.
        /// </summary>
        /// <param name="id">The id of the object to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<DraftOrder> GetAsync(long id, string fields = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new draft order.
        /// </summary>
        /// <param name="order">A new DraftOrder. Id should be set to null.</param>
        /// <param name="useCustomerDefaultAddress">Optional boolean that you can send as part of a draft order object to load customer shipping information.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<DraftOrder> CreateAsync(DraftOrder order, bool useCustomerDefaultAddress, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new draft order.
        /// </summary>
        /// <param name="order">A new DraftOrder. Id should be set to null.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<DraftOrder> CreateAsync(DraftOrder order, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates the draft order with the given id.
        /// </summary>
        /// <param name="id">The id of the item being updated.</param>
        /// <param name="order">The updated draft order.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<DraftOrder> UpdateAsync(long id, DraftOrder order, CancellationToken cancellationToken = default);

        /// <summary>
        /// Deletes the draft order with the given id.
        /// </summary>
        /// <param name="id">The id of the item being deleted.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task DeleteAsync(long id, CancellationToken cancellationToken = default);

        /// <summary>
        /// Completes the draft order, transitioning it to a full order.
        /// </summary>
        /// <param name="id">The id of the item being completed.</param>
        /// <param name="paymentPending">A bool indicating whether payment is pending or not. True if payment is pending, false if payment is not pending and order has been paid. Defaults to false (payment not pending).</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<DraftOrder> CompleteAsync(long id, bool paymentPending = false, CancellationToken cancellationToken = default);

        /// <summary>
        /// Send an invoice for the draft order.
        /// </summary>
        /// <param name="id">The id of the item with the invoice.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<DraftOrderInvoice> SendInvoiceAsync(long id, DraftOrderInvoice customInvoice = null, CancellationToken cancellationToken = default);
    }
}