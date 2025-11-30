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

public class DiscountRedeemCodeConnectionQueryBuilder() : GraphQueryBuilder<DiscountRedeemCodeConnection>("query discountRedeemCodeConnection")
{
    public DiscountRedeemCodeConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public DiscountRedeemCodeConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public DiscountRedeemCodeConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}