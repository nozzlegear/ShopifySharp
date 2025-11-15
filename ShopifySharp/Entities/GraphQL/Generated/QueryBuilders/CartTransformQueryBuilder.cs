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

public class CartTransformQueryBuilder() : GraphQueryBuilder<CartTransform>("query cartTransform")
{
    public CartTransformQueryBuilder AddFieldBlockOnFailure()
    {
        AddField("blockOnFailure");
        return this;
    }

    public CartTransformQueryBuilder AddFieldFunctionId()
    {
        AddField("functionId");
        return this;
    }

    public CartTransformQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CartTransformQueryBuilder AddFieldMetafield()
    {
        AddField("metafield");
        return this;
    }

    public CartTransformQueryBuilder AddFieldMetafields()
    {
        AddField("metafields");
        return this;
    }
}