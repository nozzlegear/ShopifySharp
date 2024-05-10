using ShopifySharp.Filters;
using System.Collections.Generic;

namespace ShopifySharp.Lists;

public class ListResult<T>
{
    public IEnumerable<T> Items { get; }

    public LinkHeaderParseResult<T> LinkHeader { get; }

    public bool HasNextPage => LinkHeader?.NextLink != null;

    public bool HasPreviousPage => LinkHeader?.PreviousLink != null;

    public ListFilter<T> GetNextPageFilter(int? limit = null, string fields = null)
    {
        return LinkHeader?.NextLink?.GetFollowingPageFilter(limit, fields);
    }

    public ListFilter<T> GetPreviousPageFilter(int? limit = null, string fields = null)
    {
        return LinkHeader?.PreviousLink?.GetFollowingPageFilter(limit, fields);
    }

    public ListResult(IEnumerable<T> items, LinkHeaderParseResult<T> linkHeader)
    {
        Items = items;
        LinkHeader = linkHeader;
    }
}