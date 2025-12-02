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

public class InventoryTransferRemoveItemsPayloadQueryBuilder() : GraphQueryBuilder<InventoryTransferRemoveItemsPayload>("inventoryTransferRemoveItemsPayload")
{
    public InventoryTransferRemoveItemsPayloadQueryBuilder AddFieldInventoryTransfer(Func<InventoryTransferQueryBuilder, InventoryTransferQueryBuilder> build)
    {
        AddField<InventoryTransfer, InventoryTransferQueryBuilder>("inventoryTransfer", build);
        return this;
    }

    public InventoryTransferRemoveItemsPayloadQueryBuilder AddFieldRemovedQuantities(Func<InventoryTransferLineItemUpdateQueryBuilder, InventoryTransferLineItemUpdateQueryBuilder> build)
    {
        AddField<InventoryTransferLineItemUpdate, InventoryTransferLineItemUpdateQueryBuilder>("removedQuantities", build);
        return this;
    }

    public InventoryTransferRemoveItemsPayloadQueryBuilder AddFieldUserErrors(Func<InventoryTransferRemoveItemsUserErrorQueryBuilder, InventoryTransferRemoveItemsUserErrorQueryBuilder> build)
    {
        AddField<InventoryTransferRemoveItemsUserError, InventoryTransferRemoveItemsUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}