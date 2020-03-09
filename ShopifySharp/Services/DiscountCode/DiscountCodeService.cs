using System;
using System.Net.Http;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify discount codes.
    /// </summary>
    public class DiscountCodeService : ShopifyService
    {
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public DiscountCodeService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of up to 250 of the discount codes belonging to the price rule.
        /// </summary>
        public virtual async Task<ListResult<PriceRuleDiscountCode>> ListAsync(long priceRuleId, ListFilter<PriceRuleDiscountCode> filter, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync($"price_rules/{priceRuleId}/discount_codes.json", "discount_codes", filter, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Gets a list of up to 250 of the discount codes belonging to the price rule.
        /// </summary>
        public virtual async Task<ListResult<PriceRuleDiscountCode>> ListAsync(long priceRuleId, PriceRuleDiscountCodeListFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ListAsync(priceRuleId, filter?.AsListFilter(), cancellationToken);
        }

        /// <summary>
        /// Retrieves the <see cref="PriceRuleDiscountCode"/> with the given id.
        /// </summary>
        /// <param name="priceRuleId">The id of the associated price rule.</param>
        /// <param name="discountId">The id of the discount to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="PriceRuleDiscountCode"/>.</returns>
        public virtual async Task<PriceRuleDiscountCode> GetAsync(long priceRuleId, long discountId, string fields = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<PriceRuleDiscountCode>($"price_rules/{priceRuleId}/discount_codes/{discountId}.json", "discount_code", fields, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Creates a new discount code.
        /// </summary>
        /// <param name="priceRuleId">Id of an existing price rule.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<PriceRuleDiscountCode> CreateAsync(long priceRuleId, PriceRuleDiscountCode code, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"price_rules/{priceRuleId}/discount_codes.json");
            var body = code.ToDictionary();

            var content = new JsonContent(new
            {
                discount_code = body
            });

            var response = await ExecuteRequestAsync<PriceRuleDiscountCode>(req, HttpMethod.Post, content, "discount_code", cancellationToken: cancellationToken);
            return response.Result;
        }

        /// <summary>
        /// Updates the given object.
        /// </summary>
        /// <param name="priceRuleId">The Id of the Price Rule being updated.</param>
        /// <param name="code">The code being updated.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<PriceRuleDiscountCode> UpdateAsync(long priceRuleId, PriceRuleDiscountCode code, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"price_rules/{priceRuleId}/discount_codes/{code.Id.Value}.json");
            var content = new JsonContent(new
            {
                discount_code = code
            });

            var response = await ExecuteRequestAsync<PriceRuleDiscountCode>(req, HttpMethod.Put, content, "discount_code", cancellationToken: cancellationToken);
            return response.Result;
        }

        /// <summary>
        /// Removes the discount with the specified Id.
        /// </summary>
        /// /// <param name="priceRuleId">The price rule object's Id.</param>
        /// <param name="discountId">The discount object's Id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task DeleteAsync(long priceRuleId, long discountCodeId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"price_rules/{priceRuleId}/discount_codes/{discountCodeId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken: cancellationToken);
        }
    }
}
