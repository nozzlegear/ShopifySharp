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

public class InventoryShipmentRemoveItemsPayloadQueryBuilder() : GraphQueryBuilder<InventoryShipmentRemoveItemsPayload>("inventoryShipmentRemoveItemsPayload")
{
    public InventoryShipmentRemoveItemsPayloadQueryBuilder AddFieldInventoryShipment(Func<InventoryShipmentQueryBuilder, InventoryShipmentQueryBuilder> build)
    {
        AddField<InventoryShipment, InventoryShipmentQueryBuilder>("inventoryShipment", build);
        return this;
    }

    public InventoryShipmentRemoveItemsPayloadQueryBuilder AddFieldUserErrors(Func<InventoryShipmentRemoveItemsUserErrorQueryBuilder, InventoryShipmentRemoveItemsUserErrorQueryBuilder> build)
    {
        AddField<InventoryShipmentRemoveItemsUserError, InventoryShipmentRemoveItemsUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}