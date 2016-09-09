using Newtonsoft.Json.Linq;
using RestSharp;
using ShopifySharp.Converters;
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
        /// Gets the site events.
        /// </summary>
        /// <returns>Site events.</returns>
        public async Task<IEnumerable<ShopifyEvent>> ListAsync(ShopifyEventListFilter options = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("events.json", Method.GET, "events");

            //Add optional parameters to request
            if (options != null)
            {
                req.Parameters.AddRange(options.ToParameters(ParameterType.GetOrPost));
                if (options.Filters != null && options.Filters.Any())
                {
                    req.AddParameter("filters", EnumListToString(options.Filters));
                }
                if (options.Verbs != null && options.Verbs.Any())
                {
                    req.AddParameter("verbs", EnumListToString(options.Verbs));
                }
            }

            return await RequestEngine.ExecuteRequestAsync<List<ShopifyEvent>>(_RestClient, req);
        }
        #endregion

        private string EnumListToString<T>(IEnumerable<T> enumList)
        {
            var list = new List<string>();

            if (enumList != null && enumList.Any())
            {
                var enumType = typeof(T);

                foreach (var enumItem in enumList)
                {
                    FieldInfo fi = enumItem.GetType().GetField(enumItem.ToString());

                    EnumMemberAttribute[] attributes = (EnumMemberAttribute[])fi.GetCustomAttributes(
                        typeof(EnumMemberAttribute), false);

                    if (attributes != null && attributes.Length > 0)
                    {
                        list.Add(attributes[0].Value);
                    }
                    else
                    {
                        list.Add(enumItem.ToString());
                    }
                }
            }
            return string.Join(",", list);
        }
    }
}
