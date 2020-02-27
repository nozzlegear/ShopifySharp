using ShopifySharp.Filters;

namespace ShopifySharp.Lists
{
    public class LinkHeaderParseResult<T>
    {
        public class PagingLink<T>
        {
            public string Url { get; }

            public int? Limit { get; }

            public string PageInfo { get; }
            
            public string Fields { get; }

            public PagingLink(string url, string pageInfo, int? limit, string fields = null)
            {
                Url = url;
                PageInfo = pageInfo;
                Limit = limit;
                Fields = fields;
            }

            public ListFilter<T> GetFollowingPageFilter(int? limit = null, string fields = null)
            {
                return new ListFilter<T>(this.PageInfo, limit ?? this.Limit, fields ?? this.Fields);
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
