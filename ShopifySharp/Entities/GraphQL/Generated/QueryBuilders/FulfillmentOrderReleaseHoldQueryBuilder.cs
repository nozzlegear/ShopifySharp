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

public class FulfillmentOrderReleaseHoldQueryBuilder() : GraphQueryBuilder<FulfillmentOrderReleaseHoldPayload>("query fulfillmentOrderReleaseHold")
{
    public FulfillmentOrderReleaseHoldQueryBuilder AddArgumentExternalId(string? externalId)
    {
        AddArgument("externalId", externalId);
        return this;
    }

    public FulfillmentOrderReleaseHoldQueryBuilder AddArgumentHoldIds(ICollection<string>? holdIds)
    {
        AddArgument("holdIds", holdIds);
        return this;
    }

    public FulfillmentOrderReleaseHoldQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }
}