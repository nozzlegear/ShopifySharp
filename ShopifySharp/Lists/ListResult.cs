using ShopifySharp.Filters;
using ShopifySharp.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace ShopifySharp.Lists
{
    public class ListResult<T>
    {
        public IEnumerable<T> Items { get; }

        public LinkHeaderParseResult<T> LinkHeader { get; }

        public ListFilter<T> GetNextPageFilter(int? limit = null)
        {
            return LinkHeader?.NextLink?.GetFollowingPageFilter(limit);
        }

        public ListFilter<T> GetPreviousPageFilter(int? limit = null)
        {
            return LinkHeader?.PreviousLink?.GetFollowingPageFilter(limit);
        }

        public ListResult(IEnumerable<T> items, LinkHeaderParseResult<T> linkHeader)
        {
            Items = items;
            LinkHeader = linkHeader;
        }
    }
}