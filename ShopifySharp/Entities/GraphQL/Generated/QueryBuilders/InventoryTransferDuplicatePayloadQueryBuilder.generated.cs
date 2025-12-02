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

public class InventoryTransferDuplicatePayloadQueryBuilder() : GraphQueryBuilder<InventoryTransferDuplicatePayload>("inventoryTransferDuplicatePayload")
{
    public InventoryTransferDuplicatePayloadQueryBuilder AddFieldInventoryTransfer(Func<InventoryTransferQueryBuilder, InventoryTransferQueryBuilder> build)
    {
        AddField<InventoryTransfer, InventoryTransferQueryBuilder>("inventoryTransfer", build);
        return this;
    }

    public InventoryTransferDuplicatePayloadQueryBuilder AddFieldUserErrors(Func<InventoryTransferDuplicateUserErrorQueryBuilder, InventoryTransferDuplicateUserErrorQueryBuilder> build)
    {
        AddField<InventoryTransferDuplicateUserError, InventoryTransferDuplicateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}