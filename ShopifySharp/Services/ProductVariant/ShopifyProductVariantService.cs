using RestSharp;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating a Shopify product's variants.
    /// </summary>
    public class ShopifyProductVariantService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ShopifyProductVariantService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyProductVariantService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a count of all variants belonging to the given product.
        /// </summary>
        /// <param name="productId">The product that the variants belong to.</param>
        public virtual async Task<int> CountAsync(long productId)
        {
            var req = RequestEngine.CreateRequest($"products/{productId}/variants/count.json", Method.GET, "count");            

            return await RequestEngine.ExecuteRequestAsync<int>(_RestClient, req);
        }

        /// <summary>
        /// Gets a list of variants belonging to the given product.
        /// </summary>
        /// <param name="productId">The product that the variants belong to.</param>
        /// <param name="filterOptions">Options for filtering the result.</param>
        public virtual async Task<IEnumerable<ProductVariant>> ListAsync(long productId, ShopifyListFilter filterOptions = null)
        {
            var req = RequestEngine.CreateRequest($"products/{productId}/variants.json", Method.GET, "variants");

            if (filterOptions != null)
            {
                req.Parameters.AddRange(filterOptions.ToParameters(ParameterType.GetOrPost));
            }
            
            return await RequestEngine.ExecuteRequestAsync<List<ProductVariant>>(_RestClient, req);
        }
        
        /// <summary>
        /// Retrieves the <see cref="ProductVariant"/> with the given id.
        /// </summary>
        /// <param name="variantId">The id of the product variant to retrieve.</param>
        public virtual async Task<ProductVariant> GetAsync(long variantId)
        {
            var req = RequestEngine.CreateRequest($"variants/{variantId}.json", Method.GET, "variant");
            
            return await RequestEngine.ExecuteRequestAsync<ProductVariant>(_RestClient, req);
        }
        
        /// <summary>
        /// Creates a new <see cref="ProductVariant"/>.
        /// </summary>
        /// <param name="productId">The product that the new variant will belong to.</param>
        /// <param name="variant">A new <see cref="ProductVariant"/>. Id should be set to null.</param>
        public virtual async Task<ProductVariant> CreateAsync(long productId, ProductVariant variant)
        {
            var req = RequestEngine.CreateRequest($"products/{productId}/variants.json", Method.POST, "variant");

            req.AddJsonBody(new { variant });
            
            return await RequestEngine.ExecuteRequestAsync<ProductVariant>(_RestClient, req);
        }

        /// <summary>
        /// Updates the given <see cref="ProductVariant"/>. Id must not be null.
        /// </summary>
        /// <param name="variant">The variant to update.</param>
        public virtual async Task<ProductVariant> UpdateAsync(ProductVariant variant)
        {
            var req = RequestEngine.CreateRequest($"variants/{variant.Id.Value}.json", Method.PUT, "variant");

            req.AddJsonBody(new { variant });

            return await RequestEngine.ExecuteRequestAsync<ProductVariant>(_RestClient, req);
        }

        /// <summary>
        /// Deletes a product variant with the given Id.
        /// </summary>
        /// <param name="productId">The product that the variant belongs to.</param>
        /// <param name="variantId">The product variant's id.</param>
        public virtual async Task DeleteAsync(long productId, long variantId)
        {
            var req = RequestEngine.CreateRequest($"products/{productId}/variants/{variantId}.json", Method.DELETE);

            await RequestEngine.ExecuteRequestAsync(_RestClient, req);
        }
    }
}
