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

public class InventoryActivatePayloadQueryBuilder() : GraphQueryBuilder<InventoryActivatePayload>("inventoryActivatePayload")
{
    public InventoryActivatePayloadQueryBuilder AddFieldInventoryLevel(Func<InventoryLevelQueryBuilder, InventoryLevelQueryBuilder> build)
    {
        AddField<InventoryLevel, InventoryLevelQueryBuilder>("inventoryLevel", build);
        return this;
    }

    public InventoryActivatePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}