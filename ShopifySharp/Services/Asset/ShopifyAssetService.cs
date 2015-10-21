using Humanizer;
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
        /// Retrieves the <see cref="ShopifyAsset"/> with the given id.
        /// </summary>
        /// <param name="themeId">The id of the theme that the asset belongs to. Assets themselves do not have ids.</param>
        /// <param name="type">The type of asset bucket that this asset belongs to.</param>
        /// <param name="key">The key value of the asset, e.g. 'index.liquid' or 'bg-body.gif'.</param>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The <see cref="ShopifyAsset"/>.</returns>
        public async Task<ShopifyAsset> GetAsync(long themeId, ShopifyAssetType type, string key, string fields = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("themes/{0}/assets.json".FormatWith(themeId), Method.GET, "asset");

            //Add the proper asset querystring
            req = SetAssetQuerystring(req, type, key, themeId);

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<ShopifyAsset>(_RestClient, req);
        }

        /// <summary>
        /// Retrieves a list of all <see cref="ShopifyAsset"/> objects.
        /// </summary>
        /// <param name="fields">A comma-separated list of fields to return.</param>
        /// <returns>The list of <see cref="ShopifyAsset"/> objects.</returns>
        public async Task<IEnumerable<ShopifyAsset>> ListAsync(long themeId, string fields = null)
        {
            IRestRequest req = RequestEngine.CreateRequest("themes/{0}/assets.json".FormatWith(themeId), Method.GET, "assets");

            if (string.IsNullOrEmpty(fields) == false)
            {
                req.AddParameter("fields", fields);
            }

            return await RequestEngine.ExecuteRequestAsync<List<ShopifyAsset>>(_RestClient, req);
        }

        /// <summary>
        /// Creates or updates a <see cref="ShopifyAsset"/>. Both tasks use the same method due to the 
        /// way Shopify API handles assets. If an asset has a unique <see cref="ShopifyAsset.Key"/> value,
        /// it will be created. If not, it will be updated. Copy an asset by setting the 
        /// <see cref="ShopifyAsset.SourceKey"/> to the target's <see cref="ShopifyAsset.Key"/> value.
        /// </summary>
        /// <param name="themeId"></param>
        /// <param name="asset"></param>
        /// <returns></returns>
        public async Task<ShopifyAsset> CreateOrUpdateAsync(long themeId, ShopifyAsset asset)
        {
            IRestRequest req = RequestEngine.CreateRequest("themes/{0}/assets.json".FormatWith(themeId), Method.PUT, "asset");

            req.AddJsonBody(new { asset = asset });

            return await RequestEngine.ExecuteRequestAsync<ShopifyAsset>(_RestClient, req);
        }

        /// <summary>
        /// Deletes a <see cref="ShopifyAsset"/> with the given id.
        /// </summary>
        /// <param name="themeId">The id of the theme that the asset belongs to.</param>
        public async Task DeleteAsync(long themeId, ShopifyAssetType type, string key)
        {
            IRestRequest req = RequestEngine.CreateRequest("themes/{0}/assets.json".FormatWith(themeId), Method.DELETE);

            req = SetAssetQuerystring(req, type, key, themeId);

            await RequestEngine.ExecuteRequestAsync(_RestClient, req);
        }

        #endregion

        #region Private, static utility methods

        /// <summary>
        /// Sets the proper querystring for getting or deleting a single asset.
        /// </summary>
        /// <param name="req"></param>
        /// <param name="type"></param>
        /// <param name="key"></param>
        /// <param name="themeId"></param>
        /// <returns></returns>
        IRestRequest SetAssetQuerystring(IRestRequest req, ShopifyAssetType type, string key, long themeId)
        {
            //QS should look like:
            //?asset[key]=templates/{key}&theme_id={themeId}
            req.AddQueryParameter("asset[key]", "{0}/{1}".FormatWith(type, key));
            req.AddQueryParameter("theme_id", themeId.ToString());

            return req;
        }

        #endregion 
    }
}
