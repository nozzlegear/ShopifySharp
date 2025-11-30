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

public class CatalogContextUpdatePayloadQueryBuilder() : GraphQueryBuilder<CatalogContextUpdatePayload>("catalogContextUpdatePayload")
{
    public CatalogContextUpdatePayloadQueryBuilder AddFieldCatalog(Func<CatalogQueryBuilder, CatalogQueryBuilder> build)
    {
        AddField<ICatalog, CatalogQueryBuilder>("catalog", build);
        return this;
    }

    public CatalogContextUpdatePayloadQueryBuilder AddFieldUserErrors(Func<CatalogUserErrorQueryBuilder, CatalogUserErrorQueryBuilder> build)
    {
        AddField<CatalogUserError, CatalogUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}