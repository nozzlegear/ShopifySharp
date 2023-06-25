using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Entities.SalesChannel;

namespace ShopifySharp
{
    public interface ICheckoutSalesChannelService
    {
        /// <summary>
        /// Gets an existing, processing or completed checkout.
        /// </summary>
        Task<CheckoutSalesChannel> GetAsync(string token, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a new Checkout.
        /// </summary>
        Task<CheckoutSalesChannel> CreateAsync(CheckoutSalesChannel checkout,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Completes a checkout without requiring payment.
        /// </summary>
        Task<CheckoutSalesChannel> CompleteAsync(string token, CancellationToken cancellationToken = default);

        /// <summary>
        /// Updates an existing checkout based on the token id.
        /// </summary>
        Task<CheckoutSalesChannel> UpdateAsync(string token, CheckoutSalesChannel checkout,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a list of available shipping rates for the specified checkout. Implementers need to poll this endpoint until rates become available. Each shipping rate contains the checkout's 
        /// new subtotal price, total tax, and total price in the event that this shipping rate is selected. This can be used to update the UI without performing further API requests. To apply a 
        /// shipping rate, update the checkout's shipping line with the handle of the selected rate. 
        /// </summary>
        Task<IEnumerable<CheckoutShippingRate>> ListShippingRatesAsync(string token, CancellationToken cancellationToken = default);

        /// <summary>
        /// Creates a payment on a checkout using the session ID returned by the card vault
        /// </summary>
        Task<PaymentSalesChannel> CreatePaymentAsync(string token, CreatePayment createPayment,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Stores a credit card in the card vault. Credit cards cannot be sent to the Checkout API directly.
        /// They must be sent to the card vault, which in response will return a session ID.
        /// This session ID can then be used when calling the POST #{token}/payments.json endpoint <see cref="CheckoutSalesChannelService.CreatePaymentAsync" />.
        /// A session ID is valid only for a single call to the endpoint.
        /// The card vault has a static URL and is located at https://elb.deposit.shopifycs.com/sessions.
        /// It is also provided via the payment_url property on the Checkout resource.
        /// </summary>
        /// <returns></returns>
        Task<CardVault> StoreCreditCard(CreditCard creditCard, CancellationToken cancellationToken = default);
    }
}