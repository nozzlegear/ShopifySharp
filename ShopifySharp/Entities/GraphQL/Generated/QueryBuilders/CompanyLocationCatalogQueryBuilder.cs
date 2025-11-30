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

public class CompanyLocationCatalogQueryBuilder() : GraphQueryBuilder<CompanyLocationCatalog>("query companyLocationCatalog")
{
    public CompanyLocationCatalogQueryBuilder AddFieldCompanyLocations()
    {
        AddField("companyLocations");
        return this;
    }

    public CompanyLocationCatalogQueryBuilder AddFieldCompanyLocationsCount()
    {
        AddField("companyLocationsCount");
        return this;
    }

    public CompanyLocationCatalogQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CompanyLocationCatalogQueryBuilder AddFieldOperations()
    {
        AddField("operations");
        return this;
    }

    public CompanyLocationCatalogQueryBuilder AddFieldPriceList()
    {
        AddField("priceList");
        return this;
    }

    public CompanyLocationCatalogQueryBuilder AddFieldPublication()
    {
        AddField("publication");
        return this;
    }

    public CompanyLocationCatalogQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public CompanyLocationCatalogQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}