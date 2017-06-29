using Newtonsoft.Json.Linq;
using RestSharp;
using ShopifySharp.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify discounts.
    /// </summary>
    public class ShopifyDiscountService : ShopifyService
    {
        #region Constructor
        /// <summary>
        /// Creates a new instance of <see cref="ShopifyDiscountService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyDiscountService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
        #endregion

        #region Public, non-static methods
        /// <summary>
        /// Gets a list of up to 250 of the shop's discounts.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IEnumerable<ShopifyDiscount>> ListAsync()
        {
            IRestRequest req = RequestEngine.CreateRequest("discounts.json", Method.GET, "discount");

            return await RequestEngine.ExecuteRequestAsync<List<ShopifyDiscount>>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves the <see cref="ShopifyDiscount"/> with the given id.
        /// </summary>
        /// <param name="discountId">The id of the discount to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="ShopifyDiscount"/>.</returns>
        public virtual async Task<ShopifyDiscount> GetAsync(long discountId, string fields = null)
        {
            IRestRequest req = RequestEngine.CreateRequest($"discounts/{discountId}.json", Method.GET, "discount");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<ShopifyDiscount>(_RestClient, req);
        }

        /// <summary>
        /// Creates a new <see cref="ShopifyDiscount"/> on the store.
        /// </summary>
        /// <param name="discount">A new <see cref="ShopifyDiscount"/>. Id should be set to null.</param>
        /// <returns>The new <see cref="ShopifyDiscount"/>.</returns>
        public virtual async Task<ShopifyDiscount> CreateAsync(ShopifyDiscount discount)
        {
            IRestRequest req = RequestEngine.CreateRequest("discounts.json", Method.POST, "discount");

            // Build the request body as a dictionary. Necessary because the create options must be added to the 
            // 'discount' property.
            var discountBody = discount.ToDictionary();

            var requestBody = new { discount = discountBody };

            req.AddJsonBody(requestBody);

            return await RequestEngine.ExecuteRequestAsync<ShopifyDiscount>(_RestClient, req);
        }

        /// <summary>
        /// Enables the <see cref="ShopifyDiscount"/> with the Id specified.
        /// </summary>
        /// <param name="discountId">The Id of the <see cref="ShopifyDiscount"/> to be enabled.</param>
        /// <returns>The updated <see cref="ShopifyDiscount"/>.</returns>
        public virtual async Task<ShopifyDiscount> EnableAsync(long discountId)
        {
            IRestRequest req = RequestEngine.CreateRequest($"discounts/{discountId}/enable.json", Method.PUT, "discount");

            return await RequestEngine.ExecuteRequestAsync<ShopifyDiscount>(_RestClient, req);
        }

        /// <summary>
        /// Disables the <see cref="ShopifyDiscount"/> with the Id specified.
        /// </summary>
        /// <param name="discountId">The Id of the <see cref="ShopifyDiscount"/> to be disabled.</param>
        /// <returns>The updated <see cref="ShopifyDiscount"/>.</returns>
        public virtual async Task<ShopifyDiscount> DisableAsync(long discountId)
        {
            IRestRequest req = RequestEngine.CreateRequest($"discounts/{discountId}/disable.json", Method.PUT, "discount");

            return await RequestEngine.ExecuteRequestAsync<ShopifyDiscount>(_RestClient, req);
        }

        /// <summary>
        /// Removes the discount with the specified Id.
        /// </summary>
        /// <param name="discountId">The discount object's Id.</param>
        public virtual async Task DeleteAsync(long discountId)
        {
            IRestRequest req = RequestEngine.CreateRequest($"discounts/{discountId}.json", Method.DELETE);

            await RequestEngine.ExecuteRequestAsync(_RestClient, req);
        }
        #endregion
    }
}
