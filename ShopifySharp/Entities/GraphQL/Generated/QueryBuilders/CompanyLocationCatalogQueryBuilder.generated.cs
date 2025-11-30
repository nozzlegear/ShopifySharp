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

public class CompanyLocationCatalogQueryBuilder() : GraphQueryBuilder<CompanyLocationCatalog>("companyLocationCatalog")
{
    public CompanyLocationCatalogQueryBuilder AddFieldCompanyLocations(Func<CompanyLocationConnectionQueryBuilder, CompanyLocationConnectionQueryBuilder> build)
    {
        AddField<CompanyLocationConnection, CompanyLocationConnectionQueryBuilder>("companyLocations", build);
        return this;
    }

    public CompanyLocationCatalogQueryBuilder AddFieldCompanyLocationsCount(Func<CountQueryBuilder, CountQueryBuilder> build)
    {
        AddField<Count, CountQueryBuilder>("companyLocationsCount", build);
        return this;
    }

    public CompanyLocationCatalogQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CompanyLocationCatalogQueryBuilder AddFieldOperations(Func<ResourceOperationQueryBuilder, ResourceOperationQueryBuilder> build)
    {
        AddField<IResourceOperation, ResourceOperationQueryBuilder>("operations", build);
        return this;
    }

    public CompanyLocationCatalogQueryBuilder AddFieldPriceList(Func<PriceListQueryBuilder, PriceListQueryBuilder> build)
    {
        AddField<PriceList, PriceListQueryBuilder>("priceList", build);
        return this;
    }

    public CompanyLocationCatalogQueryBuilder AddFieldPublication(Func<PublicationQueryBuilder, PublicationQueryBuilder> build)
    {
        AddField<Publication, PublicationQueryBuilder>("publication", build);
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