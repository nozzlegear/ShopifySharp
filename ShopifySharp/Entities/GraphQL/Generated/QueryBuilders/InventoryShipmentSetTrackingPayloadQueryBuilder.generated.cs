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

public class InventoryShipmentSetTrackingPayloadQueryBuilder() : GraphQueryBuilder<InventoryShipmentSetTrackingPayload>("inventoryShipmentSetTrackingPayload")
{
    public InventoryShipmentSetTrackingPayloadQueryBuilder AddFieldInventoryShipment(Func<InventoryShipmentQueryBuilder, InventoryShipmentQueryBuilder> build)
    {
        AddField<InventoryShipment, InventoryShipmentQueryBuilder>("inventoryShipment", build);
        return this;
    }

    public InventoryShipmentSetTrackingPayloadQueryBuilder AddFieldUserErrors(Func<InventoryShipmentSetTrackingUserErrorQueryBuilder, InventoryShipmentSetTrackingUserErrorQueryBuilder> build)
    {
        AddField<InventoryShipmentSetTrackingUserError, InventoryShipmentSetTrackingUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}