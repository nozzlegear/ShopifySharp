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

public class InventorySetScheduledChangesPayloadQueryBuilder() : GraphQueryBuilder<InventorySetScheduledChangesPayload>("inventorySetScheduledChangesPayload")
{
    public InventorySetScheduledChangesPayloadQueryBuilder AddFieldScheduledChanges(Func<InventoryScheduledChangeQueryBuilder, InventoryScheduledChangeQueryBuilder> build)
    {
        AddField<InventoryScheduledChange, InventoryScheduledChangeQueryBuilder>("scheduledChanges", build);
        return this;
    }

    public InventorySetScheduledChangesPayloadQueryBuilder AddFieldUserErrors(Func<InventorySetScheduledChangesUserErrorQueryBuilder, InventorySetScheduledChangesUserErrorQueryBuilder> build)
    {
        AddField<InventorySetScheduledChangesUserError, InventorySetScheduledChangesUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}