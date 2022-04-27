using System;
using System.Collections.Generic;
using System.Text;

namespace ShopifySharp
{
    /// <summary>
    /// A service for interacting with Shopify product collection that a merchant has made available to your sales channel
    /// </summary>
    public class CollectionListingService: ShopifyService
    {
        /// <summary>
        /// Creates a new instance of <see cref="CollectionListingService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public CollectionListingService(string myShopifyUrl, string shopAccessToken) : base(myShopifyUrl, shopAccessToken)
        { }
    }
}
