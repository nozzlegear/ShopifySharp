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

public class OrderEditAddShippingLineQueryBuilder() : GraphQueryBuilder<OrderEditAddShippingLinePayload>("query orderEditAddShippingLine")
{
    public OrderEditAddShippingLineQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public OrderEditAddShippingLineQueryBuilder AddArgumentShippingLine(OrderEditAddShippingLineInput? shippingLine)
    {
        AddArgument("shippingLine", shippingLine);
        return this;
    }
}