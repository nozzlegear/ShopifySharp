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

public class MetafieldDefinitionTypeQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionType>("query metafieldDefinitionType")
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

    public MetafieldDefinitionTypeQueryBuilder AddFieldSupportedValidations()
    {
        AddField("supportedValidations");
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