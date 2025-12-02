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

public class ProductCreateMediaPayloadQueryBuilder() : GraphQueryBuilder<ProductCreateMediaPayload>("productCreateMediaPayload")
{
    public ProductCreateMediaPayloadQueryBuilder AddFieldMedia(Func<MediaQueryBuilder, MediaQueryBuilder> build)
    {
        AddField<IMedia, MediaQueryBuilder>("media", build);
        return this;
    }

    public ProductCreateMediaPayloadQueryBuilder AddFieldMediaUserErrors(Func<MediaUserErrorQueryBuilder, MediaUserErrorQueryBuilder> build)
    {
        AddField<MediaUserError, MediaUserErrorQueryBuilder>("mediaUserErrors", build);
        return this;
    }

    public ProductCreateMediaPayloadQueryBuilder AddFieldProduct(Func<ProductQueryBuilder, ProductQueryBuilder> build)
    {
        AddField<Product, ProductQueryBuilder>("product", build);
        return this;
    }

    public ProductCreateMediaPayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}