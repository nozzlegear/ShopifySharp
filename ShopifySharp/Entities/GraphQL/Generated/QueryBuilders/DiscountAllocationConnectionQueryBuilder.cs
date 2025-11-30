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

public class DiscountAllocationConnectionQueryBuilder() : GraphQueryBuilder<DiscountAllocationConnection>("query discountAllocationConnection")
{
    public DiscountAllocationConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public DiscountAllocationConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public DiscountAllocationConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}