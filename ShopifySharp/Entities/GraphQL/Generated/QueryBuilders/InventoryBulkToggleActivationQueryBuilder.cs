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

public class InventoryBulkToggleActivationQueryBuilder() : GraphQueryBuilder<InventoryBulkToggleActivationPayload>("query inventoryBulkToggleActivation")
{
    public InventoryBulkToggleActivationQueryBuilder AddArgumentInventoryItemId(string? inventoryItemId)
    {
        AddArgument("inventoryItemId", inventoryItemId);
        return this;
    }

    public InventoryBulkToggleActivationQueryBuilder AddArgumentInventoryItemUpdates(ICollection<InventoryBulkToggleActivationInput>? inventoryItemUpdates)
    {
        AddArgument("inventoryItemUpdates", inventoryItemUpdates);
        return this;
    }
}