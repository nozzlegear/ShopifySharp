using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;
using ShopifySharp.Utilities;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify ProductImages.
    /// </summary>
    public class ProductImageService : ShopifyService, IProductImageService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ProductImageService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ProductImageService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
        internal ProductImageService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
		///<inheritdoc />
        public virtual async Task<int> CountAsync(long productId, ProductImageCountFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<int>($"products/{productId}/images/count.json", "count", filter, cancellationToken);
        }

		///<inheritdoc />
        public virtual async Task<ListResult<ProductImage>> ListAsync(long productId, ListFilter<ProductImage> filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetListAsync($"products/{productId}/images.json", "images", filter, cancellationToken);
        }

		///<inheritdoc />
        public virtual async Task<ProductImage> GetAsync(long productId, long imageId, string fields = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<ProductImage>($"products/{productId}/images/{imageId}.json", "image", fields, cancellationToken);
        }

		///<inheritdoc />
        public virtual async Task<ProductImage> CreateAsync(long productId, ProductImage image, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"products/{productId}/images.json");
            var content = new JsonContent(new
            {
                image = image
            });
            var response = await ExecuteRequestAsync<ProductImage>(req, HttpMethod.Post, cancellationToken, content, "image");

            return response.Result;
        }

		///<inheritdoc />
        public virtual async Task<ProductImage> UpdateAsync(long productId, long productImageId, ProductImage image, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"products/{productId}/images/{productImageId}.json");
            var content = new JsonContent(new
            {
                image = image
            });
            var response = await ExecuteRequestAsync<ProductImage>(req, HttpMethod.Put, cancellationToken, content, "image");

            return response.Result;
        }

		///<inheritdoc />
        public virtual async Task DeleteAsync(long productId, long imageId, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"products/{productId}/images/{imageId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
        }
    }
}