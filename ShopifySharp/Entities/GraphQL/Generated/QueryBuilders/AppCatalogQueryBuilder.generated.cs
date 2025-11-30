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

public class AppCatalogQueryBuilder() : GraphQueryBuilder<AppCatalog>("appCatalog")
{
    public AppCatalogQueryBuilder AddFieldApps(Func<AppConnectionQueryBuilder, AppConnectionQueryBuilder> build)
    {
        AddField<AppConnection, AppConnectionQueryBuilder>("apps", build);
        return this;
    }

    public AppCatalogQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public AppCatalogQueryBuilder AddFieldOperations(Func<ResourceOperationQueryBuilder, ResourceOperationQueryBuilder> build)
    {
        AddField<IResourceOperation, ResourceOperationQueryBuilder>("operations", build);
        return this;
    }

    public AppCatalogQueryBuilder AddFieldPriceList(Func<PriceListQueryBuilder, PriceListQueryBuilder> build)
    {
        AddField<PriceList, PriceListQueryBuilder>("priceList", build);
        return this;
    }

    public AppCatalogQueryBuilder AddFieldPublication(Func<PublicationQueryBuilder, PublicationQueryBuilder> build)
    {
        AddField<Publication, PublicationQueryBuilder>("publication", build);
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