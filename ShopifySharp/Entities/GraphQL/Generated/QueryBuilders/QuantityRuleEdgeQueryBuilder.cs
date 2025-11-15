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

public class QuantityRuleEdgeQueryBuilder() : GraphQueryBuilder<QuantityRuleEdge>("query quantityRuleEdge")
{
    public QuantityRuleEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public QuantityRuleEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}