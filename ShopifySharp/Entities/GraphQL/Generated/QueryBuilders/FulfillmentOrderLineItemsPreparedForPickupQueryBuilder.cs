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

public class FulfillmentOrderLineItemsPreparedForPickupQueryBuilder() : GraphQueryBuilder<FulfillmentOrderLineItemsPreparedForPickupPayload>("query fulfillmentOrderLineItemsPreparedForPickup")
{
    public FulfillmentOrderLineItemsPreparedForPickupQueryBuilder AddArgumentInput(FulfillmentOrderLineItemsPreparedForPickupInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}