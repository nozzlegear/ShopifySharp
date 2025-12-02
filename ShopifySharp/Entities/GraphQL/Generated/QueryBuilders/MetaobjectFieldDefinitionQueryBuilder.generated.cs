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

public class MetaobjectFieldDefinitionQueryBuilder() : GraphQueryBuilder<MetaobjectFieldDefinition>("metaobjectFieldDefinition")
{
    public MetaobjectFieldDefinitionQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public MetaobjectFieldDefinitionQueryBuilder AddFieldKey()
    {
        AddField("key");
        return this;
    }

    public MetaobjectFieldDefinitionQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public MetaobjectFieldDefinitionQueryBuilder AddFieldRequired()
    {
        AddField("required");
        return this;
    }

    public MetaobjectFieldDefinitionQueryBuilder AddFieldType(Func<MetafieldDefinitionTypeQueryBuilder, MetafieldDefinitionTypeQueryBuilder> build)
    {
        AddField<MetafieldDefinitionType, MetafieldDefinitionTypeQueryBuilder>("type", build);
        return this;
    }

    public MetaobjectFieldDefinitionQueryBuilder AddFieldValidations(Func<MetafieldDefinitionValidationQueryBuilder, MetafieldDefinitionValidationQueryBuilder> build)
    {
        AddField<MetafieldDefinitionValidation, MetafieldDefinitionValidationQueryBuilder>("validations", build);
        return this;
    }
}