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

public class InventoryBulkToggleActivationQueryBuilder() : GraphQueryBuilder<InventoryBulkToggleActivationPayload>("inventoryBulkToggleActivation"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

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