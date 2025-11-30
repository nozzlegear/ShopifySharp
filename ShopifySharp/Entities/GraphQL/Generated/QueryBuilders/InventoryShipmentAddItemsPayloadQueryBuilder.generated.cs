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

public class InventoryShipmentAddItemsPayloadQueryBuilder() : GraphQueryBuilder<InventoryShipmentAddItemsPayload>("inventoryShipmentAddItemsPayload")
{
    public InventoryShipmentAddItemsPayloadQueryBuilder AddFieldAddedItems(Func<InventoryShipmentLineItemQueryBuilder, InventoryShipmentLineItemQueryBuilder> build)
    {
        AddField<InventoryShipmentLineItem, InventoryShipmentLineItemQueryBuilder>("addedItems", build);
        return this;
    }

    public InventoryShipmentAddItemsPayloadQueryBuilder AddFieldInventoryShipment(Func<InventoryShipmentQueryBuilder, InventoryShipmentQueryBuilder> build)
    {
        AddField<InventoryShipment, InventoryShipmentQueryBuilder>("inventoryShipment", build);
        return this;
    }

    public InventoryShipmentAddItemsPayloadQueryBuilder AddFieldUserErrors(Func<InventoryShipmentAddItemsUserErrorQueryBuilder, InventoryShipmentAddItemsUserErrorQueryBuilder> build)
    {
        AddField<InventoryShipmentAddItemsUserError, InventoryShipmentAddItemsUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}