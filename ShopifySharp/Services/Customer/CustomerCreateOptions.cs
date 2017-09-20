using Newtonsoft.Json;

namespace ShopifySharp
{
    /// <summary>
    /// Options for creating a <see cref="Customer"/>.
    /// </summary>
    public class CustomerCreateOptions : CustomerUpdateOptions
    {
        /// <summary>
        /// Whether an email invite should be sent to the new customer. Default is null.
        /// </summary>
        [JsonProperty("send_email_invite")]
        public bool? SendEmailInvite { get; set; }

        /// <summary>
        /// Whether a welcome email should be sent to the new customer. Default is null.
        /// </summary>
        [JsonProperty("send_email_welcome")]
        public bool? SendWelcomeEmail { get; set; }
    }
}
