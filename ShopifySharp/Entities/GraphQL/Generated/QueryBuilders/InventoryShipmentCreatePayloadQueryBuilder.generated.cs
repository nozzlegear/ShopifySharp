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

public class InventoryShipmentCreatePayloadQueryBuilder() : GraphQueryBuilder<InventoryShipmentCreatePayload>("inventoryShipmentCreatePayload")
{
    public InventoryShipmentCreatePayloadQueryBuilder AddFieldInventoryShipment(Func<InventoryShipmentQueryBuilder, InventoryShipmentQueryBuilder> build)
    {
        AddField<InventoryShipment, InventoryShipmentQueryBuilder>("inventoryShipment", build);
        return this;
    }

    public InventoryShipmentCreatePayloadQueryBuilder AddFieldUserErrors(Func<InventoryShipmentCreateUserErrorQueryBuilder, InventoryShipmentCreateUserErrorQueryBuilder> build)
    {
        AddField<InventoryShipmentCreateUserError, InventoryShipmentCreateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}