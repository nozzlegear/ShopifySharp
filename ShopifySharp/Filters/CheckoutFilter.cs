using Newtonsoft.Json;

namespace ShopifySharp.Filters
{
    /// <summary>
    /// Options for filtering <see cref="CheckoutService.CountAsync(CheckoutFilter)"/> and 
    /// <see cref="CheckoutService.ListAsync(CheckoutFilter)"/> results.
    /// </summary>
    public class CheckoutFilter : ListFilter
    {
        /// <summary>
        /// An optional, parameter to determine which carts to retrieve.
        /// open - All open abandoned checkouts (default)
        /// closed - Show only closed abandoned checkouts
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
