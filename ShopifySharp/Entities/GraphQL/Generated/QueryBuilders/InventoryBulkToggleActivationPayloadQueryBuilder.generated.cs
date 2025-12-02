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

public class InventoryBulkToggleActivationPayloadQueryBuilder() : GraphQueryBuilder<InventoryBulkToggleActivationPayload>("inventoryBulkToggleActivationPayload")
{
    public InventoryBulkToggleActivationPayloadQueryBuilder AddFieldInventoryItem(Func<InventoryItemQueryBuilder, InventoryItemQueryBuilder> build)
    {
        AddField<InventoryItem, InventoryItemQueryBuilder>("inventoryItem", build);
        return this;
    }

    public InventoryBulkToggleActivationPayloadQueryBuilder AddFieldInventoryLevels(Func<InventoryLevelQueryBuilder, InventoryLevelQueryBuilder> build)
    {
        AddField<InventoryLevel, InventoryLevelQueryBuilder>("inventoryLevels", build);
        return this;
    }

    public InventoryBulkToggleActivationPayloadQueryBuilder AddFieldUserErrors(Func<InventoryBulkToggleActivationUserErrorQueryBuilder, InventoryBulkToggleActivationUserErrorQueryBuilder> build)
    {
        AddField<InventoryBulkToggleActivationUserError, InventoryBulkToggleActivationUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}