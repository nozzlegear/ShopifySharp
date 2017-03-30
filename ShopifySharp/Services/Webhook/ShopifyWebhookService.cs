using Newtonsoft.Json.Linq;
using RestSharp;
using ShopifySharp.Enums;
using ShopifySharp.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify webhooks.
    /// </summary>
    public class ShopifyWebhookService : ShopifyService
    {
        #region Constructor

        /// <summary>
        /// Creates a new instance of <see cref="ShopifyWebhookService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyWebhookService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        #endregion

        #region Public, non-static methods

        /// <summary>
        /// Gets a count of all of the shop's webhooks.
        /// </summary>
        /// <param name="address">An optional filter for the address property. When used, this method will only count webhooks with the given address.</param>
        /// <param name="topic">An optional filter for the topic property. When used, this method will only count webhooks with the given topic. A full list of topics can be found at https://help.shopify.com/api/reference/webhook. </param>
        /// <returns>The count of all webhooks for the shop.</returns>
        public virtual async Task<int> CountAsync(string address = null, string topic = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("webhooks/count.json", Method.GET);

            //Add optional parameters to request
            if (string.IsNullOrEmpty(address) == false) req.AddParameter("address", address);
            if (!string.IsNullOrEmpty(topic)) req.AddParameter("topic", topic);

            JToken responseObject = await RequestEngine.ExecuteRequestAsync(_RestClient, req);

            //Response looks like { "count" : 123 }. Does not warrant its own class.
            return responseObject.Value<int>("count");
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's webhooks.
        /// </summary>
        /// <param name="filter">Options for filtering the list.</param>
        /// <returns>The list of webhooks matching the filter.</returns>
        public virtual async Task<IEnumerable<Webhook>> ListAsync(ShopifyWebhookFilter filter = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("webhooks.json", Method.GET, "webhooks");

            //Add optional parameters to request
            if (filter != null) req.Parameters.AddRange(filter.ToParameters(ParameterType.GetOrPost));

            return await RequestEngine.ExecuteRequestAsync<List<Webhook>>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves the <see cref="Webhook"/> with the given id.
        /// </summary>
        /// <param name="webhookId">The id of the webhook to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="Webhook"/>.</returns>
        public virtual async Task<Webhook> GetAsync(long webhookId, string fields = null)
        {
            IRestRequest req = RequestEngine.CreateRequest($"webhooks/{webhookId}.json", Method.GET, "webhook");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<Webhook>(_RestClient, req);
        }

        /// <summary>
        /// Creates a new <see cref="Webhook"/> on the store.
        /// </summary>
        /// <param name="webhook">A new <see cref="Webhook"/>. Id should be set to null.</param>
        /// <returns>The new <see cref="Webhook"/>.</returns>
        public virtual async Task<Webhook> CreateAsync(Webhook webhook)
        {
            IRestRequest req = RequestEngine.CreateRequest("webhooks.json", Method.POST, "webhook");

            //Build the request body
            req.AddJsonBody(new { webhook });

            return await RequestEngine.ExecuteRequestAsync<Webhook>(_RestClient, req);
        }

        /// <summary>
        /// Updates the given <see cref="Webhook"/>. Id must not be null.
        /// </summary>
        /// <param name="webhook">The <see cref="Webhook"/> to update.</param>
        /// <returns>The updated <see cref="Webhook"/>.</returns>
        public virtual async Task<Webhook> UpdateAsync(Webhook webhook)
        {
            IRestRequest req = RequestEngine.CreateRequest($"webhooks/{webhook.Id.Value}.json", Method.PUT, "webhook");

            req.AddJsonBody(new { webhook });

            return await RequestEngine.ExecuteRequestAsync<Webhook>(_RestClient, req);
        }

        /// <summary>
        /// Deletes the webhook with the given Id.
        /// </summary>
        /// <param name="webhookId">The order object's Id.</param>
        public virtual async Task DeleteAsync(long webhookId)
        {
            IRestRequest req = RequestEngine.CreateRequest($"webhooks/{webhookId}.json", Method.DELETE);

            await RequestEngine.ExecuteRequestAsync(_RestClient, req);
        }

        #endregion
    }
}
