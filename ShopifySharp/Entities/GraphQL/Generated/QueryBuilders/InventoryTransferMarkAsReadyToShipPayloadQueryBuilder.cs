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

public class InventoryTransferMarkAsReadyToShipPayloadQueryBuilder() : GraphQueryBuilder<InventoryTransferMarkAsReadyToShipPayload>("query inventoryTransferMarkAsReadyToShipPayload")
{
    public InventoryTransferMarkAsReadyToShipPayloadQueryBuilder AddFieldInventoryTransfer()
    {
        AddField("inventoryTransfer");
        return this;
    }

    public InventoryTransferMarkAsReadyToShipPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}