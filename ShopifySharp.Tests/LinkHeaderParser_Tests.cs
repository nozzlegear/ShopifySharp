using ShopifySharp.Infrastructure;
using ShopifySharp.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using EmptyAssert = ShopifySharp.Tests.Extensions.EmptyExtensions;

namespace ShopifySharp.Tests
{
    [Trait("Category", "Link header parsing"), Trait("Category", "DotNetFramework")]
    public class LinkHeaderParser_Tests
    {
        [Fact]
        public void Parse_NextLinkOnly()
        {
            var res = LinkHeaderParser.Parse<Product>("<https://test.myshopify.com/admin/api/2019-07/products.json?page_info=vwxyzab&limit=6>; rel=\"next\"");
            Assert.Null(res.PreviousLink);
            Assert.NotNull(res.NextLink);
            Assert.Equal(res.NextLink.Url, "https://test.myshopify.com/admin/api/2019-07/products.json?page_info=vwxyzab&limit=6");
            Assert.Equal(res.NextLink.PageInfo, "vwxyzab");
        }

        [Fact]
        public void Parse_PrevLinkOnly()
        {
            var res = LinkHeaderParser.Parse<Product>("<https://test.myshopify.com/admin/api/2019-07/products.json?page_info=vwxyzab&limit=6>; rel=\"previous\"");
            Assert.Null(res.NextLink);
            Assert.NotNull(res.PreviousLink);
            Assert.Equal(res.PreviousLink.Url, "https://test.myshopify.com/admin/api/2019-07/products.json?page_info=vwxyzab&limit=6");
            Assert.Equal(res.PreviousLink.PageInfo, "vwxyzab");
        }

        [Fact]
        public void Parse_PrevThenNext()
        {
            var res = LinkHeaderParser.Parse<Product>("<https://test.myshopify.com/admin/api/2019-07/products.json?page_info=abcdefg&limit=3>; rel=\"previous\", <https://test.myshopify.com/admin/api/2019-07/products.json?page_info=opqrstu&limit=3>; rel=\"next\"");
            Assert.NotNull(res.PreviousLink);
            Assert.NotNull(res.NextLink);
            Assert.Equal(res.PreviousLink.Url, "https://test.myshopify.com/admin/api/2019-07/products.json?page_info=abcdefg&limit=3");
            Assert.Equal(res.PreviousLink.PageInfo, "abcdefg");
            Assert.Equal(res.NextLink.Url, "https://test.myshopify.com/admin/api/2019-07/products.json?page_info=opqrstu&limit=3");
            Assert.Equal(res.NextLink.PageInfo, "opqrstu");
        }

        [Fact]
        public void Parse_NextThenPrev()
        {
            var res = LinkHeaderParser.Parse<Product>("<https://test.myshopify.com/admin/api/2019-07/products.json?page_info=opqrstu&limit=3>; rel=\"next\", <https://test.myshopify.com/admin/api/2019-07/products.json?page_info=abcdefg&limit=3>; rel=\"previous\"");
            Assert.NotNull(res.PreviousLink);
            Assert.NotNull(res.NextLink);
            Assert.Equal(res.PreviousLink.Url, "https://test.myshopify.com/admin/api/2019-07/products.json?page_info=abcdefg&limit=3");
            Assert.Equal(res.PreviousLink.PageInfo, "abcdefg");
            Assert.Equal(res.NextLink.Url, "https://test.myshopify.com/admin/api/2019-07/products.json?page_info=opqrstu&limit=3");
            Assert.Equal(res.NextLink.PageInfo, "opqrstu");
        }

        [Fact]
        public void Parse_PrevThenNext_WithExtraSpaces()
        {
            var res = LinkHeaderParser.Parse<Product>("  <https://test.myshopify.com/admin/api/2019-07/products.json?page_info=abcdefg&limit=3>  ;  rel=\"previous\"  ,   <https://test.myshopify.com/admin/api/2019-07/products.json?page_info=opqrstu&limit=3>  ;  rel=\"next\"  ");
            Assert.NotNull(res.PreviousLink);
            Assert.NotNull(res.NextLink);
            Assert.Equal(res.PreviousLink.Url, "https://test.myshopify.com/admin/api/2019-07/products.json?page_info=abcdefg&limit=3");
            Assert.Equal(res.PreviousLink.PageInfo, "abcdefg");
            Assert.Equal(res.NextLink.Url, "https://test.myshopify.com/admin/api/2019-07/products.json?page_info=opqrstu&limit=3");
            Assert.Equal(res.NextLink.PageInfo, "opqrstu");
        }

        [Fact]
        public void Parse_PrevThenNext_WithFieldsParam()
        {
            var res = LinkHeaderParser.Parse<Product>("<https://test.myshopify.com/admin/api/2019-07/products.json?page_info=abcdefg&limit=3&fields=id,images,title>; rel=\"previous\", <https://test.myshopify.com/admin/api/2019-07/products.json?page_info=opqrstu&limit=3&fields=id,images,title>; rel=\"next\"");
            Assert.NotNull(res.PreviousLink);
            Assert.NotNull(res.NextLink);
            Assert.Equal(res.PreviousLink.Url, "https://test.myshopify.com/admin/api/2019-07/products.json?page_info=abcdefg&limit=3&fields=id,images,title");
            Assert.Equal(res.PreviousLink.PageInfo, "abcdefg");
            Assert.Equal(res.NextLink.Url, "https://test.myshopify.com/admin/api/2019-07/products.json?page_info=opqrstu&limit=3&fields=id,images,title");
            Assert.Equal(res.NextLink.PageInfo, "opqrstu");
        }

        [Fact]
        public void Parse_PrevThenNext_PageInfoIsNotFirstQueryParam()
        {
            var res = LinkHeaderParser.Parse<Product>("<https://test.myshopify.com/admin/api/2019-07/products.json?limit=3&page_info=abcdefg>; rel=\"previous\", <https://test.myshopify.com/admin/api/2019-07/products.json?limit=3&page_info=opqrstu>; rel=\"next\"");
            Assert.NotNull(res.PreviousLink);
            Assert.NotNull(res.NextLink);
            Assert.Equal(res.PreviousLink.Url, "https://test.myshopify.com/admin/api/2019-07/products.json?limit=3&page_info=abcdefg");
            Assert.Equal(res.PreviousLink.PageInfo, "abcdefg");
            Assert.Equal(res.NextLink.Url, "https://test.myshopify.com/admin/api/2019-07/products.json?limit=3&page_info=opqrstu");
            Assert.Equal(res.NextLink.PageInfo, "opqrstu");
        }

        [Fact]
        public void Parses_Fields_Parameter()
        {
            var res = LinkHeaderParser.Parse<Product>("<https://test.myshopify.com/admin/api/2019-07/products.json?limit=3&page_info=abcdefg&fields=id%2Ccustomer%2Ccreated_at>; rel=\"previous\", <https://test.myshopify.com/admin/api/2019-07/products.json?limit=3&page_info=opqrstu&fields=id%2Ccustomer%2Ccreated_at>; rel=\"next\"");
            Assert.NotNull(res.PreviousLink);
            Assert.NotNull(res.NextLink);
            Assert.Equal("https://test.myshopify.com/admin/api/2019-07/products.json?limit=3&page_info=abcdefg&fields=id%2Ccustomer%2Ccreated_at", res.PreviousLink.Url);
            Assert.Equal("id,customer,created_at", res.PreviousLink.Fields);
            Assert.Equal("https://test.myshopify.com/admin/api/2019-07/products.json?limit=3&page_info=opqrstu&fields=id%2Ccustomer%2Ccreated_at", res.NextLink.Url);
            Assert.Equal("id,customer,created_at", res.NextLink.Fields);

            var nextPageFilter = res.NextLink.GetFollowingPageFilter();
            
            Assert.Equal("id,customer,created_at", nextPageFilter.Fields);

            var previousPageFilter = res.PreviousLink.GetFollowingPageFilter();
            
            Assert.Equal("id,customer,created_at", previousPageFilter.Fields);
        }
    }
}
