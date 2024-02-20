using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
	public class ShopifyPaymentsDisputeEvidenceFiles
	{
		[JsonProperty("cancellation_policy_file_id")]
		public long? CancellationPolicyFileId { get; set; }

		[JsonProperty("customer_communication_file_id")]
		public long? CustomerCommunicationFileId { get; set; }

		[JsonProperty("customer_signature_file_id")]
		public long? CustomerSignatureFileId { get; set; }

		[JsonProperty("refund_policy_file_id")]
		public long? RefundPolicyFileId { get; set; }

		[JsonProperty("service_documentation_file_id")]
		public long? ServiceDocumentationFileId { get; set; }

		[JsonProperty("shipping_documentation_file_id")]
		public long? ShippingDocumentationFileId { get; set; }

		[JsonProperty("uncategorized_file_id")]
		public long? UncategorizedFileId { get; set; }
	}
}
