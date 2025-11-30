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

public class ProductOptionsReorderPayloadQueryBuilder() : GraphQueryBuilder<ProductOptionsReorderPayload>("productOptionsReorderPayload")
{
    public ProductOptionsReorderPayloadQueryBuilder AddFieldProduct(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddField<Product, ProductQueryBuilder>("product", build);
        return this;
    }

    public ProductOptionsReorderPayloadQueryBuilder AddFieldUserErrors(Func<ProductOptionsReorderUserErrorQueryBuilder, ProductOptionsReorderUserErrorQueryBuilder> build)
    {
        AddField<ProductOptionsReorderUserError, ProductOptionsReorderUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}