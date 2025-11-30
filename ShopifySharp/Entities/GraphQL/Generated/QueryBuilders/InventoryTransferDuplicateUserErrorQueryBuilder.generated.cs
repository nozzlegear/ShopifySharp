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

public class InventoryTransferDuplicateUserErrorQueryBuilder() : GraphQueryBuilder<InventoryTransferDuplicateUserError>("inventoryTransferDuplicateUserError")
{
    public InventoryTransferDuplicateUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public InventoryTransferDuplicateUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public InventoryTransferDuplicateUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}