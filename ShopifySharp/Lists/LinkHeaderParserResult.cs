using ShopifySharp.Filters;

namespace ShopifySharp.Lists
{
    public class LinkHeaderParseResult<T>
    {
        public PagingLink<T> PreviousLink { get; }

        public PagingLink<T> NextLink { get; }

        public LinkHeaderParseResult(PagingLink<T> previousLink, PagingLink<T> nextLink)
        {
            PreviousLink = previousLink;
            NextLink = nextLink;
        }
    }
}
