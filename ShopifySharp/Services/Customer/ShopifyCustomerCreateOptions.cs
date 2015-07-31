using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class ShopifyCustomerCreateOptions : Parameterizable
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

        /// <summary>
        /// An optional password for the user. Default is null.
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// Should match <see cref="Password"/>. Documentation is unclear as to whether this field is actually required when setting <see cref="Password"/>. Default is null.
        /// </summary>
        [JsonProperty("password_confirmation")]
        public string PasswordConfirmation { get; set; }
    }
}
