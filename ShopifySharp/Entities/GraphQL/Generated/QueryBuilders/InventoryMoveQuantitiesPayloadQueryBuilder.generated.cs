#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class InventoryMoveQuantitiesPayloadQueryBuilder() : GraphQueryBuilder<InventoryMoveQuantitiesPayload>("inventoryMoveQuantitiesPayload")
{
    public InventoryMoveQuantitiesPayloadQueryBuilder AddFieldInventoryAdjustmentGroup(Func<InventoryAdjustmentGroupQueryBuilder, InventoryAdjustmentGroupQueryBuilder> build)
    {
        AddField<InventoryAdjustmentGroup, InventoryAdjustmentGroupQueryBuilder>("inventoryAdjustmentGroup", build);
        return this;
    }

    public InventoryMoveQuantitiesPayloadQueryBuilder AddFieldUserErrors(Func<InventoryMoveQuantitiesUserErrorQueryBuilder, InventoryMoveQuantitiesUserErrorQueryBuilder> build)
    {
        AddField<InventoryMoveQuantitiesUserError, InventoryMoveQuantitiesUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}