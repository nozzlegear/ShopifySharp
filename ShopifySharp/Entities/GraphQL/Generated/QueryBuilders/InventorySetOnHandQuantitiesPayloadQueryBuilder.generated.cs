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

public class InventorySetOnHandQuantitiesPayloadQueryBuilder() : GraphQueryBuilder<InventorySetOnHandQuantitiesPayload>("inventorySetOnHandQuantitiesPayload")
{
    public InventorySetOnHandQuantitiesPayloadQueryBuilder AddFieldInventoryAdjustmentGroup(Func<InventoryAdjustmentGroupQueryBuilder, InventoryAdjustmentGroupQueryBuilder> build)
    {
        AddField<InventoryAdjustmentGroup, InventoryAdjustmentGroupQueryBuilder>("inventoryAdjustmentGroup", build);
        return this;
    }

    public InventorySetOnHandQuantitiesPayloadQueryBuilder AddFieldUserErrors(Func<InventorySetOnHandQuantitiesUserErrorQueryBuilder, InventorySetOnHandQuantitiesUserErrorQueryBuilder> build)
    {
        AddField<InventorySetOnHandQuantitiesUserError, InventorySetOnHandQuantitiesUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}