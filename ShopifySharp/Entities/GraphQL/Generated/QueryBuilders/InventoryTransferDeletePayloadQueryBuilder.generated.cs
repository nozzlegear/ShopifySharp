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

public class InventoryTransferDeletePayloadQueryBuilder() : GraphQueryBuilder<InventoryTransferDeletePayload>("inventoryTransferDeletePayload")
{
    public InventoryTransferDeletePayloadQueryBuilder AddFieldDeletedId()
    {
        AddField("deletedId");
        return this;
    }

    public InventoryTransferDeletePayloadQueryBuilder AddFieldUserErrors(Func<InventoryTransferDeleteUserErrorQueryBuilder, InventoryTransferDeleteUserErrorQueryBuilder> build)
    {
        AddField<InventoryTransferDeleteUserError, InventoryTransferDeleteUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}