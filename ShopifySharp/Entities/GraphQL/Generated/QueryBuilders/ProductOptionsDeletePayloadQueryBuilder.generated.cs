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

public class ProductOptionsDeletePayloadQueryBuilder() : GraphQueryBuilder<ProductOptionsDeletePayload>("productOptionsDeletePayload")
{
    public ProductOptionsDeletePayloadQueryBuilder AddFieldDeletedOptionsIds()
    {
        AddField("deletedOptionsIds");
        return this;
    }

    public ProductOptionsDeletePayloadQueryBuilder AddFieldProduct(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddField<Product, ProductQueryBuilder>("product", build);
        return this;
    }

    public ProductOptionsDeletePayloadQueryBuilder AddFieldUserErrors(Func<ProductOptionsDeleteUserErrorQueryBuilder, ProductOptionsDeleteUserErrorQueryBuilder> build)
    {
        AddField<ProductOptionsDeleteUserError, ProductOptionsDeleteUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}