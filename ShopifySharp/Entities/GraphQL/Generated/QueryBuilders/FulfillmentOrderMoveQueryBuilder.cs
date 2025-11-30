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

public class FulfillmentOrderMoveQueryBuilder() : GraphQueryBuilder<FulfillmentOrderMovePayload>("query fulfillmentOrderMove")
{
    public FulfillmentOrderMoveQueryBuilder AddArgumentFulfillmentOrderLineItems(ICollection<FulfillmentOrderLineItemInput>? fulfillmentOrderLineItems)
    {
        AddArgument("fulfillmentOrderLineItems", fulfillmentOrderLineItems);
        return this;
    }

    public FulfillmentOrderMoveQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public FulfillmentOrderMoveQueryBuilder AddArgumentNewLocationId(string? newLocationId)
    {
        AddArgument("newLocationId", newLocationId);
        return this;
    }
}