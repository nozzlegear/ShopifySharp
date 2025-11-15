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

public class RefundShippingLineConnectionQueryBuilder() : GraphQueryBuilder<RefundShippingLineConnection>("query refundShippingLineConnection")
{
    public RefundShippingLineConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public RefundShippingLineConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public RefundShippingLineConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}