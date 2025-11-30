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

public class InventoryTransferSetItemsPayloadQueryBuilder() : GraphQueryBuilder<InventoryTransferSetItemsPayload>("inventoryTransferSetItemsPayload")
{
    public InventoryTransferSetItemsPayloadQueryBuilder AddFieldInventoryTransfer(Func<InventoryTransferQueryBuilder, InventoryTransferQueryBuilder> build)
    {
        AddField<InventoryTransfer, InventoryTransferQueryBuilder>("inventoryTransfer", build);
        return this;
    }

    public InventoryTransferSetItemsPayloadQueryBuilder AddFieldUpdatedLineItems(Func<InventoryTransferLineItemUpdateQueryBuilder, InventoryTransferLineItemUpdateQueryBuilder> build)
    {
        AddField<InventoryTransferLineItemUpdate, InventoryTransferLineItemUpdateQueryBuilder>("updatedLineItems", build);
        return this;
    }

    public InventoryTransferSetItemsPayloadQueryBuilder AddFieldUserErrors(Func<InventoryTransferSetItemsUserErrorQueryBuilder, InventoryTransferSetItemsUserErrorQueryBuilder> build)
    {
        AddField<InventoryTransferSetItemsUserError, InventoryTransferSetItemsUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}