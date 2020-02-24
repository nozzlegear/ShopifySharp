using ShopifySharp.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace ShopifySharp.Lists
{
    public class ListResult<T> : IListResult<T>
    {
        public IEnumerable<T> Items { get; }

        public LinkHeaderParseResult LinkHeader { get; }

        public ListResult(IEnumerable<T> items, LinkHeaderParseResult linkHeader)
        {
            Items = items;
            LinkHeader = linkHeader;
        }
    }
}