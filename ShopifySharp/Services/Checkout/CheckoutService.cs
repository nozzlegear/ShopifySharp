using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Utilities;
using System;

namespace ShopifySharp
{
    /// <summary>
    /// A service for working with abandoned checkouts.
    /// </summary>
    [Obsolete("https://shopify.dev/changelog/deprecation-of-checkout-apis")]
    public class CheckoutService : ShopifyService, ICheckoutService
    {
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CheckoutService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
        internal CheckoutService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
        /// <inheritdoc />
        public virtual async Task<int> CountAsync(CheckoutCountFilter filter = null, CancellationToken cancellationToken = default) =>
            await ExecuteGetAsync<int>("checkouts/count.json", "count", filter, cancellationToken);

        /// <inheritdoc />
        public virtual async Task<ListResult<Checkout>> ListAsync(ListFilter<Checkout> filter, CancellationToken cancellationToken = default) =>
            await ExecuteGetListAsync("checkouts.json", "checkouts", filter, cancellationToken);

        /// <inheritdoc />
        public virtual async Task<ListResult<Checkout>> ListAsync(CheckoutListFilter filter = null, CancellationToken cancellationToken = default) =>
            await ListAsync(filter?.AsListFilter(), cancellationToken);

        /// <inheritdoc />
        public virtual async Task<Checkout> CreateAsync(Checkout checkout, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri("checkouts.json");
            var body = checkout.ToDictionary();

            var response = await ExecuteRequestAsync<Checkout>(req, HttpMethod.Post, cancellationToken, new JsonContent(new { checkout }), "checkout");
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<Checkout> CompleteAsync(string token, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"checkouts/{token}/complete.json");

            var response = await ExecuteRequestAsync<Checkout>(req, HttpMethod.Post, cancellationToken, rootElement: "checkout");
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<Checkout> GetAsync(string token, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"checkouts/{token}.json");

            var response = await ExecuteRequestAsync<Checkout>(req, HttpMethod.Get, cancellationToken, rootElement: "checkout");
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<Checkout> UpdateAsync(string token, Checkout updatedCheckout, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"checkouts/{token}.json");

            var response = await ExecuteRequestAsync<Checkout>(req, HttpMethod.Put, cancellationToken, new JsonContent(new { checkout = updatedCheckout }), "checkout");
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<IEnumerable<CheckoutShippingRate>> ListShippingRatesAsync(string token, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"checkouts/{token}/shipping_rates.json");

            var response = await ExecuteRequestAsync<List<CheckoutShippingRate>>(req, HttpMethod.Get, cancellationToken, rootElement: "shipping_rates");
            return response.Result;
        }
    }
}