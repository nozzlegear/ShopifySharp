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

public class AbandonedCheckoutConnectionQueryBuilder() : GraphQueryBuilder<AbandonedCheckoutConnection>("query abandonedCheckoutConnection")
{
    public AbandonedCheckoutConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public AbandonedCheckoutConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public AbandonedCheckoutConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}