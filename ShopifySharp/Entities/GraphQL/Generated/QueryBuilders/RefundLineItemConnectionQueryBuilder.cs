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

public class RefundLineItemConnectionQueryBuilder() : GraphQueryBuilder<RefundLineItemConnection>("query refundLineItemConnection")
{
    public RefundLineItemConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public RefundLineItemConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public RefundLineItemConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}