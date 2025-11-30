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

public class SellingPlanAnchorQueryBuilder() : GraphQueryBuilder<SellingPlanAnchor>("query sellingPlanAnchor")
{
    public SellingPlanAnchorQueryBuilder AddFieldCutoffDay()
    {
        AddField("cutoffDay");
        return this;
    }

    public SellingPlanAnchorQueryBuilder AddFieldDay()
    {
        AddField("day");
        return this;
    }

    public SellingPlanAnchorQueryBuilder AddFieldMonth()
    {
        AddField("month");
        return this;
    }

    public SellingPlanAnchorQueryBuilder AddFieldType()
    {
        AddField("type");
        return this;
    }
}