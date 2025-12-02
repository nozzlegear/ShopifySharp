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

public class InventoryAdjustQuantitiesPayloadQueryBuilder() : GraphQueryBuilder<InventoryAdjustQuantitiesPayload>("inventoryAdjustQuantitiesPayload")
{
    public InventoryAdjustQuantitiesPayloadQueryBuilder AddFieldInventoryAdjustmentGroup(Func<InventoryAdjustmentGroupQueryBuilder, InventoryAdjustmentGroupQueryBuilder> build)
    {
        AddField<InventoryAdjustmentGroup, InventoryAdjustmentGroupQueryBuilder>("inventoryAdjustmentGroup", build);
        return this;
    }

    public InventoryAdjustQuantitiesPayloadQueryBuilder AddFieldUserErrors(Func<InventoryAdjustQuantitiesUserErrorQueryBuilder, InventoryAdjustQuantitiesUserErrorQueryBuilder> build)
    {
        AddField<InventoryAdjustQuantitiesUserError, InventoryAdjustQuantitiesUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}