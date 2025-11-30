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

public class CatalogDeletePayloadQueryBuilder() : GraphQueryBuilder<CatalogDeletePayload>("catalogDeletePayload")
{
    public CatalogDeletePayloadQueryBuilder AddFieldDeletedId()
    {
        AddField("deletedId");
        return this;
    }

    public CatalogDeletePayloadQueryBuilder AddFieldUserErrors(Func<CatalogUserErrorQueryBuilder, CatalogUserErrorQueryBuilder> build)
    {
        AddField<CatalogUserError, CatalogUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}