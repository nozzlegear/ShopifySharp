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

public class InventoryTransferEditPayloadQueryBuilder() : GraphQueryBuilder<InventoryTransferEditPayload>("inventoryTransferEditPayload")
{
    public InventoryTransferEditPayloadQueryBuilder AddFieldInventoryTransfer(Func<InventoryTransferQueryBuilder, InventoryTransferQueryBuilder> build)
    {
        AddField<InventoryTransfer, InventoryTransferQueryBuilder>("inventoryTransfer", build);
        return this;
    }

    public InventoryTransferEditPayloadQueryBuilder AddFieldUserErrors(Func<InventoryTransferEditUserErrorQueryBuilder, InventoryTransferEditUserErrorQueryBuilder> build)
    {
        AddField<InventoryTransferEditUserError, InventoryTransferEditUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}