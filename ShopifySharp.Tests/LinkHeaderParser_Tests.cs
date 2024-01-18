using ShopifySharp.Lists;
using Xunit;

namespace ShopifySharp.Tests;

[Trait("Category", "Link header parsing"), Trait("Category", "DotNetFramework"), Collection("DotNetFramework tests")]
public class LinkHeaderParser_Tests
{
    [Fact]
    public void Parse_NextLinkOnly()
    {
        var res = LinkHeaderParser.Parse<Product>("<https://test.myshopify.com/admin/api/2019-07/products.json?page_info=vwxyzab&limit=6>; rel=\"next\"");
        Assert.Null(res.PreviousLink);
        Assert.NotNull(res.NextLink);
        Assert.Equal("https://test.myshopify.com/admin/api/2019-07/products.json?page_info=vwxyzab&limit=6", res.NextLink.Url);
        Assert.Equal("vwxyzab", res.NextLink.PageInfo);
    }

    [Fact]
    public void Parse_PrevLinkOnly()
    {
        var res = LinkHeaderParser.Parse<Product>("<https://test.myshopify.com/admin/api/2019-07/products.json?page_info=vwxyzab&limit=6>; rel=\"previous\"");
        Assert.Null(res.NextLink);
        Assert.NotNull(res.PreviousLink);
        Assert.Equal("https://test.myshopify.com/admin/api/2019-07/products.json?page_info=vwxyzab&limit=6", res.PreviousLink.Url);
        Assert.Equal("vwxyzab", res.PreviousLink.PageInfo);
    }

    [Fact]
    public void Parse_PrevThenNext()
    {
        var res = LinkHeaderParser.Parse<Product>("<https://test.myshopify.com/admin/api/2019-07/products.json?page_info=abcdefg&limit=3>; rel=\"previous\", <https://test.myshopify.com/admin/api/2019-07/products.json?page_info=opqrstu&limit=3>; rel=\"next\"");
        Assert.NotNull(res.PreviousLink);
        Assert.NotNull(res.NextLink);
        Assert.Equal("https://test.myshopify.com/admin/api/2019-07/products.json?page_info=abcdefg&limit=3", res.PreviousLink.Url);
        Assert.Equal("abcdefg", res.PreviousLink.PageInfo);
        Assert.Equal("https://test.myshopify.com/admin/api/2019-07/products.json?page_info=opqrstu&limit=3", res.NextLink.Url);
        Assert.Equal("opqrstu", res.NextLink.PageInfo);
    }

    [Fact]
    public void Parse_NextThenPrev()
    {
        var res = LinkHeaderParser.Parse<Product>("<https://test.myshopify.com/admin/api/2019-07/products.json?page_info=opqrstu&limit=3>; rel=\"next\", <https://test.myshopify.com/admin/api/2019-07/products.json?page_info=abcdefg&limit=3>; rel=\"previous\"");
        Assert.NotNull(res.PreviousLink);
        Assert.NotNull(res.NextLink);
        Assert.Equal("https://test.myshopify.com/admin/api/2019-07/products.json?page_info=abcdefg&limit=3", res.PreviousLink.Url);
        Assert.Equal("abcdefg", res.PreviousLink.PageInfo);
        Assert.Equal("https://test.myshopify.com/admin/api/2019-07/products.json?page_info=opqrstu&limit=3", res.NextLink.Url);
        Assert.Equal("opqrstu", res.NextLink.PageInfo);
    }

    [Fact]
    public void Parse_PrevThenNext_WithExtraSpaces()
    {
        var res = LinkHeaderParser.Parse<Product>("  <https://test.myshopify.com/admin/api/2019-07/products.json?page_info=abcdefg&limit=3>  ;  rel=\"previous\"  ,   <https://test.myshopify.com/admin/api/2019-07/products.json?page_info=opqrstu&limit=3>  ;  rel=\"next\"  ");
        Assert.NotNull(res.PreviousLink);
        Assert.NotNull(res.NextLink);
        Assert.Equal("https://test.myshopify.com/admin/api/2019-07/products.json?page_info=abcdefg&limit=3", res.PreviousLink.Url);
        Assert.Equal("abcdefg", res.PreviousLink.PageInfo);
        Assert.Equal("https://test.myshopify.com/admin/api/2019-07/products.json?page_info=opqrstu&limit=3", res.NextLink.Url);
        Assert.Equal("opqrstu", res.NextLink.PageInfo);
    }

    [Fact]
    public void Parse_PrevThenNext_WithFieldsParam()
    {
        var res = LinkHeaderParser.Parse<Product>("<https://test.myshopify.com/admin/api/2019-07/products.json?page_info=abcdefg&limit=3&fields=id,images,title>; rel=\"previous\", <https://test.myshopify.com/admin/api/2019-07/products.json?page_info=opqrstu&limit=3&fields=id,images,title>; rel=\"next\"");
        Assert.NotNull(res.PreviousLink);
        Assert.NotNull(res.NextLink);
        Assert.Equal("https://test.myshopify.com/admin/api/2019-07/products.json?page_info=abcdefg&limit=3&fields=id,images,title", res.PreviousLink.Url);
        Assert.Equal("abcdefg", res.PreviousLink.PageInfo);
        Assert.Equal("https://test.myshopify.com/admin/api/2019-07/products.json?page_info=opqrstu&limit=3&fields=id,images,title", res.NextLink.Url);
        Assert.Equal("opqrstu", res.NextLink.PageInfo);
    }

    [Fact]
    public void Parse_PrevThenNext_PageInfoIsNotFirstQueryParam()
    {
        var res = LinkHeaderParser.Parse<Product>("<https://test.myshopify.com/admin/api/2019-07/products.json?limit=3&page_info=abcdefg>; rel=\"previous\", <https://test.myshopify.com/admin/api/2019-07/products.json?limit=3&page_info=opqrstu>; rel=\"next\"");
        Assert.NotNull(res.PreviousLink);
        Assert.NotNull(res.NextLink);
        Assert.Equal("https://test.myshopify.com/admin/api/2019-07/products.json?limit=3&page_info=abcdefg", res.PreviousLink.Url);
        Assert.Equal("abcdefg", res.PreviousLink.PageInfo);
        Assert.Equal("https://test.myshopify.com/admin/api/2019-07/products.json?limit=3&page_info=opqrstu", res.NextLink.Url);
        Assert.Equal("opqrstu", res.NextLink.PageInfo);
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