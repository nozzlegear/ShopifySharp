using Newtonsoft.Json;

namespace ShopifySharp
{
    /// <summary>
    /// Options for updating a <see cref="Customer"/>. 
    /// </summary>
    public class ShopifyCustomerUpdateOptions : Parameterizable
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
