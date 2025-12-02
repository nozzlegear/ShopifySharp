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

public class ProductOptionsCreatePayloadQueryBuilder() : GraphQueryBuilder<ProductOptionsCreatePayload>("productOptionsCreatePayload")
{
    public ProductOptionsCreatePayloadQueryBuilder AddFieldProduct(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddField<Product, ProductQueryBuilder>("product", build);
        return this;
    }

    public ProductOptionsCreatePayloadQueryBuilder AddFieldUserErrors(Func<ProductOptionsCreateUserErrorQueryBuilder, ProductOptionsCreateUserErrorQueryBuilder> build)
    {
        AddField<ProductOptionsCreateUserError, ProductOptionsCreateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}