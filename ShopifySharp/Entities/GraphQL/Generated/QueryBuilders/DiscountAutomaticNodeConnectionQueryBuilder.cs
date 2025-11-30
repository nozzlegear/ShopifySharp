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

public class DiscountAutomaticNodeConnectionQueryBuilder() : GraphQueryBuilder<DiscountAutomaticNodeConnection>("query discountAutomaticNodeConnection")
{
    public DiscountAutomaticNodeConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public DiscountAutomaticNodeConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public DiscountAutomaticNodeConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}