using ShopifySharp.Filters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    /// <summary>
    /// Used to specify centralized logic related to returning lists of results    
    /// </summary>
    public interface IListAsync<TShopifyObject, TListFilter>
        where TShopifyObject : ShopifyObject
        where TListFilter : ListFilter
    {
        Task<IEnumerable<TShopifyObject>> ListAsync(TListFilter options = null);
    }
}
