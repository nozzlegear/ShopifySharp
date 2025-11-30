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

public class InventoryScheduledChangeQueryBuilder() : GraphQueryBuilder<InventoryScheduledChange>("query inventoryScheduledChange")
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

    public InventoryScheduledChangeQueryBuilder AddFieldInventoryLevel()
    {
        AddField("inventoryLevel");
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