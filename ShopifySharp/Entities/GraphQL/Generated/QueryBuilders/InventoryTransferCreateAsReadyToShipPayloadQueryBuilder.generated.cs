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

public class InventoryTransferCreateAsReadyToShipPayloadQueryBuilder() : GraphQueryBuilder<InventoryTransferCreateAsReadyToShipPayload>("inventoryTransferCreateAsReadyToShipPayload")
{
    public InventoryTransferCreateAsReadyToShipPayloadQueryBuilder AddFieldInventoryTransfer(Func<InventoryTransferQueryBuilder, InventoryTransferQueryBuilder> build)
    {
        AddField<InventoryTransfer, InventoryTransferQueryBuilder>("inventoryTransfer", build);
        return this;
    }

    public InventoryTransferCreateAsReadyToShipPayloadQueryBuilder AddFieldUserErrors(Func<InventoryTransferCreateAsReadyToShipUserErrorQueryBuilder, InventoryTransferCreateAsReadyToShipUserErrorQueryBuilder> build)
    {
        AddField<InventoryTransferCreateAsReadyToShipUserError, InventoryTransferCreateAsReadyToShipUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}