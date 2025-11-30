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

public class CartTransformCreatePayloadQueryBuilder() : GraphQueryBuilder<CartTransformCreatePayload>("cartTransformCreatePayload")
{
    public CartTransformCreatePayloadQueryBuilder AddFieldCartTransform(Func<CartTransformQueryBuilder, CartTransformQueryBuilder> build)
    {
        AddField<CartTransform, CartTransformQueryBuilder>("cartTransform", build);
        return this;
    }

    public CartTransformCreatePayloadQueryBuilder AddFieldUserErrors(Func<CartTransformCreateUserErrorQueryBuilder, CartTransformCreateUserErrorQueryBuilder> build)
    {
        AddField<CartTransformCreateUserError, CartTransformCreateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}