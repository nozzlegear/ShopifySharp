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

public class ICatalogQueryBuilder() : GraphQueryBuilder<ICatalog>("query iCatalog")
{
    public ICatalogQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ICatalogQueryBuilder AddFieldOperations()
    {
        AddField("operations");
        return this;
    }

    public ICatalogQueryBuilder AddFieldPriceList()
    {
        AddField("priceList");
        return this;
    }

    public ICatalogQueryBuilder AddFieldPublication()
    {
        AddField("publication");
        return this;
    }

    public ICatalogQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public ICatalogQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}