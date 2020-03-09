using System;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify price rules.
    /// </summary>
    public class PriceRuleService : ShopifyService
    {
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public PriceRuleService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a list of up to 250 of the shop's price rules.
        /// </summary>
        public virtual async Task<ListResult<PriceRule>> ListAsync(ListFilter<PriceRule> filter, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync("price_rules.json", "price_rules", filter, cancellationToken: cancellationToken);
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's price rules.
        /// </summary>
        public virtual async Task<ListResult<PriceRule>> ListAsync(PriceRuleListFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ListAsync(filter?.AsListFilter(), cancellationToken);
        }
        
        // /// <summary>
        // /// Gets a list of up to 250 of the shop's price rules.
        // /// </summary>
        // public virtual async Task<IEnumerable<PriceRule>> ListAsync(IListFilter filter, CancellationToken cancellationToken = default)
        // {
        //     throw new Exception("not yet implemented");
        //     var req = PrepareRequest("price_rules.json");
        //
        //     if (options != null)
        //     {
        //         req.QueryParams.AddRange(options);
        //     }
        //
        //     return await ExecuteRequestAsync<List<PriceRule>>(req, HttpMethod.Get, rootElement: "price_rules", cancellationToken: cancellationToken);
        // }

        /// <summary>
        /// Retrieves the object with the given id.
        /// </summary>
        /// <param name="id">The id of the object to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<PriceRule> GetAsync(long id, string fields = null, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"price_rules/{id}.json");

            if (!string.IsNullOrEmpty(fields))
            {
                req.QueryParams.Add("fields", fields);
            }

            var response = await ExecuteRequestAsync<PriceRule>(req, HttpMethod.Get, rootElement: "price_rule", cancellationToken: cancellationToken);
            
            return response.Result;
        }

        /// <summary>
        /// Creates a new price rule.
        /// </summary>
        /// <param name="rule">A new price rule. Id should be set to null.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<PriceRule> CreateAsync(PriceRule rule, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest("price_rules.json");
            var body = rule.ToDictionary();
            var content = new JsonContent(new
            {
                price_rule = body
            });
            var response =  await ExecuteRequestAsync<PriceRule>(req, HttpMethod.Post, content, "price_rule", cancellationToken: cancellationToken);

            return response.Result;
        }

        /// <summary>
        /// Updates the given object.
        /// </summary>
        /// <param name="id">Id of the object being updated.</param>
        /// <param name="rule">The updated rule.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task<PriceRule> UpdateAsync(long id, PriceRule rule, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"price_rules/{id}.json");
            var content = new JsonContent(new
            {
                price_rule = rule
            });
            var response = await ExecuteRequestAsync<PriceRule>(req, HttpMethod.Put, content, "price_rule", cancellationToken: cancellationToken);

            return response.Result;
        }

        /// <summary>
        /// Deletes the object with the given Id.
        /// </summary>
        /// <param name="id">The object's Id.</param>
        /// <param name="cancellationToken">Cancellation Token</param>
        public virtual async Task DeleteAsync(long id, CancellationToken cancellationToken = default)
        {
            var req = PrepareRequest($"price_rules/{id}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken: cancellationToken);
        }
    }
}
