using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify discount codes.
    /// </summary>
    public class DiscountCodeService : ShopifyService, IDiscountCodeService
    {
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public DiscountCodeService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <inheritdoc />
        public virtual async Task<ListResult<PriceRuleDiscountCode>> ListAsync(long priceRuleId, ListFilter<PriceRuleDiscountCode> filter, CancellationToken cancellationToken = default) =>
			await ExecuteGetListAsync($"price_rules/{priceRuleId}/discount_codes.json", "discount_codes", filter, cancellationToken);

        /// <inheritdoc />
        public virtual async Task<ListResult<PriceRuleDiscountCode>> ListAsync(long priceRuleId, PriceRuleDiscountCodeListFilter filter = null, CancellationToken cancellationToken = default) =>
			await ListAsync(priceRuleId, filter?.AsListFilter(), cancellationToken);

        /// <inheritdoc />
        public virtual async Task<PriceRuleDiscountCode> GetAsync(long priceRuleId, long discountId, string fields = null, CancellationToken cancellationToken = default) =>
			await ExecuteGetAsync<PriceRuleDiscountCode>($"price_rules/{priceRuleId}/discount_codes/{discountId}.json", "discount_code", fields, cancellationToken);

        /// <inheritdoc />
        public virtual async Task<PriceRuleDiscountCode> GetAsync(PriceRuleDiscountCodeFilter filter, CancellationToken cancellationToken = default) =>
			await ExecuteGetAsync<PriceRuleDiscountCode>($"discount_codes/lookup.json", "discount_code", queryParams: filter, cancellationToken);

        /// <inheritdoc />
        public virtual async Task<PriceRuleDiscountCode> GetAsync(string code, CancellationToken cancellationToken = default)
        {
            var filter = new PriceRuleDiscountCodeFilter
            {
                Code = code
            };

            return await GetAsync(filter, cancellationToken);
        }

        /// <inheritdoc />
        public virtual async Task<PriceRuleDiscountCode> CreateAsync(long priceRuleId, PriceRuleDiscountCode code, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"price_rules/{priceRuleId}/discount_codes.json");
            var body = code.ToDictionary();

            var content = new JsonContent(new
            {
                discount_code = body
            });

            var response = await ExecuteRequestAsync<PriceRuleDiscountCode>(req, HttpMethod.Post, cancellationToken, content, "discount_code");
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<PriceRuleDiscountCode> UpdateAsync(long priceRuleId, PriceRuleDiscountCode code, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"price_rules/{priceRuleId}/discount_codes/{code.Id.Value}.json");
            var content = new JsonContent(new
            {
                discount_code = code
            });

            var response = await ExecuteRequestAsync<PriceRuleDiscountCode>(req, HttpMethod.Put, cancellationToken, content, "discount_code");
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task DeleteAsync(long priceRuleId, long discountCodeId, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"price_rules/{priceRuleId}/discount_codes/{discountCodeId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
        }
    }
}