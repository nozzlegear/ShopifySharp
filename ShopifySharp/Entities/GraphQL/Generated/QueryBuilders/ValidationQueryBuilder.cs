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

public class ValidationQueryBuilder() : GraphQueryBuilder<Validation>("query validation")
{
    public ValidationQueryBuilder AddFieldBlockOnFailure()
    {
        AddField("blockOnFailure");
        return this;
    }

    public ValidationQueryBuilder AddFieldEnabled()
    {
        AddField("enabled");
        return this;
    }

    public ValidationQueryBuilder AddFieldErrorHistory()
    {
        AddField("errorHistory");
        return this;
    }

    public ValidationQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ValidationQueryBuilder AddFieldMetafield()
    {
        AddField("metafield");
        return this;
    }

    [Obsolete("This field will be removed in a future version. Use `QueryRoot.metafieldDefinitions` instead.")]
    public ValidationQueryBuilder AddFieldMetafieldDefinitions()
    {
        AddField("metafieldDefinitions");
        return this;
    }

    public ValidationQueryBuilder AddFieldMetafields()
    {
        AddField("metafields");
        return this;
    }

    public ValidationQueryBuilder AddFieldShopifyFunction()
    {
        AddField("shopifyFunction");
        return this;
    }

    public ValidationQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}