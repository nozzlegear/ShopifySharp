using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
	/// <summary>
	/// An object representing a Shopify payment dispute evidence.
	/// </summary>
	public class ShopifyPaymentsDisputeEvidence : ShopifyObject
	{
		[JsonProperty("payments_dispute_id")]
		public long? PaymentsDisputeId { get; set; }

		[JsonProperty("access_activity_log")]
		public string AccessActivityLog { get; set; }

		[JsonProperty("customer_email_address")]
		public string CustomerEmailAddress { get; set; }

		[JsonProperty("customer_first_name")]
		public string CustomerFirstName { get; set; }

		[JsonProperty("customer_last_name")]
		public string CustomerLastName { get; set; }

		[JsonProperty("uncategorized_text")]
		public string UncategorizedText { get; set; }

		[JsonProperty("shipping_address")]
		public ShopifyPaymentsDisputeEvidenceAddress ShippingAddress { get; set; }

		[JsonProperty("cancellation_policy_disclosure")]
		public string CancellationPolicyDisclosure { get; set; }

		[JsonProperty("cancellation_rebuttal")]
		public string CancellationRebuttal { get; set; }

		[JsonProperty("refund_policy_disclosure")]
		public string RefundPolicyDisclosure { get; set; }

		[JsonProperty("refund_refusal_explanation")]
		public string RefundRefusalExplanation { get; set; }

		[JsonProperty("submitted")]
		public bool? Submitted { get; set; }

		[JsonProperty("product_description")]
		public ShopifyPaymentsDisputeEvidenceProductDescription ProductDescription { get; set; }

		[JsonProperty("created_at")]
		public DateTimeOffset? CreatedAt { get; set; }

		[JsonProperty("updated_on")]
		public DateTimeOffset? UpdatedOn { get; set; }

		[JsonProperty("dispute_evidence_files")]
		public ShopifyPaymentsDisputeEvidenceFiles DisputeEvidenceFiles { get; set; }

		[JsonProperty("billing_address")]
		public ShopifyPaymentsDisputeEvidenceAddress BillingAddress { get; set; }

		[JsonProperty("fulfillments")]
		public ShopifyPaymentsDisputeEvidenceFulfillment[] Fulfillments { get; set; }
	}
}
