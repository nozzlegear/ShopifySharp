using System.Collections.Generic;
using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    public class AssignedFulfillmentOrderFilter : ListFilter<AssignedFulfillmentOrder>
    {
        /// <summary>
        /// <para>
        /// The assignment status of the fulfillment orders that should be returned:
        /// </para>
        /// <para>
        /// <c>"fulfillment_unsubmitted"</c>: Fulfillment orders for which the merchant hasn't yet requested fulfillment. Filtering by this value is supported as of the 2023-04 API version.
        /// <c>"cancellation_requested"</c>: Fulfillment orders for which the merchant has requested cancellation of the previously accepted fulfillment request.
        /// </para>
        /// <para>
        /// <c>"fulfillment_requested"</c>: Fulfillment orders for which the merchant has requested fulfillment.
        /// </para>
        /// <para>
        /// <c>"fulfillment_accepted"</c>: Fulfillment orders for which the merchant's fulfillment request has been accepted. Any number of fulfillments can be created on these fulfillment orders to completely fulfill the requested items.
        /// </para>
        /// </summary>
        [JsonProperty("assignment_status")]
        public string AssignmentStatus { get; set; }

        /// <summary>
        /// The IDs of the assigned locations of the fulfillment orders that should be returned.
        /// </summary>
        [JsonProperty("location_ids[]")]
        public IEnumerable<long> LocationIds { get; set; }
    }
}