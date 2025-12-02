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

public class ProductFeedCreatePayloadQueryBuilder() : GraphQueryBuilder<ProductFeedCreatePayload>("productFeedCreatePayload")
{
    public ProductFeedCreatePayloadQueryBuilder AddFieldProductFeed(Func<ProductFeedQueryBuilder, ProductFeedQueryBuilder> build)
    {
        AddField<ProductFeed, ProductFeedQueryBuilder>("productFeed", build);
        return this;
    }

    public ProductFeedCreatePayloadQueryBuilder AddFieldUserErrors(Func<ProductFeedCreateUserErrorQueryBuilder, ProductFeedCreateUserErrorQueryBuilder> build)
    {
        AddField<ProductFeedCreateUserError, ProductFeedCreateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}