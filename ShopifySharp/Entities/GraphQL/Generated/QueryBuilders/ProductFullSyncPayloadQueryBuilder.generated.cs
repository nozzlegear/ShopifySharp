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

public class ProductFullSyncPayloadQueryBuilder() : GraphQueryBuilder<ProductFullSyncPayload>("productFullSyncPayload")
{
    public ProductFullSyncPayloadQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ProductFullSyncPayloadQueryBuilder AddFieldUserErrors(Func<ProductFullSyncUserErrorQueryBuilder, ProductFullSyncUserErrorQueryBuilder> build)
    {
        AddField<ProductFullSyncUserError, ProductFullSyncUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}