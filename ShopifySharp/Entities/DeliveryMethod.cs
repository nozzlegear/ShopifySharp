using Newtonsoft.Json;

namespace ShopifySharp
{
    public class DeliveryMethod
    {
        /// <summary>
        /// The ID of the delivery method.
        /// </summary>
        [JsonProperty("id")]
        public long? Id { get; set; }

        /// <summary>
        /// The type of delivery method. Valid values.
        /// <br>local: A delivery to a customer's doorstep</br>
        /// <br>none: No delivery method</br>
        /// <br>pick_up: A delivery that a customer picks up at your retail store, curbside, or any location that you choose</br>
        /// <br>retail: A delivery to a retail store</br>
        /// <br>shipping: A delivery to a customer using a shipping carrier</br>
        /// </summary>
        [JsonProperty("method_type")]
        public string MethodType { get; set; }
    }
}
