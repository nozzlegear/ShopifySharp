using System;
using System.Net.Http;
using ShopifySharp.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;

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
        public virtual async Task<int> CountAsync(long productId)
        {
            var req = PrepareRequest($"products/{productId}/variants/count.json");

            return await ExecuteRequestAsync<int>(req, HttpMethod.Get, rootElement: "count");
        }

        /// <summary>
        /// Gets a list of variants belonging to the given product.
        /// </summary>
        /// <param name="productId">The product that the variants belong to.</param>
        /// <param name="filterOptions">Options for filtering the result.</param>
        [Obsolete("This ListAsync method targets a version of Shopify's API which will be deprecated and cease to function in April of 2020. ShopifySharp version 5.0 has been published with support for the newer list API. Make sure you update before April of 2020.")]
        public virtual async Task<IEnumerable<ProductVariant>> ListAsync(long productId, ListFilter filterOptions = null)
        {
            var req = PrepareRequest($"products/{productId}/variants.json");

            if (filterOptions != null)
            {
                req.QueryParams.AddRange(filterOptions.ToParameters());
            }

            return await ExecuteRequestAsync<List<ProductVariant>>(req, HttpMethod.Get, rootElement: "variants");
        }

        /// <summary>
        /// Retrieves the <see cref="ProductVariant"/> with the given id.
        /// </summary>
        /// <param name="variantId">The id of the product variant to retrieve.</param>
        public virtual async Task<ProductVariant> GetAsync(long variantId)
        {
            var req = PrepareRequest($"variants/{variantId}.json");

            return await ExecuteRequestAsync<ProductVariant>(req, HttpMethod.Get, rootElement: "variant");
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

            return await ExecuteRequestAsync<ProductVariant>(req, HttpMethod.Post, content, "variant");
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

            return await ExecuteRequestAsync<ProductVariant>(req, HttpMethod.Put, content, "variant");
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
