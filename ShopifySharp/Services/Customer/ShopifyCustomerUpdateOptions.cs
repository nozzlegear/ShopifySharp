using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ShopifySharp
{
    public class ShopifyCustomerUpdateOptions
    {
        /// <summary>
        /// An optional password for the user. Default is null.
        /// </summary>
        [JsonProperty("password")]
        public string Password { get; set; }

        /// <summary>
        /// Should be set and match <see cref="Password"/>. Default is null.
        /// </summary>
        [JsonProperty("password_confirmation")]
        public string PasswordConfirmation { get; set; }
    }
}
