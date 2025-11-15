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

public class StandardMetafieldDefinitionTemplateQueryBuilder() : GraphQueryBuilder<StandardMetafieldDefinitionTemplate>("query standardMetafieldDefinitionTemplate")
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

    public StandardMetafieldDefinitionTemplateQueryBuilder AddFieldType()
    {
        AddField("type");
        return this;
    }

    public StandardMetafieldDefinitionTemplateQueryBuilder AddFieldValidations()
    {
        AddField("validations");
        return this;
    }

    public StandardMetafieldDefinitionTemplateQueryBuilder AddFieldVisibleToStorefrontApi()
    {
        AddField("visibleToStorefrontApi");
        return this;
    }
}