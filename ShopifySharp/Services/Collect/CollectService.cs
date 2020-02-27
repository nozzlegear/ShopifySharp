using Newtonsoft.Json.Linq;
using System.Net.Http;
using ShopifySharp.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating mapping between Shopify products and collections.
    /// </summary>
    public class CollectService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="CustomerService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CollectService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        public virtual async Task<int> CountAsync(CollectCountFilter filter = null)
        {
            return await ExecuteGetAsync<int>("collects/count.json", "count", filter);
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's collects.
        /// </summary>
        public virtual async Task<ListResult<Collect>> ListAsync(ListFilter<Collect> filter)
        {
            return await ExecuteGetListAsync("collects.json", "collects", filter);
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's collects.
        /// </summary>
        public virtual async Task<ListResult<Collect>> ListAsync(CollectListFilter filter = null)
        {
            return await ListAsync(filter?.AsListFilter());
        }

        /// <summary>
        /// Retrieves the <see cref="Collect"/> with the given id.
        /// </summary>
        /// <param name="collectId">The id of the collect to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="Collect"/>.</returns>
        public virtual async Task<Collect> GetAsync(long collectId, string fields = null)
        {
            return await ExecuteGetAsync<Collect>($"collects/{collectId}.json", "collect", fields);
        }


        /// <summary>
        /// Creates a new <see cref="Collect"/> on the store. Map product to collection
        /// </summary>
        /// <param name="collect">A new <see cref="Collect"/>. Id should be set to null.</param>
        /// <returns>The new <see cref="Collect"/>.</returns>
        public virtual async Task<Collect> CreateAsync(Collect collect)
        {
            var req = PrepareRequest("collects.json");
            var content = new JsonContent(new
            {
                collect = collect
            });

            var response = await ExecuteRequestAsync<Collect>(req, HttpMethod.Post, content, "collect");
            return response.Result;
        }

        /// <summary>
        /// Deletes a collect with the given Id.
        /// </summary>
        /// <param name="collectId">The product object's Id.</param>
        public virtual async Task DeleteAsync(long collectId)
        {
            var req = PrepareRequest($"collects/{collectId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }
    }
}
