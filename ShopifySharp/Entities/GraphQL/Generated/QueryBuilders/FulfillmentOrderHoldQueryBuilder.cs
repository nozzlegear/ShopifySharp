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

public class FulfillmentOrderHoldQueryBuilder() : GraphQueryBuilder<FulfillmentOrderHoldPayload>("query fulfillmentOrderHold")
{
    public FulfillmentOrderHoldQueryBuilder AddArgumentFulfillmentHold(FulfillmentOrderHoldInput? fulfillmentHold)
    {
        AddArgument("fulfillmentHold", fulfillmentHold);
        return this;
    }

    public FulfillmentOrderHoldQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }
}