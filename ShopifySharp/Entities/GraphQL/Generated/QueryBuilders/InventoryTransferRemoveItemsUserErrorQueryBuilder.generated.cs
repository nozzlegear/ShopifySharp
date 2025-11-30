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

public class InventoryTransferRemoveItemsUserErrorQueryBuilder() : GraphQueryBuilder<InventoryTransferRemoveItemsUserError>("inventoryTransferRemoveItemsUserError")
{
    public InventoryTransferRemoveItemsUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public InventoryTransferRemoveItemsUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public InventoryTransferRemoveItemsUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}