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

public class FulfillmentServiceUpdateQueryBuilder() : GraphQueryBuilder<FulfillmentServiceUpdatePayload>("query fulfillmentServiceUpdate")
{
    public FulfillmentServiceUpdateQueryBuilder AddArgumentCallbackUrl(string? callbackUrl)
    {
        AddArgument("callbackUrl", callbackUrl);
        return this;
    }

    public FulfillmentServiceUpdateQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public FulfillmentServiceUpdateQueryBuilder AddArgumentInventoryManagement(bool? inventoryManagement)
    {
        AddArgument("inventoryManagement", inventoryManagement);
        return this;
    }

    public FulfillmentServiceUpdateQueryBuilder AddArgumentName(string? name)
    {
        AddArgument("name", name);
        return this;
    }

    public FulfillmentServiceUpdateQueryBuilder AddArgumentRequiresShippingMethod(bool? requiresShippingMethod)
    {
        AddArgument("requiresShippingMethod", requiresShippingMethod);
        return this;
    }

    public FulfillmentServiceUpdateQueryBuilder AddArgumentTrackingSupport(bool? trackingSupport)
    {
        AddArgument("trackingSupport", trackingSupport);
        return this;
    }
}