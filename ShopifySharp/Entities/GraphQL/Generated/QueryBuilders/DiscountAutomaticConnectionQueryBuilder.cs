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

public class DiscountAutomaticConnectionQueryBuilder() : GraphQueryBuilder<DiscountAutomaticConnection>("query discountAutomaticConnection")
{
    public DiscountAutomaticConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public DiscountAutomaticConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public DiscountAutomaticConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}