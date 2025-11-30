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

public class BlogCreatePayloadQueryBuilder() : GraphQueryBuilder<BlogCreatePayload>("blogCreatePayload")
{
    public BlogCreatePayloadQueryBuilder AddFieldBlog(Func<BlogQueryBuilder, BlogQueryBuilder> build)
    {
        AddField<Blog, BlogQueryBuilder>("blog", build);
        return this;
    }

    public BlogCreatePayloadQueryBuilder AddFieldUserErrors(Func<BlogCreateUserErrorQueryBuilder, BlogCreateUserErrorQueryBuilder> build)
    {
        AddField<BlogCreateUserError, BlogCreateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}