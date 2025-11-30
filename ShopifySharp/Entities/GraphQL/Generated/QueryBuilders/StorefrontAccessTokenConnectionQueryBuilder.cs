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

public class StorefrontAccessTokenConnectionQueryBuilder() : GraphQueryBuilder<StorefrontAccessTokenConnection>("query storefrontAccessTokenConnection")
{
    public StorefrontAccessTokenConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public StorefrontAccessTokenConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public StorefrontAccessTokenConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}