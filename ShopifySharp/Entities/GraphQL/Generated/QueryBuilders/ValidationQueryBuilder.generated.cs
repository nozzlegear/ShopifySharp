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

public class ValidationQueryBuilder() : GraphQueryBuilder<Validation>("validation")
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

    public ValidationQueryBuilder AddFieldErrorHistory(Func<FunctionsErrorHistoryQueryBuilder, FunctionsErrorHistoryQueryBuilder> build)
    {
        AddField<FunctionsErrorHistory, FunctionsErrorHistoryQueryBuilder>("errorHistory", build);
        return this;
    }

    public ValidationQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ValidationQueryBuilder AddFieldMetafield(Func<MetafieldQueryBuilder, MetafieldQueryBuilder> build)
    {
        AddField<Metafield, MetafieldQueryBuilder>("metafield", build);
        return this;
    }

    public ValidationQueryBuilder AddFieldMetafieldDefinitions(Func<MetafieldDefinitionConnectionQueryBuilder, MetafieldDefinitionConnectionQueryBuilder> build)
    {
        AddField<MetafieldDefinitionConnection, MetafieldDefinitionConnectionQueryBuilder>("metafieldDefinitions", build);
        return this;
    }

    public ValidationQueryBuilder AddFieldMetafields(Func<MetafieldConnectionQueryBuilder, MetafieldConnectionQueryBuilder> build)
    {
        AddField<MetafieldConnection, MetafieldConnectionQueryBuilder>("metafields", build);
        return this;
    }

    public ValidationQueryBuilder AddFieldShopifyFunction(Func<ShopifyFunctionQueryBuilder, ShopifyFunctionQueryBuilder> build)
    {
        AddField<ShopifyFunction, ShopifyFunctionQueryBuilder>("shopifyFunction", build);
        return this;
    }

    public ValidationQueryBuilder AddFieldTitle()
    {
        AddField("title");
        return this;
    }
}