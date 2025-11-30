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

public class ProductOptionUpdatePayloadQueryBuilder() : GraphQueryBuilder<ProductOptionUpdatePayload>("productOptionUpdatePayload")
{
    public ProductOptionUpdatePayloadQueryBuilder AddFieldProduct(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddField<Product, ProductQueryBuilder>("product", build);
        return this;
    }

    public ProductOptionUpdatePayloadQueryBuilder AddFieldUserErrors(Func<ProductOptionUpdateUserErrorQueryBuilder, ProductOptionUpdateUserErrorQueryBuilder> build)
    {
        AddField<ProductOptionUpdateUserError, ProductOptionUpdateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}