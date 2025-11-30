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

public class InventoryTransferMarkAsReadyToShipUserErrorQueryBuilder() : GraphQueryBuilder<InventoryTransferMarkAsReadyToShipUserError>("inventoryTransferMarkAsReadyToShipUserError")
{
    public InventoryTransferMarkAsReadyToShipUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public InventoryTransferMarkAsReadyToShipUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public InventoryTransferMarkAsReadyToShipUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}