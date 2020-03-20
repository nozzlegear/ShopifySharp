using Globale.Shopify.Service.APIs.ShopifyAPI.Infrastructure;
using ShopifySharp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GlobalE.Shopify.Service.APIs.ShopifyAPI.Infrastructure.Policies
{
    public interface ILeakyBucket
    {
        Task<int> GrantAsync(CloneableRequestMessage request);
        void UpdateState<T>(ShopifySharp.RequestResult<T> fullResult, int myExpectedQueryCost);
    }
}
