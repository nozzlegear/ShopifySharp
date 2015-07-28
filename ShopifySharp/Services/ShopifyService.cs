using Humanizer;
using RestSharp;
using ShopifySharp.Deserializers;
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
            if(Uri.IsWellFormedUriString(myShopifyUrl, UriKind.Absolute) == false)
            {
                throw new ShopifyException("Service constructor: {0} is invalid.".FormatWith(nameof(myShopifyUrl)));
            }

            UriBuilder builder = new UriBuilder(myShopifyUrl)
            {
                Path = "admin/",
                Scheme = Uri.UriSchemeHttps,
                Port = 443 //SSL port
            };

            _ShopUri = builder.Uri;
            _RestClient = new RestClient(_ShopUri);

            //Set up the JSON.NET deserializer for the RestSharp client
            JsonNetDeserializer deserializer = new JsonNetDeserializer();
            _RestClient.AddHandler("application/json", deserializer);
            _RestClient.AddHandler("text/json", deserializer);

            //Configure default access token header
            _RestClient.AddDefaultHeader("X-Shopify-Access-Token", shopAccessToken);
        }

        #region Private Properties

        protected RestClient _RestClient { get; set; }

        protected Uri _ShopUri { get; set; }

        #endregion
    }
}
