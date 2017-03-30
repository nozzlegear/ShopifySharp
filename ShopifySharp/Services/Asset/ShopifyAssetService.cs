using RestSharp;
using ShopifySharp.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// A service for manipulating Shopify's Assets API.
    /// </summary>
    public class ShopifyAssetService : ShopifyService
    {
        #region Constructor

        /// <summary>
        /// Creates a new instance of <see cref="ShopifyAssetService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyAssetService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken) { }

        #endregion

        #region Public, non-static Charge methods

        /// <summary>
        /// Retrieves the <see cref="Asset"/> with the given id.
        /// </summary>
        /// <param name="themeId">The id of the theme that the asset belongs to. Assets themselves do not have ids.</param>
        /// <param name="key">The key value of the asset, e.g. 'templates/index.liquid' or 'assets/bg-body.gif'.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="Asset"/>.</returns>
        public virtual async Task<Asset> GetAsync(long themeId, string key, string fields = null)
        {
            IRestRequest req = RequestEngine.CreateRequest($"themes/{themeId}/assets.json", Method.GET, "asset");

            //Add the proper asset querystring
            req = SetAssetQuerystring(req, key, themeId);

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<Asset>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves a list of all <see cref="Asset"/> objects. Listing theme assets only returns metadata about each asset. 
        /// You need to request assets individually in order to get their contents. 
        /// </summary>
        /// <param name="themeId">The id of the theme that the asset belongs to.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The list of <see cref="Asset"/> objects.</returns>
        public virtual async Task<IEnumerable<Asset>> ListAsync(long themeId, string fields = null)
        {
            IRestRequest req = RequestEngine.CreateRequest($"themes/{themeId}/assets.json", Method.GET, "assets");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<List<Asset>>(_RestClient, req);
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
            IRestRequest req = RequestEngine.CreateRequest($"themes/{themeId}/assets.json", Method.PUT, "asset");

            req.AddJsonBody(new { asset = asset });

            return await RequestEngine.ExecuteRequestAsync<Asset>(_RestClient, req);
        }

        /// <summary>
        /// Deletes a <see cref="Asset"/> with the given key.
        /// </summary>
        /// <param name="themeId">The id of the theme that the asset belongs to.</param>
        /// <param name="key">The key value of the asset, e.g. 'templates/index.liquid' or 'assets/bg-body.gif'.</param>
        public virtual async Task DeleteAsync(long themeId, string key)
        {
            IRestRequest req = RequestEngine.CreateRequest($"themes/{themeId}/assets.json", Method.DELETE);

            req = SetAssetQuerystring(req, key, themeId);

            await RequestEngine.ExecuteRequestAsync(_RestClient, req);
        }

        #endregion

        #region Private, static utility methods

        /// <summary>
        /// Sets the proper querystring for getting or deleting a single asset.
        /// </summary>
        /// <param name="req">The request to modify.</param>
        /// <param name="key">The key value of the asset, e.g. 'templates/index.liquid' or 'assets/bg-body.gif'.</param>
        /// <param name="themeId">The id of the theme that the asset belongs to.</param>
        /// <returns>The request with the proper querystring.</returns>
        IRestRequest SetAssetQuerystring(IRestRequest req, string key, long themeId)
        {
            //QS should look like:
            //?asset[key]={key}&theme_id={themeId}
            req.AddQueryParameter("asset[key]", key);
            req.AddQueryParameter("theme_id", themeId.ToString());

            return req;
        }

        #endregion 
    }
}
