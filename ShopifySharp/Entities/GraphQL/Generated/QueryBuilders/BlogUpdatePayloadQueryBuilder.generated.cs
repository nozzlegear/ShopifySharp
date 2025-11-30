#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class BlogUpdatePayloadQueryBuilder() : GraphQueryBuilder<BlogUpdatePayload>("blogUpdatePayload")
{
    public BlogUpdatePayloadQueryBuilder AddFieldBlog(Func<BlogQueryBuilder, BlogQueryBuilder> build)
    {
        AddField<Blog, BlogQueryBuilder>("blog", build);
        return this;
    }

    public BlogUpdatePayloadQueryBuilder AddFieldUserErrors(Func<BlogUpdateUserErrorQueryBuilder, BlogUpdateUserErrorQueryBuilder> build)
    {
        AddField<BlogUpdateUserError, BlogUpdateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}