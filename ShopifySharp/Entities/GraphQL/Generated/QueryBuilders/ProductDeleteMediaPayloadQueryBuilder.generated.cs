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

public class ProductDeleteMediaPayloadQueryBuilder() : GraphQueryBuilder<ProductDeleteMediaPayload>("productDeleteMediaPayload")
{
    public ProductDeleteMediaPayloadQueryBuilder AddFieldDeletedMediaIds()
    {
        AddField("deletedMediaIds");
        return this;
    }

    public ProductDeleteMediaPayloadQueryBuilder AddFieldDeletedProductImageIds()
    {
        AddField("deletedProductImageIds");
        return this;
    }

    public ProductDeleteMediaPayloadQueryBuilder AddFieldMediaUserErrors(Func<MediaUserErrorQueryBuilder, MediaUserErrorQueryBuilder> build)
    {
        AddField<MediaUserError, MediaUserErrorQueryBuilder>("mediaUserErrors", build);
        return this;
    }

    public ProductDeleteMediaPayloadQueryBuilder AddFieldProduct(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddField<Product, ProductQueryBuilder>("product", build);
        return this;
    }

    public ProductDeleteMediaPayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}