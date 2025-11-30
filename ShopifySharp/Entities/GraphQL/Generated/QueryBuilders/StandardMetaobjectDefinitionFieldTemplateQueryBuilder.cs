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

public class StandardMetaobjectDefinitionFieldTemplateQueryBuilder() : GraphQueryBuilder<StandardMetaobjectDefinitionFieldTemplate>("query standardMetaobjectDefinitionFieldTemplate")
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

    public StandardMetaobjectDefinitionFieldTemplateQueryBuilder AddFieldType()
    {
        AddField("type");
        return this;
    }

    public StandardMetaobjectDefinitionFieldTemplateQueryBuilder AddFieldValidations()
    {
        AddField("validations");
        return this;
    }

    public StandardMetaobjectDefinitionFieldTemplateQueryBuilder AddFieldVisibleToStorefrontApi()
    {
        AddField("visibleToStorefrontApi");
        return this;
    }
}