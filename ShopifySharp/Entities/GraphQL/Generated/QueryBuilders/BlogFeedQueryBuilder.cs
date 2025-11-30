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

public class BlogFeedQueryBuilder() : GraphQueryBuilder<BlogFeed>("query blogFeed")
{
    public BlogFeedQueryBuilder AddFieldLocation()
    {
        AddField("location");
        return this;
    }

    public BlogFeedQueryBuilder AddFieldPath()
    {
        AddField("path");
        return this;
    }
}