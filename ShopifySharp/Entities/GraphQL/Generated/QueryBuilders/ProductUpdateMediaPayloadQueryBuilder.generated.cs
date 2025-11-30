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

public class ProductUpdateMediaPayloadQueryBuilder() : GraphQueryBuilder<ProductUpdateMediaPayload>("productUpdateMediaPayload")
{
    public ProductUpdateMediaPayloadQueryBuilder AddFieldMedia(Func<MediaQueryBuilder, MediaQueryBuilder> build)
    {
        AddField<IMedia, MediaQueryBuilder>("media", build);
        return this;
    }

    public ProductUpdateMediaPayloadQueryBuilder AddFieldMediaUserErrors(Func<MediaUserErrorQueryBuilder, MediaUserErrorQueryBuilder> build)
    {
        AddField<MediaUserError, MediaUserErrorQueryBuilder>("mediaUserErrors", build);
        return this;
    }

    public ProductUpdateMediaPayloadQueryBuilder AddFieldProduct(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddField<Product, ProductQueryBuilder>("product", build);
        return this;
    }

    public ProductUpdateMediaPayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}