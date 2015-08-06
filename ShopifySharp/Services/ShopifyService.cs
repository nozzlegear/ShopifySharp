using Humanizer;
using RestSharp;
using ShopifySharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public abstract class ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="ShopifyService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyService(string myShopifyUrl, string shopAccessToken)
        {
            _ShopUri = RequestEngine.BuildShopUri(myShopifyUrl);
            _RestClient = RequestEngine.CreateClient(_ShopUri, shopAccessToken);
        }

        #region Private Properties

        protected RestClient _RestClient { get; set; }

        protected Uri _ShopUri { get; set; }

        #endregion
    }
}
