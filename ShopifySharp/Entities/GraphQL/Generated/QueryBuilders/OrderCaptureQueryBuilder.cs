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

public class OrderCaptureQueryBuilder() : GraphQueryBuilder<OrderCapturePayload>("query orderCapture")
{
    public OrderCaptureQueryBuilder AddArgumentInput(OrderCaptureInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}