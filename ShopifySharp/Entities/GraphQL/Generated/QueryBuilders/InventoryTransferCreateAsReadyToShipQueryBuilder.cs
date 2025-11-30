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

public class InventoryTransferCreateAsReadyToShipQueryBuilder() : GraphQueryBuilder<InventoryTransferCreateAsReadyToShipPayload>("query inventoryTransferCreateAsReadyToShip")
{
    public InventoryTransferCreateAsReadyToShipQueryBuilder AddArgumentInput(InventoryTransferCreateAsReadyToShipInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}