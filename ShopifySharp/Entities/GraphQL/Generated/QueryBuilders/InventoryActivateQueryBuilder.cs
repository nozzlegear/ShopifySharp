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

public class InventoryActivateQueryBuilder() : GraphQueryBuilder<InventoryActivatePayload>("query inventoryActivate")
{
    public InventoryActivateQueryBuilder AddArgumentAvailable(int? available)
    {
        AddArgument("available", available);
        return this;
    }

    public InventoryActivateQueryBuilder AddArgumentInventoryItemId(string? inventoryItemId)
    {
        AddArgument("inventoryItemId", inventoryItemId);
        return this;
    }

    public InventoryActivateQueryBuilder AddArgumentLocationId(string? locationId)
    {
        AddArgument("locationId", locationId);
        return this;
    }

    public InventoryActivateQueryBuilder AddArgumentOnHand(int? onHand)
    {
        AddArgument("onHand", onHand);
        return this;
    }

    public InventoryActivateQueryBuilder AddArgumentStockAtLegacyLocation(bool? stockAtLegacyLocation)
    {
        AddArgument("stockAtLegacyLocation", stockAtLegacyLocation);
        return this;
    }
}