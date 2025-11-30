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

public class InventoryTransferCreatePayloadQueryBuilder() : GraphQueryBuilder<InventoryTransferCreatePayload>("inventoryTransferCreatePayload")
{
    public InventoryTransferCreatePayloadQueryBuilder AddFieldInventoryTransfer(Func<InventoryTransferQueryBuilder, InventoryTransferQueryBuilder> build)
    {
        AddField<InventoryTransfer, InventoryTransferQueryBuilder>("inventoryTransfer", build);
        return this;
    }

    public InventoryTransferCreatePayloadQueryBuilder AddFieldUserErrors(Func<InventoryTransferCreateUserErrorQueryBuilder, InventoryTransferCreateUserErrorQueryBuilder> build)
    {
        AddField<InventoryTransferCreateUserError, InventoryTransferCreateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}