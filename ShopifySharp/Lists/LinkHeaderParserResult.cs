using System;
using System.Collections.Generic;
using System.Text;

namespace ShopifySharp.Lists
{
    public class LinkHeaderParseResult
    {
        public class PagingLink
        {
            public string Url { get; }

            public string PageInfo { get; }

            public PagingLink(string url, string pageInfo)
            {
                Url = url;
                PageInfo = pageInfo;
            }
        }

        public PagingLink PreviousLink { get; }

        public PagingLink NextLink { get; }

        public LinkHeaderParseResult(PagingLink previousLink, PagingLink nextLink)
        {
            PreviousLink = previousLink;
            NextLink = nextLink;
        }
    }
}
