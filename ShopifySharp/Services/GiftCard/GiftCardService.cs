using System;
using System.Collections.Generic;
using System.Net.Http;
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

        private async Task<int> _CountAsync(ICountFilter filter = null)
        {
            var req = PrepareRequest($"gift_cards/count.json");

            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToQueryParameters());
            }

            var response = await ExecuteRequestAsync<int>(req, HttpMethod.Get, rootElement: "count");
            
            return response.Result;
        }
        
        /// <summary>
        /// Gets a count of all of the gift cards.
        /// </summary>
        public virtual async Task<int> CountAsync(ICountFilter filter = null)
        {
            return await _CountAsync(filter);
        }
        
        /// <summary>
        /// Gets a count of all of the gift cards.
        /// </summary>
        public virtual async Task<int> CountAsync(GiftCardCountFilter filter = null)
        {
            return await _CountAsync(filter);
        }

        /// <summary>
        /// Gets a list of up to 250 of the gift cards.
        /// </summary>
        /// <param name="filter">Options for filtering the list.</param>
        public virtual async Task<IListResult<GiftCard>> ListAsync(IListFilter<GiftCard> filter)
        {
            var req = PrepareRequest("gift_cards.json");
            
            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToQueryParameters());
            }
            
            var response = await ExecuteRequestAsync<List<GiftCard>>(req, HttpMethod.Get, rootElement: "gift_cards");

            return ParseLinkHeaderToListResult(response);
        }

        /// <summary>
        /// Gets a list of up to 250 of the gift cards.
        /// </summary>
        /// <param name="filter">Options for filtering the list.</param>
        public virtual async Task<IListResult<GiftCard>> ListAsync(GiftCardListFilter filter)
        {
            return await ListAsync((IListFilter<GiftCard>) filter);
        }

        /// <summary>
        /// Retrieves the <see cref="GiftCard"/> with the given id.
        /// </summary>
        /// <param name="giftCardId">The id of the GiftCard to retrieve.</param>
        /// <returns>The <see cref="GiftCard"/>.</returns>
        public virtual async Task<GiftCard> GetAsync(long giftCardId)
        {
            var req = PrepareRequest($"gift_cards/{giftCardId}.json");

            var response = await ExecuteRequestAsync<GiftCard>(req, HttpMethod.Get, rootElement: "gift_card");
            return response.Result;
        }

        /// <summary>
        /// Creates a new <see cref="GiftCard"/>.
        /// </summary>
        /// <param name="giftCard">A new <see cref="GiftCard"/>. Id should be set to null.</param>
        /// <returns>The new <see cref="GiftCard"/>.</returns>
        public virtual async Task<GiftCard> CreateAsync(GiftCard giftCard)
        {
            var req = PrepareRequest("gift_cards.json");
            var body = giftCard.ToDictionary();

            var content = new JsonContent(new
            {
                gift_card = body
            });

            var response = await ExecuteRequestAsync<GiftCard>(req, HttpMethod.Post, content, "gift_card");
            return response.Result;
        }

        /// <summary>
        /// Updates the given <see cref="GiftCard"/>.
        /// </summary>
        /// <param name="giftCardId">Id of the object being updated.</param>
        /// <param name="giftCard">The <see cref="GiftCard"/> to update.</param>
        /// <returns>The updated <see cref="GiftCard"/>.</returns>
        public virtual async Task<GiftCard> UpdateAsync(long giftCardId, GiftCard giftCard)
        {
            var req = PrepareRequest($"gift_cards/{giftCardId}.json");
            var content = new JsonContent(new
            {
                gift_card = giftCard
            });
            var response = await ExecuteRequestAsync<GiftCard>(req, HttpMethod.Put, content, "gift_card");
            return response.Result;
        }
        
        /// <summary>
        /// Disables the <see cref="GiftCard"/> with the given id.
        /// </summary>
        /// <param name="giftCardId">The id of the GiftCard to disable.</param>
        /// <returns>The <see cref="GiftCard"/>.</returns>
        public virtual async Task<GiftCard> DisableAsync(long giftCardId)
        {
            var req = PrepareRequest($"gift_cards/{giftCardId}/disable.json");
            var response = await ExecuteRequestAsync<GiftCard>(req, HttpMethod.Post, rootElement: "gift_card");
            return response.Result;
        }

        /// <summary>
        /// Search for gift cards matching supplied query
        /// </summary>
        /// <param name="filter">Options for searching and filtering the results.</param>
        public virtual async Task<IListResult<GiftCard>> SearchAsync(GiftCardSearchFilter filter)
        {
            if (filter == null)
            {
                throw new ArgumentNullException(nameof(filter));
            }
            
            var req = PrepareRequest("gift_cards/search.json");
            
            req.QueryParams.AddRange(filter.ToQueryParameters());
            
            var response = await ExecuteRequestAsync<List<GiftCard>>(req, HttpMethod.Get, rootElement: "gift_cards");

            return ParseLinkHeaderToListResult(response);
        }
    }
}
