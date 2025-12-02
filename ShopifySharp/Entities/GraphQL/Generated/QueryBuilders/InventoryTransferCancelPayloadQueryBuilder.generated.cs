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

public class InventoryTransferCancelPayloadQueryBuilder() : GraphQueryBuilder<InventoryTransferCancelPayload>("inventoryTransferCancelPayload")
{
    public InventoryTransferCancelPayloadQueryBuilder AddFieldInventoryTransfer(Func<InventoryTransferQueryBuilder, InventoryTransferQueryBuilder> build)
    {
        AddField<InventoryTransfer, InventoryTransferQueryBuilder>("inventoryTransfer", build);
        return this;
    }

    public InventoryTransferCancelPayloadQueryBuilder AddFieldUserErrors(Func<InventoryTransferCancelUserErrorQueryBuilder, InventoryTransferCancelUserErrorQueryBuilder> build)
    {
        AddField<InventoryTransferCancelUserError, InventoryTransferCancelUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}