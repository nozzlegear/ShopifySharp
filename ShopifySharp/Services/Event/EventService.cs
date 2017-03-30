using Newtonsoft.Json.Linq;
using RestSharp;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for getting Shopify Events
    /// Reference: https://help.shopify.com/api/reference/event
    /// </summary>
    public class EventService : ShopifyService
    {
        #region Constructor

        /// <summary>
        /// Creates a new instance of <see cref="EventService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public EventService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        #endregion

        #region Public, non-static methods

        /// <summary>
        /// Gets a count of all site events.
        /// </summary>
        /// <param name="filter">Supports CreatedAtMin and CreatedAtMax Properties</param>
        /// <returns>The count of all site events.</returns>
        public virtual async Task<int> CountAsync(CountFilter filter = null)
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
        public virtual async Task<ShopifyEvent> GetAsync(long eventId, string fields = null)
        {
            IRestRequest req = RequestEngine.CreateRequest($"events/{eventId}.json", Method.GET, "event");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<ShopifyEvent>(_RestClient, req);
        }

        /// <summary>
        /// Returns a list of events for the given subject and subject type. A full list of supported subject types can be found at https://help.shopify.com/api/reference/event
        /// </summary>
        /// <param name="options">Options for filtering the result.</param>
        /// <param name="subjectId">Restricts results to just one subject item, e.g. all changes on a product.</param>
        /// <param name="subjectType">The subject's type, e.g. 'Order' or 'Product'. Known subject types are 'Articles', 'Blogs', 'Custom_Collections', 'Comments', 'Orders', 'Pages', 'Products' and 'Smart_Collections'.  A current list of subject types can be found at https://help.shopify.com/api/reference/event </param>
        public virtual async Task<IEnumerable<ShopifyEvent>> ListAsync(long subjectId, string subjectType, EventListFilter options = null)
        {
            // Ensure the subject type is plural
            if (! subjectType.Substring(subjectType.Length - 1).Equals("s", System.StringComparison.OrdinalIgnoreCase))
            {
                subjectType = subjectType + "s";
            }

            var req = RequestEngine.CreateRequest($"{subjectType?.ToLower()}/{subjectId}/events.json", Method.GET, "events");

            //Add optional parameters to request
            if (options != null)
            {
                req.Parameters.AddRange(options.ToParameters(ParameterType.GetOrPost));
            }

            return await RequestEngine.ExecuteRequestAsync<List<ShopifyEvent>>(_RestClient, req);
        }

        /// <summary>
        /// Returns a list of events.
        /// </summary>
        /// <param name="options">Options for filtering the result.</param>
        public virtual async Task<IEnumerable<ShopifyEvent>> ListAsync(EventListFilter options = null)
        {
            var req = RequestEngine.CreateRequest("events.json", Method.GET, "events");
            
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
