using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    public class FulfillmentServiceListFilter : Parameterizable
    {
        /// <summary>
        /// <para>
        /// Restricts results to those with the given scope value. Known values:
        /// </para>
        /// <para>
        /// <c>"current_client"</c>: Returns fulfillment providers that have been created by the app sending the request (default)
        /// </para>
        /// <para>
        /// <c>"all"</c>: Returns all the fulfillment providers
        /// </para>
        /// </summary>
        [JsonProperty("scope")]
        public string Scope { get; set; }
    }
}