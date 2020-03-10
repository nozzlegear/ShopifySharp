using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify gift cards.
    /// </summary>
    public class GiftCardService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="GiftCardService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public GiftCardService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken)
        {
        }

        public virtual async Task<int> CountAsync(GiftCardCountFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<int>($"gift_cards/count.json", "count", filter, cancellationToken);
        }
        
        /// <summary>
        /// Gets a list of up to 250 of the gift cards.
        /// </summary>
        /// <param name="filter">Options for filtering the list.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<ListResult<GiftCard>> ListAsync(ListFilter<GiftCard> filter, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync("gift_cards.json", "gift_cards", filter, cancellationToken);
        }

        /// <summary>
        /// Gets a list of up to 250 of the gift cards.
        /// </summary>
        /// <param name="filter">Options for filtering the list.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<ListResult<GiftCard>> ListAsync(GiftCardListFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ListAsync(filter?.AsListFilter(), cancellationToken);
        }

        /// <summary>
        /// Retrieves the <see cref="GiftCard"/> with the given id.
        /// </summary>
        /// <param name="giftCardId">The id of the GiftCard to retrieve.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="GiftCard"/>.</returns>
        public virtual async Task<GiftCard> GetAsync(long giftCardId, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<GiftCard>($"gift_cards/{giftCardId}.json", "gift_card", cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Creates a new <see cref="GiftCard"/>.
        /// </summary>
        /// <param name="giftCard">A new <see cref="GiftCard"/>. Id should be set to null.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The new <see cref="GiftCard"/>.</returns>
        public virtual async Task<GiftCard> CreateAsync(GiftCard giftCard, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest("gift_cards.json");
            var body = giftCard.ToDictionary();

            var content = new JsonContent(new
            {
                gift_card = body
            });

            var response = await ExecuteRequestAsync<GiftCard>(req, HttpMethod.Post, cancellationToken, content, "gift_card");
            return response.Result;
        }

        /// <summary>
        /// Updates the given <see cref="GiftCard"/>.
        /// </summary>
        /// <param name="giftCardId">Id of the object being updated.</param>
        /// <param name="giftCard">The <see cref="GiftCard"/> to update.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The updated <see cref="GiftCard"/>.</returns>
        public virtual async Task<GiftCard> UpdateAsync(long giftCardId, GiftCard giftCard, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"gift_cards/{giftCardId}.json");
            var content = new JsonContent(new
            {
                gift_card = giftCard
            });
            var response = await ExecuteRequestAsync<GiftCard>(req, HttpMethod.Put, cancellationToken, content, "gift_card");
            return response.Result;
        }
        
        /// <summary>
        /// Disables the <see cref="GiftCard"/> with the given id.
        /// </summary>
        /// <param name="giftCardId">The id of the GiftCard to disable.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        /// <returns>The <see cref="GiftCard"/>.</returns>
        public virtual async Task<GiftCard> DisableAsync(long giftCardId, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"gift_cards/{giftCardId}/disable.json");
            var response = await ExecuteRequestAsync<GiftCard>(req, HttpMethod.Post, cancellationToken, rootElement: "gift_card");
            return response.Result;
        }

        /// <summary>
        /// Search for gift cards matching supplied query
        /// </summary>
        /// <param name="filter">Options for searching and filtering the results.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<ListResult<GiftCard>> SearchAsync(GiftCardSearchFilter filter, CancellationToken cancellationToken = default)
        {
            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter));
            }
            
            var req = PrepareRequest("gift_cards/search.json");
            
            req.QueryParams.AddRange(filter.ToQueryParameters());
            
            var response = await ExecuteRequestAsync<List<GiftCard>>(req, HttpMethod.Get, cancellationToken, rootElement: "gift_cards");

            return ParseLinkHeaderToListResult(response);
        }
    }
}
