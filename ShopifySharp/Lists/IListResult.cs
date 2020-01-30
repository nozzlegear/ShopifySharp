using System.Collections.Generic;

namespace ShopifySharp.Lists
{
    public interface IListResult<T>
    {
        string NextPageLink { get; set; }
        string PreviousPageLink { get; set; }
        IEnumerable<T> Items { get; set; }
    }
}