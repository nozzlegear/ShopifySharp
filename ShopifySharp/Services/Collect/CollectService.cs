using Newtonsoft.Json.Linq;
using System.Net.Http;
using ShopifySharp.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating mapping between shopify products and collections
    /// </summary>
    public class CollectService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="CustomerService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CollectService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a count of all of the collects (product-collection mappings).
        /// </summary>
        /// <returns>The count of all collects for the shop.</returns>
        public virtual async Task<int> CountAsync(CollectFilter filter = null)
        {
            var req = PrepareRequest("collects/count.json");

            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToParameters());
            }

            return await ExecuteRequestAsync<int>(req, HttpMethod.Get, rootElement: "count");
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's collects.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IEnumerable<Collect>> ListAsync(IListFilter filter)
        {
            throw new Exception("not yet implemented");
            var req = PrepareRequest("collects.json");

            if (options != null)
            {
                req.QueryParams.AddRange(options.ToParameters());
            }

            return await ExecuteRequestAsync<List<Collect>>(req, HttpMethod.Get, rootElement: "collects");
        }

        /// <summary>
        /// Retrieves the <see cref="Collect"/> with the given id.
        /// </summary>
        /// <param name="collectId">The id of the collect to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="Collect"/>.</returns>
        public virtual async Task<Collect> GetAsync(long collectId, string fields = null)
        {
            var req = PrepareRequest($"collects/{collectId}.json");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.QueryParams.Add("fields", fields);
            }

            return await ExecuteRequestAsync<Collect>(req, HttpMethod.Get, rootElement: "collect");
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

            return await ExecuteRequestAsync<Collect>(req, HttpMethod.Post, content, "collect");
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
