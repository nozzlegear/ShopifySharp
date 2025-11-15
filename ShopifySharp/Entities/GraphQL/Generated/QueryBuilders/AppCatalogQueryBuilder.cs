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

public class AppCatalogQueryBuilder() : GraphQueryBuilder<AppCatalog>("query appCatalog")
{
    public AppCatalogQueryBuilder AddFieldApps()
    {
        AddField("apps");
        return this;
    }

    public AppCatalogQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public AppCatalogQueryBuilder AddFieldOperations()
    {
        AddField("operations");
        return this;
    }

    public AppCatalogQueryBuilder AddFieldPriceList()
    {
        AddField("priceList");
        return this;
    }

    public AppCatalogQueryBuilder AddFieldPublication()
    {
        AddField("publication");
        return this;
    }

    public AppCatalogQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public AppCatalogQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}