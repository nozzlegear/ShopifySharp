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

public class OrderEditCommitPayloadQueryBuilder() : GraphQueryBuilder<OrderEditCommitPayload>("query orderEditCommitPayload")
{
    public OrderEditCommitPayloadQueryBuilder AddFieldOrder()
    {
        AddField("order");
        return this;
    }

    public OrderEditCommitPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}