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

public class DiscountCodeNodeConnectionQueryBuilder() : GraphQueryBuilder<DiscountCodeNodeConnection>("query discountCodeNodeConnection")
{
    public DiscountCodeNodeConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public DiscountCodeNodeConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public DiscountCodeNodeConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}