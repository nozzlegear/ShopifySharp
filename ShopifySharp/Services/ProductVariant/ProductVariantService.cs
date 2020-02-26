using System;
using System.Net.Http;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating a Shopify product's variants.
    /// </summary>
    public class ProductVariantService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ProductVariantService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ProductVariantService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a count of all variants belonging to the given product.
        /// </summary>
        /// <param name="productId">The product that the variants belong to.</param>
        /// <param name="filter">Options for filtering the result.</param>
        /// <remarks>
        /// According to Shopify's documentation, this endpoint does not currently support any additional filter parameters for counting.
        /// </remarks>
        public virtual async Task<int> CountAsync(long productId, ICountFilter filter = null)
        {
            var req = PrepareRequest($"products/{productId}/variants/count.json");

            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToQueryParameters());
            }
            
            var response = await ExecuteRequestAsync<int>(req, HttpMethod.Get, rootElement: "count");

            return response.Result;
        }

        /// <summary>
        /// Gets a list of variants belonging to the given product.
        /// </summary>
        /// <param name="productId">The product that the variants belong to.</param>
        public virtual async Task<IListResult<ProductVariant>> ListAsync(long productId, IListFilter<ProductVariant> filter)
        {
            var req = PrepareRequest($"products/{productId}/variants.json");
            
            if (filter != null)
            {
                req.QueryParams.AddRange(filter.ToQueryParameters());
            }
            
            var response = await ExecuteRequestAsync<List<ProductVariant>>(req, HttpMethod.Get, rootElement: "variants");

            return ParseLinkHeaderToListResult(response);
        }

        /// <summary>
        /// Gets a list of variants belonging to the given product.
        /// </summary>
        /// <param name="productId">The product that the variants belong to.</param>
        public virtual async Task<IListResult<ProductVariant>> ListAsync(long productId, ProductVariantListFilter filter)
        {
            return await ListAsync(productId, filter.AsListFilter());
        }
        

        /// <summary>
        /// Retrieves the <see cref="ProductVariant"/> with the given id.
        /// </summary>
        /// <param name="variantId">The id of the product variant to retrieve.</param>
        public virtual async Task<ProductVariant> GetAsync(long variantId)
        {
            var req = PrepareRequest($"variants/{variantId}.json");
            var response = await ExecuteRequestAsync<ProductVariant>(req, HttpMethod.Get, rootElement: "variant");

            return response.Result;
        }

        /// <summary>
        /// Creates a new <see cref="ProductVariant"/>.
        /// </summary>
        /// <param name="productId">The product that the new variant will belong to.</param>
        /// <param name="variant">A new <see cref="ProductVariant"/>. Id should be set to null.</param>
        public virtual async Task<ProductVariant> CreateAsync(long productId, ProductVariant variant)
        {
            var req = PrepareRequest($"products/{productId}/variants.json");
            var content = new JsonContent(new
            {
                variant = variant
            });
            var response = await ExecuteRequestAsync<ProductVariant>(req, HttpMethod.Post, content, "variant");

            return response.Result;
        }

        /// <summary>
        /// Updates the given <see cref="ProductVariant"/>.
        /// </summary>
        /// <param name="productVariantId">Id of the object being updated.</param>
        /// <param name="variant">The variant to update.</param>
        public virtual async Task<ProductVariant> UpdateAsync(long productVariantId, ProductVariant variant)
        {
            var req = PrepareRequest($"variants/{productVariantId}.json");
            var content = new JsonContent(new
            {
                variant = variant
            });
            var response = await ExecuteRequestAsync<ProductVariant>(req, HttpMethod.Put, content, "variant");

            return response.Result;
        }

        /// <summary>
        /// Deletes a product variant with the given Id.
        /// </summary>
        /// <param name="productId">The product that the variant belongs to.</param>
        /// <param name="variantId">The product variant's id.</param>
        public virtual async Task DeleteAsync(long productId, long variantId)
        {
            var req = PrepareRequest($"products/{productId}/variants/{variantId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }
    }
}
