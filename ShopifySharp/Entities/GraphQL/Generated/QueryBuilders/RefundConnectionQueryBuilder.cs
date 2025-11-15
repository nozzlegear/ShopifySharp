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

public class RefundConnectionQueryBuilder() : GraphQueryBuilder<RefundConnection>("query refundConnection")
{
    public RefundConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public RefundConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public RefundConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}