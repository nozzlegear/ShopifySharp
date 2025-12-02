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

public class StandardMetaobjectDefinitionFieldTemplateQueryBuilder() : GraphQueryBuilder<StandardMetaobjectDefinitionFieldTemplate>("standardMetaobjectDefinitionFieldTemplate")
{
    public StandardMetaobjectDefinitionFieldTemplateQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public StandardMetaobjectDefinitionFieldTemplateQueryBuilder AddFieldKey()
    {
        AddField("key");
        return this;
    }

    public StandardMetaobjectDefinitionFieldTemplateQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public StandardMetaobjectDefinitionFieldTemplateQueryBuilder AddFieldRequired()
    {
        AddField("required");
        return this;
    }

    public StandardMetaobjectDefinitionFieldTemplateQueryBuilder AddFieldType(Func<MetafieldDefinitionTypeQueryBuilder, MetafieldDefinitionTypeQueryBuilder> build)
    {
        AddField<MetafieldDefinitionType, MetafieldDefinitionTypeQueryBuilder>("type", build);
        return this;
    }

    public StandardMetaobjectDefinitionFieldTemplateQueryBuilder AddFieldValidations(Func<MetafieldDefinitionValidationQueryBuilder, MetafieldDefinitionValidationQueryBuilder> build)
    {
        AddField<MetafieldDefinitionValidation, MetafieldDefinitionValidationQueryBuilder>("validations", build);
        return this;
    }

    public StandardMetaobjectDefinitionFieldTemplateQueryBuilder AddFieldVisibleToStorefrontApi()
    {
        AddField("visibleToStorefrontApi");
        return this;
    }
}