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

public class BlogDeletePayloadQueryBuilder() : GraphQueryBuilder<BlogDeletePayload>("blogDeletePayload")
{
    public BlogDeletePayloadQueryBuilder AddFieldDeletedBlogId()
    {
        AddField("deletedBlogId");
        return this;
    }

    public BlogDeletePayloadQueryBuilder AddFieldUserErrors(Func<BlogDeleteUserErrorQueryBuilder, BlogDeleteUserErrorQueryBuilder> build)
    {
        AddField<BlogDeleteUserError, BlogDeleteUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}