using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
	public class ShopifyPaymentsDisputeEvidenceFulfillment 
	{
		[JsonProperty("shipping_carrier")]
		public string ShippingCarrier { get; set; }

		[JsonProperty("shipping_tracking_number")]
		public long? ShippingTrackingNumber { get; set; }

		[JsonProperty("shipping_date")]
		public DateTimeOffset? ShippingDate { get; set; }
	}
}
