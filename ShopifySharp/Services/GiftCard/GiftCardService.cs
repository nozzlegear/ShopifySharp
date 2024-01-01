using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Utilities;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify gift cards.
    /// </summary>
    public class GiftCardService : ShopifyService, IGiftCardService
    {
        /// <summary>
        /// Creates a new instance of <see cref="GiftCardService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public GiftCardService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
        internal GiftCardService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
        /// <inheritdoc />
        public virtual async Task<int> CountAsync(GiftCardCountFilter filter = null, CancellationToken cancellationToken = default) =>
            await ExecuteGetAsync<int>($"gift_cards/count.json", "count", filter, cancellationToken);

        /// <inheritdoc />
        public virtual async Task<ListResult<GiftCard>> ListAsync(ListFilter<GiftCard> filter, CancellationToken cancellationToken = default) =>
            await ExecuteGetListAsync("gift_cards.json", "gift_cards", filter, cancellationToken);

        /// <inheritdoc />
        public virtual async Task<ListResult<GiftCard>> ListAsync(GiftCardListFilter filter = null, CancellationToken cancellationToken = default) =>
            await ListAsync(filter?.AsListFilter(), cancellationToken);

        public virtual async Task<ListResult<GiftCard>> SearchAsync(ListFilter<GiftCard> filter, CancellationToken cancellationToken = default) =>
            await ExecuteGetListAsync("gift_cards/search.json", "gift_cards", filter, cancellationToken);

        public virtual async Task<ListResult<GiftCard>> SearchAsync(GiftCardSearchFilter filter, CancellationToken cancellationToken = default) =>
            await SearchAsync(filter.AsListFilter(), cancellationToken);

        /// <inheritdoc />
        public virtual async Task<GiftCard> GetAsync(long giftCardId, CancellationToken cancellationToken = default) =>
            await ExecuteGetAsync<GiftCard>($"gift_cards/{giftCardId}.json", "gift_card", cancellationToken: cancellationToken);

        /// <inheritdoc />
        public virtual async Task<GiftCard> CreateAsync(GiftCard giftCard, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri("gift_cards.json");
            var body = giftCard.ToDictionary();

            var content = new JsonContent(new
            {
                gift_card = body
            });

            var response = await ExecuteRequestAsync<GiftCard>(req, HttpMethod.Post, cancellationToken, content, "gift_card");
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<GiftCard> UpdateAsync(long giftCardId, GiftCard giftCard, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"gift_cards/{giftCardId}.json");
            var content = new JsonContent(new
            {
                gift_card = giftCard
            });
            var response = await ExecuteRequestAsync<GiftCard>(req, HttpMethod.Put, cancellationToken, content, "gift_card");
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<GiftCard> DisableAsync(long giftCardId, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"gift_cards/{giftCardId}/disable.json");
            var response = await ExecuteRequestAsync<GiftCard>(req, HttpMethod.Post, cancellationToken, rootElement: "gift_card");
            return response.Result;
        }
    }
}