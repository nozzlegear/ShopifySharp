using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalE.Shopify.Service.APIs.ShopifyAPI.Infrastructure.Policies
{
    public interface ILeakyBucketState
    {
        bool IsFull { get; }
    }
}
