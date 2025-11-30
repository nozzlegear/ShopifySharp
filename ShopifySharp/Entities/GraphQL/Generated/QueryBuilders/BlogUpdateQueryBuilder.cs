#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class BlogUpdateQueryBuilder() : GraphQueryBuilder<BlogUpdatePayload>("query blogUpdate")
{
    public BlogUpdateQueryBuilder AddArgumentBlog(BlogUpdateInput? blog)
    {
        AddArgument("blog", blog);
        return this;
    }

    public BlogUpdateQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }
}