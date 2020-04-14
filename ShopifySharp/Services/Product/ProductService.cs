﻿using System.Net.Http;
using ShopifySharp.Filters;
using System.Threading.Tasks;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;
using System.Collections.Generic;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify products.
    /// </summary>
    public class ProductService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ProductService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ProductService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Gets a count of all of the shop's products.
        /// </summary>
        /// <returns>The count of all products for the shop.</returns>
        public virtual async Task<int> CountAsync(ProductCountFilter filter = null)
        {
            return await ExecuteGetAsync<int>("products/count.json", "count", filter);
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's products.
        /// </summary>
        public virtual async Task<ListResult<Product>> ListAsync(ListFilter<Product> filter)
        {
            return await ExecuteGetListAsync("products.json", "products", filter);
        }

        /// <summary>
        /// Gets a list of up to 250 of the shop's products.
        /// </summary>
        public virtual async Task<ListResult<Product>> ListAsync(ProductListFilter filter = null)
        {
            return await ListAsync(filter?.AsListFilter());
        }

        /// <summary>
        /// Retrieves the <see cref="Product"/> with the given id.
        /// </summary>
        /// <param name="productId">The id of the product to retrieve.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="Product"/>.</returns>
        public virtual async Task<Product> GetAsync(long productId, string fields = null)
        {
            return await ExecuteGetAsync<Product>($"products/{productId}.json", "product", fields);
        }

        /// <summary>
        /// Creates a new <see cref="Product"/> on the store.
        /// </summary>
        /// <param name="product">A new <see cref="Product"/>. Id should be set to null.</param>
        /// <param name="options">Options for creating the product.</param>
        /// <returns>The new <see cref="Product"/>.</returns>
        public virtual async Task<Product> CreateAsync(Product product, ProductCreateOptions options = null)
        {
            var req = PrepareRequest("products.json");
            var body = product.ToDictionary();

            if (options != null)
            {
                foreach (var option in options.ToDictionary())
                {
                    body.Add(option);
                }
            }

            var content = new JsonContent(new
            {
                product = body
            });
            var response = await ExecuteRequestAsync<Product>(req, HttpMethod.Post, content, "product");

            return response.Result;
        }

        /// <summary>
        /// Updates the given <see cref="Product"/>.
        /// </summary>
        /// <param name="productId">Id of the object being updated.</param>
        /// <param name="product">The <see cref="Product"/> to update.</param>
        /// <returns>The updated <see cref="Product"/>.</returns>
        public virtual async Task<Product> UpdateAsync(long productId, Product product)
        {
            var req = PrepareRequest($"products/{productId}.json");
            JsonContent content = new JsonContent(new
            {
                product = product
            });
            var response = await ExecuteRequestAsync<Product>(req, HttpMethod.Put, content, "product");

            return response.Result;
        }

        /// <summary>
        /// Updates a <see cref="Product"/>, changing only the fields specified by the <see cref="UpdateBuilder{T}"/>.
        /// </summary>
        /// <param name="productId">Id of the object being updated.</param>
        /// <param name="builder">The fields to update and their values.</param>
        /// <returns>The updated <see cref="Product"/>.</returns>
        public virtual async Task<Product> UpdateAsync(long productId, UpdateBuilder<Product> builder)
        {
            var response = await ExecutePutAsync($"products/{productId}.json", "product", builder);
            return response;
        }

        /// <summary>
        /// Deletes a product with the given Id.
        /// </summary>
        /// <param name="productId">The product object's Id.</param>
        public virtual async Task DeleteAsync(long productId)
        {
            var req = PrepareRequest($"products/{productId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }

        /// <summary>
        /// Publishes an unpublished <see cref="Product"/>.
        /// </summary>
        /// <param name="id">The product's id.</param>
        /// <returns>The published <see cref="Product"/></returns>
        public virtual async Task<Product> PublishAsync(long id)
        {
            var req = PrepareRequest($"products/{id}.json");
            var content = new JsonContent(new
            {
                product = new
                {
                    id = id,
                    published = true
                }
            });
            var response = await ExecuteRequestAsync<Product>(req, HttpMethod.Put, content, "product");

            return response.Result;
        }

        /// <summary>
        /// Unpublishes an published <see cref="Product"/>.
        /// </summary>
        /// <param name="id">The product's id.</param>
        /// <returns>The unpublished <see cref="Product"/></returns>
        public virtual async Task<Product> UnpublishAsync(long id)
        {
            var req = PrepareRequest($"products/{id}.json");
            var content = new JsonContent(new
            {
                product = new
                {
                    id = id,
                    published = false
                }
            });
            var response = await ExecuteRequestAsync<Product>(req, HttpMethod.Put, content, "product");

            return response.Result;
        }
    }
}