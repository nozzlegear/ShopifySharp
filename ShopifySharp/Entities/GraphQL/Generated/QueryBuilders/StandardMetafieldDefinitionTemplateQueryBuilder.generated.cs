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

public class StandardMetafieldDefinitionTemplateQueryBuilder() : GraphQueryBuilder<StandardMetafieldDefinitionTemplate>("standardMetafieldDefinitionTemplate")
{
    public StandardMetafieldDefinitionTemplateQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public StandardMetafieldDefinitionTemplateQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public StandardMetafieldDefinitionTemplateQueryBuilder AddFieldKey()
    {
        AddField("key");
        return this;
    }

    public StandardMetafieldDefinitionTemplateQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public StandardMetafieldDefinitionTemplateQueryBuilder AddFieldNamespace()
    {
        AddField("namespace");
        return this;
    }

    public StandardMetafieldDefinitionTemplateQueryBuilder AddFieldOwnerTypes()
    {
        AddField("ownerTypes");
        return this;
    }

    public StandardMetafieldDefinitionTemplateQueryBuilder AddFieldType(Func<MetafieldDefinitionTypeQueryBuilder, MetafieldDefinitionTypeQueryBuilder> build)
    {
        AddField<MetafieldDefinitionType, MetafieldDefinitionTypeQueryBuilder>("type", build);
        return this;
    }

    public StandardMetafieldDefinitionTemplateQueryBuilder AddFieldValidations(Func<MetafieldDefinitionValidationQueryBuilder, MetafieldDefinitionValidationQueryBuilder> build)
    {
        AddField<MetafieldDefinitionValidation, MetafieldDefinitionValidationQueryBuilder>("validations", build);
        return this;
    }

    public StandardMetafieldDefinitionTemplateQueryBuilder AddFieldVisibleToStorefrontApi()
    {
        AddField("visibleToStorefrontApi");
        return this;
    }
}