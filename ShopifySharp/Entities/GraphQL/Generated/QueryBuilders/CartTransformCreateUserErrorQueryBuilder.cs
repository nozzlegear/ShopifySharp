#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class CartTransformCreateUserErrorQueryBuilder() : GraphQueryBuilder<CartTransformCreateUserError>("query cartTransformCreateUserError")
{
    public CartTransformCreateUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public CartTransformCreateUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public CartTransformCreateUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}