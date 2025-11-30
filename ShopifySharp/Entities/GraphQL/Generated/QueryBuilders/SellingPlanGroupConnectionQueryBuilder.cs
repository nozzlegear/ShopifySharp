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

public class SellingPlanGroupConnectionQueryBuilder() : GraphQueryBuilder<SellingPlanGroupConnection>("query sellingPlanGroupConnection")
{
    public SellingPlanGroupConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public SellingPlanGroupConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public SellingPlanGroupConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}