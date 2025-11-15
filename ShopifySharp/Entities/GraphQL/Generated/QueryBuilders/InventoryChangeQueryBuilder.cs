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

public class InventoryChangeQueryBuilder() : GraphQueryBuilder<InventoryChange>("query inventoryChange")
{
    public InventoryChangeQueryBuilder AddFieldDelta()
    {
        AddField("delta");
        return this;
    }

    public InventoryChangeQueryBuilder AddFieldItem()
    {
        AddField("item");
        return this;
    }

    public InventoryChangeQueryBuilder AddFieldLedgerDocumentUri()
    {
        AddField("ledgerDocumentUri");
        return this;
    }

    public InventoryChangeQueryBuilder AddFieldLocation()
    {
        AddField("location");
        return this;
    }

    public InventoryChangeQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public InventoryChangeQueryBuilder AddFieldQuantityAfterChange()
    {
        AddField("quantityAfterChange");
        return this;
    }
}