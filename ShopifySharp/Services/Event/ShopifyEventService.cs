using Newtonsoft.Json.Linq;
using RestSharp;
using ShopifySharp.Converters;
using ShopifySharp.Enums;
using ShopifySharp.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for getting Shopify Events
    /// Reference: https://help.shopify.com/api/reference/event
    /// </summary>
    public class ShopifyEventService : ShopifyService
    {

        #region Constructor

        /// <summary>
        /// Creates a new instance of <see cref="ShopifyEventService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyEventService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        #endregion

        #region Public, non-static methods

        /// <summary>
        /// Gets a count of all site events.
        /// </summary>
        /// <returns>The count of all site events.</returns>
        public async Task<int> CountAsync(ShopifyEventCountFilter filter = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("events/count.json", Method.GET);

            //Add optional parameters to request
            if (filter != null) req.Parameters.AddRange(filter.ToParameters(ParameterType.GetOrPost));

            JToken responseObject = await RequestEngine.ExecuteRequestAsync(_RestClient, req);

            //Response looks like { "count" : 123 }. Does not warrant its own class.
            return responseObject.Value<int>("count");
        }

        /// <summary>
        /// Retrieves the <see cref="ShopifyEvent"/> with the given id.
        /// </summary>
        /// <param name="eventId">The id of the event to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="ShopifyEvent"/>.</returns>
        public async Task<ShopifyEvent> GetAsync(long eventId, string fields = null)
        {
            IRestRequest req = RequestEngine.CreateRequest($"events/{eventId}.json", Method.GET, "event");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<ShopifyEvent>(_RestClient, req);
        }

        /// <summary>
        /// Returns a list of Events
        /// </summary>
        /// <param name="options">(optional) Filters</param>
        /// <returns></returns>
        public async Task<IEnumerable<ShopifyEvent>> ListAsync(ShopifyEventListFilter options = null)
        {
            return await ListAsync(options, null, null);
        }

        /*
         * I have implemented the API as best as I can but this method keeps returning nothing
        /// <summary>
        /// Returns a list of Events on a paticular item eg. all events on a product
        /// </summary>
        /// <param name="subjectType">Resticts resluts to just one subject type</param>
        /// <param name="subjectId">Restics results to just one subject id</param>
        /// <param name="options">(optional) Filters</param>
        /// <returns></returns>
        public async Task<IEnumerable<ShopifyEvent>> ListAsync(string subjectType, long subjectId, ShopifyEventListFilter options = null)
        {
            return await ListAsync(options, subjectType, subjectId);
        }
        */

        /// <summary>
        /// Returns a list of Events
        /// </summary>
        /// <param name="options">(optional) Filters</param>
        /// <param name="subjectType">(optional) Resticts resluts to just one subject type</param>
        /// <param name="subjectId">(optional) Restics results to just one subject item eg.all changes on a product (subjectType must not be null for this to work)</param>
        /// <returns></returns>
        private async Task<IEnumerable<ShopifyEvent>> ListAsync(ShopifyEventListFilter options = null, string subjectType = null, long? subjectId = null)
        {
            IRestRequest req;
            if (subjectType == null)
            {
                req = RequestEngine.CreateRequest("events.json", Method.GET, "events");
            }
            else
            {
                // As noted above this is currently always returing nothing I am unsure why
                var subjectTypeName = subjectType.ToLower();
                req = RequestEngine.CreateRequest(string.Format("{0}s/#{1}/events.json", subjectTypeName, subjectId), Method.GET, "events");
            }

            //Add optional parameters to request
            if (options != null)
            {
                req.Parameters.AddRange(options.ToParameters(ParameterType.GetOrPost));
            }

            return await RequestEngine.ExecuteRequestAsync<List<ShopifyEvent>>(_RestClient, req);
        }
        #endregion
    }
}
