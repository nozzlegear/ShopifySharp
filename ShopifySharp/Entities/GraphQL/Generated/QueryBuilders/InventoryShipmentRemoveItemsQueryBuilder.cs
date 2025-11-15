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

public class InventoryShipmentRemoveItemsQueryBuilder() : GraphQueryBuilder<InventoryShipmentRemoveItemsPayload>("query inventoryShipmentRemoveItems")
{
    public InventoryShipmentRemoveItemsQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public InventoryShipmentRemoveItemsQueryBuilder AddArgumentLineItems(ICollection<string>? lineItems)
    {
        AddArgument("lineItems", lineItems);
        return this;
    }
}