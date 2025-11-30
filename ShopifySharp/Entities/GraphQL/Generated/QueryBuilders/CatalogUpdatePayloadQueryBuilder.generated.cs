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

public class CatalogUpdatePayloadQueryBuilder() : GraphQueryBuilder<CatalogUpdatePayload>("catalogUpdatePayload")
{
    public CatalogUpdatePayloadQueryBuilder AddFieldCatalog(Func<CatalogQueryBuilder, CatalogQueryBuilder> build)
    {
        AddField<ICatalog, CatalogQueryBuilder>("catalog", build);
        return this;
    }

    public CatalogUpdatePayloadQueryBuilder AddFieldUserErrors(Func<CatalogUserErrorQueryBuilder, CatalogUserErrorQueryBuilder> build)
    {
        AddField<CatalogUserError, CatalogUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}