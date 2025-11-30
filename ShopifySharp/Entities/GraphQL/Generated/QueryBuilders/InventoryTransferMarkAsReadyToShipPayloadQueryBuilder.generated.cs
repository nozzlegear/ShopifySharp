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

public class InventoryTransferMarkAsReadyToShipPayloadQueryBuilder() : GraphQueryBuilder<InventoryTransferMarkAsReadyToShipPayload>("inventoryTransferMarkAsReadyToShipPayload")
{
    public InventoryTransferMarkAsReadyToShipPayloadQueryBuilder AddFieldInventoryTransfer(Func<InventoryTransferQueryBuilder, InventoryTransferQueryBuilder> build)
    {
        AddField<InventoryTransfer, InventoryTransferQueryBuilder>("inventoryTransfer", build);
        return this;
    }

    public InventoryTransferMarkAsReadyToShipPayloadQueryBuilder AddFieldUserErrors(Func<InventoryTransferMarkAsReadyToShipUserErrorQueryBuilder, InventoryTransferMarkAsReadyToShipUserErrorQueryBuilder> build)
    {
        AddField<InventoryTransferMarkAsReadyToShipUserError, InventoryTransferMarkAsReadyToShipUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}