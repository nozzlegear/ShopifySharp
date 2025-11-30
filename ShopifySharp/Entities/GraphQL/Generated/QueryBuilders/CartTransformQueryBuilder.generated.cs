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

public class CartTransformQueryBuilder() : GraphQueryBuilder<CartTransform>("cartTransform")
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

    public CartTransformQueryBuilder AddFieldMetafield(Func<MetafieldQueryBuilder, MetafieldQueryBuilder> build)
    {
        AddField<Metafield, MetafieldQueryBuilder>("metafield", build);
        return this;
    }

    public CartTransformQueryBuilder AddFieldMetafields(Func<MetafieldConnectionQueryBuilder, MetafieldConnectionQueryBuilder> build)
    {
        AddField<MetafieldConnection, MetafieldConnectionQueryBuilder>("metafields", build);
        return this;
    }
}