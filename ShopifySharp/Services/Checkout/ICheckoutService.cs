using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    public interface ICheckoutService : IShopifyService
    {
        /// <summary>
        /// Gets a count of all of the shop's orders.
        /// </summary>
        /// <param name="filter">Options for filtering the count.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The count of all orders for the shop.</returns>
        Task<int> CountAsync(CheckoutCountFilter filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of up to 250 of the shop's abandoned checkouts.
        /// </summary>
        /// <param name="filter">Options for filtering the result.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<ListResult<Checkout>> ListAsync(ListFilter<Checkout> filter, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a list of up to 250 of the shop's abandoned checkouts.
        /// </summary>
        /// <param name="filter">Options for filtering the result.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        Task<ListResult<Checkout>> ListAsync(CheckoutListFilter filter = null, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new Checkout.
        /// </summary>
        Task<Checkout> CreateAsync(Checkout checkout, CancellationToken cancellationToken = default);

        /// <summary>
        /// Completes a checkout without requiring payment.
        /// </summary>
        Task<Checkout> CompleteAsync(string token, CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets an existing, processing or completed checkout.
        /// </summary>
        Task<Checkout> GetAsync(string token, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates an existing checkout based on the token id.
        /// </summary>
        Task<Checkout> UpdateAsync(string token, Checkout updatedCheckout, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of available shipping rates for the specified checkout. Implementers need to poll this endpoint until rates become available. Each shipping rate contains the checkout's 
        /// new subtotal price, total tax, and total price in the event that this shipping rate is selected. This can be used to update the UI without performing further API requests. To apply a 
        /// shipping rate, update the checkout's shipping line with the handle of the selected rate. 
        /// </summary>
        Task<IEnumerable<CheckoutShippingRate>> ListShippingRatesAsync(string token, CancellationToken cancellationToken = default);
    }
}