using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ShopifySharp.Lists
{
    public static class LinkHeaderParser
    {
        private static Regex _regexPrevLink = new Regex(@"<(https://[^>]*)>\s*;\s*rel=""previous""", RegexOptions.Compiled | RegexOptions.CultureInvariant);
        private static Regex _regexNextLink = new Regex(@"<(https://[^>]*)>\s*;\s*rel=""next""", RegexOptions.Compiled | RegexOptions.CultureInvariant);

        public static LinkHeaderParseResult<T> Parse<T>(string linkHeaderValue)
        {
            var prevLink = GetPageInfoParam<T>(linkHeaderValue, _regexPrevLink);
            var nextLink = GetPageInfoParam<T>(linkHeaderValue, _regexNextLink);

            if (prevLink == null && nextLink == null)
                throw new ShopifyException($"Found neither a 'previous' or 'next' url in the link header: '{linkHeaderValue}'");

            return new LinkHeaderParseResult<T>(prevLink, nextLink);
        }

        private static LinkHeaderParseResult<T>.PagingLink<T> GetPageInfoParam<T>(string linkHeaderValue, Regex linkRegex)
        {
            var match = linkRegex.Match(linkHeaderValue);

            if (!match.Success || match.Groups.Count < 2 || !match.Groups[1].Success)
                return null;

            string matchedUrl = match.Groups[1].Value;

            if (!Uri.TryCreate(matchedUrl, UriKind.Absolute, out var uri))
                throw new ShopifyException($"Cannot parse page link url: '{matchedUrl}'");

            string pageInfo = uri.Query.Split('?', '&')
                                        .FirstOrDefault(p => p.StartsWith("page_info="))
                                        ?.Substring("page_info=".Length);
            if (pageInfo == null)
                throw new ShopifyException($"Cannot parse page link's page info parameter: '{matchedUrl}'");

            return new LinkHeaderParseResult<T>.PagingLink<T>(matchedUrl, pageInfo);
        }
    }
}
