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

public class InventoryShipmentUpdateItemQuantitiesPayloadQueryBuilder() : GraphQueryBuilder<InventoryShipmentUpdateItemQuantitiesPayload>("inventoryShipmentUpdateItemQuantitiesPayload")
{
    public InventoryShipmentUpdateItemQuantitiesPayloadQueryBuilder AddFieldShipment(Func<InventoryShipmentQueryBuilder, InventoryShipmentQueryBuilder> build)
    {
        AddField<InventoryShipment, InventoryShipmentQueryBuilder>("shipment", build);
        return this;
    }

    public InventoryShipmentUpdateItemQuantitiesPayloadQueryBuilder AddFieldUpdatedLineItems(Func<InventoryShipmentLineItemQueryBuilder, InventoryShipmentLineItemQueryBuilder> build)
    {
        AddField<InventoryShipmentLineItem, InventoryShipmentLineItemQueryBuilder>("updatedLineItems", build);
        return this;
    }

    public InventoryShipmentUpdateItemQuantitiesPayloadQueryBuilder AddFieldUserErrors(Func<InventoryShipmentUpdateItemQuantitiesUserErrorQueryBuilder, InventoryShipmentUpdateItemQuantitiesUserErrorQueryBuilder> build)
    {
        AddField<InventoryShipmentUpdateItemQuantitiesUserError, InventoryShipmentUpdateItemQuantitiesUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}