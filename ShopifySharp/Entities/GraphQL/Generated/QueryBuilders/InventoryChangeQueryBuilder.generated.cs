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

public class InventoryChangeQueryBuilder() : GraphQueryBuilder<InventoryChange>("inventoryChange")
{
    public InventoryChangeQueryBuilder AddFieldDelta()
    {
        AddField("delta");
        return this;
    }

    public InventoryChangeQueryBuilder AddFieldItem(Func<InventoryItemQueryBuilder, InventoryItemQueryBuilder> build)
    {
        AddField<InventoryItem, InventoryItemQueryBuilder>("item", build);
        return this;
    }

    public InventoryChangeQueryBuilder AddFieldLedgerDocumentUri()
    {
        AddField("ledgerDocumentUri");
        return this;
    }

    public InventoryChangeQueryBuilder AddFieldLocation(Func<LocationQueryBuilder, LocationQueryBuilder> build)
    {
        AddField<Location, LocationQueryBuilder>("location", build);
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