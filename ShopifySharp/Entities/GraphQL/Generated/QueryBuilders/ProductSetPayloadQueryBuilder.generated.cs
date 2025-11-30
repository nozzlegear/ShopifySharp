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

public class ProductSetPayloadQueryBuilder() : GraphQueryBuilder<ProductSetPayload>("productSetPayload")
{
    public ProductSetPayloadQueryBuilder AddFieldProduct(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddField<Product, ProductQueryBuilder>("product", build);
        return this;
    }

    public ProductSetPayloadQueryBuilder AddFieldProductSetOperation(Func<ProductSetOperationQueryBuilder, ProductSetOperationQueryBuilder> build)
    {
        AddField<ProductSetOperation, ProductSetOperationQueryBuilder>("productSetOperation", build);
        return this;
    }

    public ProductSetPayloadQueryBuilder AddFieldUserErrors(Func<ProductSetUserErrorQueryBuilder, ProductSetUserErrorQueryBuilder> build)
    {
        AddField<ProductSetUserError, ProductSetUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}