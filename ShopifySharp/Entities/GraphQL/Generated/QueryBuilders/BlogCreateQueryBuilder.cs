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

public class BlogCreateQueryBuilder() : GraphQueryBuilder<BlogCreatePayload>("query blogCreate")
{
    public BlogCreateQueryBuilder AddArgumentBlog(BlogCreateInput? blog)
    {
        AddArgument("blog", blog);
        return this;
    }
}