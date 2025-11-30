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

public class CalculatedDiscountApplicationConnectionQueryBuilder() : GraphQueryBuilder<CalculatedDiscountApplicationConnection>("query calculatedDiscountApplicationConnection")
{
    public CalculatedDiscountApplicationConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public CalculatedDiscountApplicationConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public CalculatedDiscountApplicationConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}