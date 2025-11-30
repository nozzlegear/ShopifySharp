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

public class MetafieldDefinitionTypeQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionType>("metafieldDefinitionType")
{
    public MetafieldDefinitionTypeQueryBuilder AddFieldCategory()
    {
        AddField("category");
        return this;
    }

    public MetafieldDefinitionTypeQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public MetafieldDefinitionTypeQueryBuilder AddFieldSupportedValidations(Func<MetafieldDefinitionSupportedValidationQueryBuilder, MetafieldDefinitionSupportedValidationQueryBuilder> build)
    {
        AddField<MetafieldDefinitionSupportedValidation, MetafieldDefinitionSupportedValidationQueryBuilder>("supportedValidations", build);
        return this;
    }

    public MetafieldDefinitionTypeQueryBuilder AddFieldSupportsDefinitionMigrations()
    {
        AddField("supportsDefinitionMigrations");
        return this;
    }

    [Obsolete("`valueType` is deprecated and `name` should be used for type information.")]
    public MetafieldDefinitionTypeQueryBuilder AddFieldValueType()
    {
        AddField("valueType");
        return this;
    }
}