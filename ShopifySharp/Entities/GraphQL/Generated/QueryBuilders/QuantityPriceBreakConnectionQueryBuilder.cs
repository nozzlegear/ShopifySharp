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

public class QuantityPriceBreakConnectionQueryBuilder() : GraphQueryBuilder<QuantityPriceBreakConnection>("query quantityPriceBreakConnection")
{
    public QuantityPriceBreakConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public QuantityPriceBreakConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public QuantityPriceBreakConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}