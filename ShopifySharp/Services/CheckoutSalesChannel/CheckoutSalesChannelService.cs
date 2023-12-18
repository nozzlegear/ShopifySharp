using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Entities.SalesChannel;
using ShopifySharp.Infrastructure;

namespace ShopifySharp
{
    /// <summary>
    ///  A service use the Checkout API to let customers purchase products from Shopify stores that have installed your sales channel.
    /// </summary>
    public class CheckoutSalesChannelService: ShopifyService, ICheckoutSalesChannelService
    {
        public CheckoutSalesChannelService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <inheritdoc />
        public virtual async Task<CheckoutSalesChannel> GetAsync(string token, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"checkouts/{token}.json");

            var response = await ExecuteRequestAsync<CheckoutSalesChannel>(req, HttpMethod.Get, cancellationToken, rootElement: "checkout");
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<CheckoutSalesChannel> CreateAsync(CheckoutSalesChannel checkout,
            CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri("checkouts.json");

            var response = await ExecuteRequestAsync<CheckoutSalesChannel>(req, HttpMethod.Post, cancellationToken,
                new JsonContent(new {checkout}), "checkout");
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<CheckoutSalesChannel> CompleteAsync(string token, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"checkouts/{token}/complete.json");

            var response = await ExecuteRequestAsync<CheckoutSalesChannel>(req, HttpMethod.Post, cancellationToken, rootElement: "checkout");
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<CheckoutSalesChannel> UpdateAsync(string token, CheckoutSalesChannel checkout,
            CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"checkouts/{token}.json");

            var response = await ExecuteRequestAsync<CheckoutSalesChannel>(req, HttpMethod.Put, cancellationToken,
                new JsonContent(new { checkout }), "checkout");
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<IEnumerable<CheckoutShippingRate>> ListShippingRatesAsync(string token, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"checkouts/{token}/shipping_rates.json");

            var response = await ExecuteRequestAsync<List<CheckoutShippingRate>>(req, HttpMethod.Get, cancellationToken, rootElement: "shipping_rates");
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<PaymentSalesChannel> CreatePaymentAsync(string token, CreatePayment createPayment,
            CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"checkouts/{token}/payments.json");

            var response = await ExecuteRequestAsync<PaymentSalesChannel>(req, HttpMethod.Post, cancellationToken,
                new JsonContent(new {payment = createPayment}), "payment");
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<CardVault> StoreCreditCard(CreditCard creditCard, CancellationToken cancellationToken = default)
        {
            var req = new RequestUri(new Uri("https://elb.deposit.shopifycs.com/sessions"));

            var response = await ExecuteRequestAsync<CardVault>(req, HttpMethod.Post, cancellationToken,
                new JsonContent(new { credit_card = creditCard }));

            return response.Result;
        }
    }
}