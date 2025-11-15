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

public class InventoryShipmentUpdateItemQuantitiesQueryBuilder() : GraphQueryBuilder<InventoryShipmentUpdateItemQuantitiesPayload>("query inventoryShipmentUpdateItemQuantities")
{
    public InventoryShipmentUpdateItemQuantitiesQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public InventoryShipmentUpdateItemQuantitiesQueryBuilder AddArgumentItems(ICollection<InventoryShipmentUpdateItemQuantitiesInput>? items)
    {
        AddArgument("items", items);
        return this;
    }
}