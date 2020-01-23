using System;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify webhooks.
    /// </summary>
    public class WebhookService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="WebhookService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public WebhookService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a count of all of the shop's webhooks.
        /// </summary>
        /// <param name="address">An optional filter for the address property. When used, this method will only count webhooks with the given address.</param>
        /// <param name="topic">An optional filter for the topic property. When used, this method will only count webhooks with the given topic. A full list of topics can be found at https://help.shopify.com/api/reference/webhook. </param>
        /// <returns>The count of all webhooks for the shop.</returns>
        public virtual async Task<int> CountAsync(string address = null, string topic = null)
        {
            var req = PrepareRequest("webhooks/count.json");

            if (!string.IsNullOrEmpty(address))
            {
                req.QueryParams.Add("address", address);
            }

            if (!string.IsNullOrEmpty(topic))
            {
                req.QueryParams.Add("topic", topic);
            }

            return await ExecuteRequestAsync<int>(req, HttpMethod.Get, rootElement: "count");
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's webhooks.
        /// </summary>
        /// <param name="filter">Options for filtering the list.</param>
        /// <returns>The list of webhooks matching the filter.</returns>
        public virtual async Task<IEnumerable<Webhook>> ListAsync(IListFilter filter)
        {
            throw new Exception("Not yet implemented");
            //
            // var req = PrepareRequest("webhooks.json");
            //
            // if (filter != null)
            // {
            //     req.QueryParams.AddRange(filter.ToParameters());
            // }
            //
            // return await ExecuteRequestAsync<List<Webhook>>(req, HttpMethod.Get, rootElement: "webhooks");
        }

        /// <summary>
        /// Retrieves the <see cref="Webhook"/> with the given id.
        /// </summary>
        /// <param name="webhookId">The id of the webhook to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="Webhook"/>.</returns>
        public virtual async Task<Webhook> GetAsync(long webhookId, string fields = null)
        {
            var req = PrepareRequest($"webhooks/{webhookId}.json");

            if (!string.IsNullOrEmpty(fields))
            {
                req.QueryParams.Add("fields", fields);
            }

            return await ExecuteRequestAsync<Webhook>(req, HttpMethod.Get, rootElement: "webhook");
        }

        /// <summary>
        /// Creates a new <see cref="Webhook"/> on the store.
        /// </summary>
        /// <param name="webhook">A new <see cref="Webhook"/>. Id should be set to null.</param>
        /// <returns>The new <see cref="Webhook"/>.</returns>
        public virtual async Task<Webhook> CreateAsync(Webhook webhook)
        {
            var req = PrepareRequest("webhooks.json");
            var content = new JsonContent(new
            {
                webhook = webhook
            });

            return await ExecuteRequestAsync<Webhook>(req, HttpMethod.Post, content, "webhook");
        }

        /// <summary>
        /// Updates the given <see cref="Webhook"/>.
        /// </summary>
        /// <param name="webhookId">Id of the object being updated.</param>
        /// <param name="webhook">The <see cref="Webhook"/> to update.</param>
        /// <returns>The updated <see cref="Webhook"/>.</returns>
        public virtual async Task<Webhook> UpdateAsync(long webhookId, Webhook webhook)
        {
            var req = PrepareRequest($"webhooks/{webhookId}.json");
            var content = new JsonContent(new
            {
                webhook = webhook
            });

            return await ExecuteRequestAsync<Webhook>(req, HttpMethod.Put, content, "webhook");
        }

        /// <summary>
        /// Deletes the webhook with the given Id.
        /// </summary>
        /// <param name="webhookId">The order object's Id.</param>
        public virtual async Task DeleteAsync(long webhookId)
        {
            var req = PrepareRequest($"webhooks/{webhookId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }
    }
}
