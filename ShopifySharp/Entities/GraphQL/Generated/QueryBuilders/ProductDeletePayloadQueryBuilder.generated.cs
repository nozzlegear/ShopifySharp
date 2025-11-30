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

public class ProductDeletePayloadQueryBuilder() : GraphQueryBuilder<ProductDeletePayload>("productDeletePayload")
{
    public ProductDeletePayloadQueryBuilder AddFieldDeletedProductId()
    {
        AddField("deletedProductId");
        return this;
    }

    public ProductDeletePayloadQueryBuilder AddFieldProductDeleteOperation(Func<ProductDeleteOperationQueryBuilder, ProductDeleteOperationQueryBuilder> build)
    {
        AddField<ProductDeleteOperation, ProductDeleteOperationQueryBuilder>("productDeleteOperation", build);
        return this;
    }

    public ProductDeletePayloadQueryBuilder AddFieldShop(Func<ShopQueryBuilder, ShopQueryBuilder> build)
    {
        AddField<Shop, ShopQueryBuilder>("shop", build);
        return this;
    }

    public ProductDeletePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}