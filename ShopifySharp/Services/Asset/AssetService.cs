using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net.Http;
using ShopifySharp.Infrastructure;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify's Assets API.
    /// </summary>
    public class AssetService : ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="AssetService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public AssetService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        /// <summary>
        /// Retrieves the <see cref="Asset"/> with the given id.
        /// </summary>
        /// <param name="themeId">The id of the theme that the asset belongs to. Assets themselves do not have ids.</param>
        /// <param name="key">The key value of the asset, e.g. 'templates/index.liquid' or 'assets/bg-body.gif'.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="Asset"/>.</returns>
        public virtual async Task<Asset> GetAsync(long themeId, string key, string fields = null)
        {
            var req = PrepareRequest($"themes/{themeId}/assets.json");

            //Add the proper asset querystring
            req = SetAssetQuerystring(req, key, themeId);

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.QueryParams.Add("fields", fields);
            }

            return await ExecuteRequestAsync<Asset>(req, HttpMethod.Get, rootElement: "asset");
        }

        /// <summary>
        /// Retrieves a list of all <see cref="Asset"/> objects. Listing theme assets only returns metadata about each asset.
        /// You need to request assets individually in order to get their contents.
        /// </summary>
        /// <param name="themeId">The id of the theme that the asset belongs to.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The list of <see cref="Asset"/> objects.</returns>
        public virtual async Task<IEnumerable<Asset>> ListAsync(IListFilter filter)
        {
            throw new Exception("not yet implemented");
            var req = PrepareRequest($"themes/{themeId}/assets.json");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.QueryParams.Add("fields", fields);
            }

            return await ExecuteRequestAsync<List<Asset>>(req, HttpMethod.Get, rootElement: "assets");
        }

        /// <summary>
        /// Creates or updates a <see cref="Asset"/>. Both tasks use the same method due to the
        /// way Shopify API handles assets. If an asset has a unique <see cref="Asset.Key"/> value,
        /// it will be created. If not, it will be updated. Copy an asset by setting the
        /// <see cref="Asset.SourceKey"/> to the target's <see cref="Asset.Key"/> value.
        /// Note: This will not return the asset's <see cref="Asset.Value"/> property. You should
        /// use <see cref="GetAsync(long, string, string)"/> to refresh the value after creating or updating.
        /// </summary>
        /// <param name="themeId">The id of the theme that the asset belongs to.</param>
        /// <param name="asset">The asset.</param>
        /// <returns>The created or updated asset.</returns>
        public virtual async Task<Asset> CreateOrUpdateAsync(long themeId, Asset asset)
        {
            var req = PrepareRequest($"themes/{themeId}/assets.json");
            var content = new JsonContent(new
            {
                asset = asset
            });

            return await ExecuteRequestAsync<Asset>(req, HttpMethod.Put, content, "asset");
        }

        /// <summary>
        /// Deletes a <see cref="Asset"/> with the given key.
        /// </summary>
        /// <param name="themeId">The id of the theme that the asset belongs to.</param>
        /// <param name="key">The key value of the asset, e.g. 'templates/index.liquid' or 'assets/bg-body.gif'.</param>
        public virtual async Task DeleteAsync(long themeId, string key)
        {
            var req = PrepareRequest($"themes/{themeId}/assets.json");

            req = SetAssetQuerystring(req, key, themeId);

            await ExecuteRequestAsync(req, HttpMethod.Delete);
        }

        /// <summary>
        /// Sets the proper querystring for getting or deleting a single asset.
        /// </summary>
        /// <param name="req">The request to modify.</param>
        /// <param name="key">The key value of the asset, e.g. 'templates/index.liquid' or 'assets/bg-body.gif'.</param>
        /// <param name="themeId">The id of the theme that the asset belongs to.</param>
        /// <returns>The request with the proper querystring.</returns>
        RequestUri SetAssetQuerystring(RequestUri req, string key, long themeId)
        {
            //QS should look like:
            //?asset[key]={key}&theme_id={themeId}
            req.QueryParams.Add("asset[key]", key);
            req.QueryParams.Add("theme_id", themeId);

            return req;
        }
    }
}
