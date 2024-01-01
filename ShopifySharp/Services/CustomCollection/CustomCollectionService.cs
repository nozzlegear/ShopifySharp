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
    /// A service for manipulating mapping between custom collections and collections
    /// </summary>
    public class CustomCollectionService : ShopifyService, ICustomCollectionService
    {
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CustomCollectionService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }
        internal CustomCollectionService(string shopDomain, string accessToken, IShopifyDomainUtility shopifyDomainUtility) : base(shopDomain, accessToken, shopifyDomainUtility) {}
 
        /// <inheritdoc />
        public virtual async Task<ListResult<CustomCollection>> ListAsync(ListFilter<CustomCollection> filter = null, CancellationToken cancellationToken = default) => await ExecuteGetListAsync("custom_collections.json", "custom_collections", filter, cancellationToken);

        /// <inheritdoc />
        public virtual async Task<ListResult<CustomCollection>> ListAsync(CustomCollectionListFilter filter, CancellationToken cancellationToken = default) => await ListAsync(filter?.AsListFilter(), cancellationToken);

        /// <inheritdoc />
        public virtual async Task<CustomCollection> CreateAsync(CustomCollection customCollection, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri("custom_collections.json");
            var content = new JsonContent(new
            {
                custom_collection = customCollection
            });

            var response = await ExecuteRequestAsync<CustomCollection>(req, HttpMethod.Post, cancellationToken, content, "custom_collection");
            
            return response.Result;
        }

        /// <inheritdoc />
        public virtual async Task<int> CountAsync(CustomCollectionCountFilter filter = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<int>("custom_collections/count.json", "count", filter, cancellationToken);
        }

        /// <inheritdoc />
        public virtual async Task<CustomCollection> GetAsync(long customCollectionId, string fields = null, CancellationToken cancellationToken = default)
        {
            return await ExecuteGetAsync<CustomCollection>($"custom_collections/{customCollectionId}.json", "custom_collection", fields, cancellationToken);
        }

        /// <inheritdoc />
        public virtual async Task DeleteAsync(long customCollectionId, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"custom_collections/{customCollectionId}.json");

            await ExecuteRequestAsync(req, HttpMethod.Delete, cancellationToken);
        }

        /// <inheritdoc />
        public virtual async Task<CustomCollection> UpdateAsync(long customCollectionId, CustomCollection customCollection, CancellationToken cancellationToken = default)
        {
            var req = BuildRequestUri($"custom_collections/{customCollectionId}.json");
            var content = new JsonContent(new
            {
                custom_collection = customCollection
            });

            var response = await ExecuteRequestAsync<CustomCollection>(req, HttpMethod.Put, cancellationToken, content, "custom_collection");
            return response.Result;
        }
    }
}