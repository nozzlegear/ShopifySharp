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

public class InventoryMoveQuantitiesPayloadQueryBuilder() : GraphQueryBuilder<InventoryMoveQuantitiesPayload>("query inventoryMoveQuantitiesPayload")
{
    public InventoryMoveQuantitiesPayloadQueryBuilder AddFieldInventoryAdjustmentGroup()
    {
        AddField("inventoryAdjustmentGroup");
        return this;
    }

    public InventoryMoveQuantitiesPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}