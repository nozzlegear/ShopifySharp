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

public class InventoryTransferSetItemsUserErrorQueryBuilder() : GraphQueryBuilder<InventoryTransferSetItemsUserError>("query inventoryTransferSetItemsUserError")
{
    public InventoryTransferSetItemsUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public InventoryTransferSetItemsUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public InventoryTransferSetItemsUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}