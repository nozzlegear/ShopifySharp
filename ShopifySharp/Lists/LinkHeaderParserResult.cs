using ShopifySharp.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopifySharp.Lists
{
    public class LinkHeaderParseResult<T>
    {
        public class PagingLink<T>
        {
            public string Url { get; }

            public int? Limit { get; }

            public string PageInfo { get; }

            public PagingLink(string url, string pageInfo, int? limit)
            {
                Url = url;
                PageInfo = pageInfo;
                Limit = limit;
            }

            public ListFilter<T> GetFollowingPageFilter(int? limit = null)
            {
                return new ListFilter<T>(this.PageInfo, limit ?? this.Limit);
            }
        }

        public PagingLink<T> PreviousLink { get; }

        public PagingLink<T> NextLink { get; }

        public LinkHeaderParseResult(PagingLink<T> previousLink, PagingLink<T> nextLink)
        {
            PreviousLink = previousLink;
            NextLink = nextLink;
        }
    }
}
