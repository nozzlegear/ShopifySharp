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

public class CartTransformConnectionQueryBuilder() : GraphQueryBuilder<CartTransformConnection>("query cartTransformConnection")
{
    public CartTransformConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public CartTransformConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public CartTransformConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}