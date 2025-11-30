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

public class ShopifyPaymentsBankAccountEdgeQueryBuilder() : GraphQueryBuilder<ShopifyPaymentsBankAccountEdge>("query shopifyPaymentsBankAccountEdge")
{
    public ShopifyPaymentsBankAccountEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ShopifyPaymentsBankAccountEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}