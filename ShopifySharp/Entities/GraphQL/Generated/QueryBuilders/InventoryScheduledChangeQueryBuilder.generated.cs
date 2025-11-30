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

public class InventoryScheduledChangeQueryBuilder() : GraphQueryBuilder<InventoryScheduledChange>("inventoryScheduledChange")
{
    public InventoryScheduledChangeQueryBuilder AddFieldExpectedAt()
    {
        AddField("expectedAt");
        return this;
    }

    public InventoryScheduledChangeQueryBuilder AddFieldFromName()
    {
        AddField("fromName");
        return this;
    }

    public InventoryScheduledChangeQueryBuilder AddFieldInventoryLevel(Func<InventoryLevelQueryBuilder, InventoryLevelQueryBuilder> build)
    {
        AddField<InventoryLevel, InventoryLevelQueryBuilder>("inventoryLevel", build);
        return this;
    }

    public InventoryScheduledChangeQueryBuilder AddFieldLedgerDocumentUri()
    {
        AddField("ledgerDocumentUri");
        return this;
    }

    public InventoryScheduledChangeQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public InventoryScheduledChangeQueryBuilder AddFieldToName()
    {
        AddField("toName");
        return this;
    }
}