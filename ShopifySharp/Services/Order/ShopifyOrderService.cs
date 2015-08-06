using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class ShopifyOrderService : ShopifyService
    {
        #region Constructor

        /// <summary>
        /// Creates a new instance of <see cref="ShopifyOrderService" />.
        /// </summary>
        /// <param name="myShopifyUrl">The shop's *.myshopify.com URL.</param>
        /// <param name="shopAccessToken">An API access token for the shop.</param>
        public ShopifyOrderService(string myShopifyUrl, string shopAccessToken): base(myShopifyUrl, shopAccessToken) { }

        #endregion

        #region Public, non-static methods

        public async Task<int> CountAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<ShopifyOrder> ListAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ShopifyOrder>> ListForCustomerAsync(long customerId)
        {
            throw new NotImplementedException();
        }

        public async Task<ShopifyOrder> GetAsync(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<ShopifyOrder> CloseAsync(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<ShopifyOrder> OpenAsync(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<ShopifyOrder> CreateAsync(ShopifyOrder order)
        {
            throw new NotImplementedException();
        }

        public async Task<ShopifyOrder> UpdateAsync(ShopifyOrder order)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
