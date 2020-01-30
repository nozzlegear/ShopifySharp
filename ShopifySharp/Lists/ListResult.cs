using System.Collections.Generic;
using System.Linq;

namespace ShopifySharp.Lists
{
    public class ListResult<T> : IListResult<T>
    {
        public string NextPageLink { get; set; }
        
        public string PreviousPageLink { get; set; }
        
        public IEnumerable<T> Items { get; set; } = Enumerable.Empty<T>();
    }
}