using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;

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

        /// <summary>
        /// Gets a count of all of the gift cards.
        /// </summary>
        /// <param name="status">The status of gift card to retrieve. Known values are "enabled", "disabled".</param>
        /// <returns>The count of all fulfillments for the shop.</returns>
        public virtual async Task<int> CountAsync(string status = null)
        {
            var req = PrepareRequest($"gift_cards/count.json");

            if (status != null)
            {
                req.QueryParams.Add("status", status);
            }

            return await ExecuteRequestAsync<int>(req, HttpMethod.Get, rootElement: "count");
        }

        /// <summary>
        /// Gets a list of up to 250 of the gift cards.
        /// </summary>
        /// <param name="options">Options for filtering the list.</param>
        /// <returns>The list of gift cards matching the filter.</returns>
        [Obsolete("This ListAsync method targets a version of Shopify's API which will be deprecated and cease to function in April of 2020. ShopifySharp version 5.0 has been published with support for the newer list API. Make sure you update before April of 2020.")]
        public virtual async Task<IEnumerable<GiftCard>> ListAsync(GiftCardFilter options = null)
        {
            var req = PrepareRequest("gift_cards.json");

            if (options != null)
            {
                req.QueryParams.AddRange(options.ToParameters());
            }

            return await ExecuteRequestAsync<List<GiftCard>>(req, HttpMethod.Get, rootElement: "gift_cards");
        }

        /// <summary>
        /// Retrieves the <see cref="GiftCard"/> with the given id.
        /// </summary>
        /// <param name="giftCardId">The id of the GiftCard to retrieve.</param>
        /// <returns>The <see cref="GiftCard"/>.</returns>
        public virtual async Task<GiftCard> GetAsync(long giftCardId)
        {
            var req = PrepareRequest($"gift_cards/{giftCardId}.json");

            return await ExecuteRequestAsync<GiftCard>(req, HttpMethod.Get, rootElement: "gift_card");
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

            return await ExecuteRequestAsync<GiftCard>(req, HttpMethod.Post, content, "gift_card");
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

            return await ExecuteRequestAsync<GiftCard>(req, HttpMethod.Put, content, "gift_card");
        }
        /// <summary>
        /// Disables the <see cref="GiftCard"/> with the given id.
        /// </summary>
        /// <param name="giftCardId">The id of the GiftCard to disable.</param>
        /// <returns>The <see cref="GiftCard"/>.</returns>
        public virtual async Task<GiftCard> DisableAsync(long giftCardId)
        {
            var req = PrepareRequest($"gift_cards/{giftCardId}/disable.json");

            return await ExecuteRequestAsync<GiftCard>(req, HttpMethod.Post, rootElement: "gift_card");
        }

        /// <summary>
        /// Search for gift cards matching supplied query
        /// </summary>
        /// <param name="query">The (unencoded) search query, in format of 'Bob country:United States', which would search for customers in the United States with a name like 'Bob'.</param>
        /// <param name="order">An (unencoded) optional string to order the results, in format of 'field_name DESC'. Default is 'last_order_date DESC'.</param>
        /// <param name="filter">Options for filtering the results.</param>
        /// <returns>A list of matching gift cards.</returns>
        public virtual async Task<IEnumerable<GiftCard>> SearchAsync(string query, string order = null, ListFilter filter = null)
        {
            var req = PrepareRequest("gift_cards/search.json");
            req.QueryParams.Add("query", query);

            if (!string.IsNullOrEmpty(order))
            {
                req.QueryParams.Add("order", order);
            }

            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToParameters());
            }

            return await ExecuteRequestAsync<List<GiftCard>>(req, HttpMethod.Get, rootElement: "gift_cards");
        }
    }
}
