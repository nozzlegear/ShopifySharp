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

public class InventoryShipmentCreateQueryBuilder() : GraphQueryBuilder<InventoryShipmentCreatePayload>("query inventoryShipmentCreate")
{
    public InventoryShipmentCreateQueryBuilder AddArgumentInput(InventoryShipmentCreateInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}