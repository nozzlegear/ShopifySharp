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

public class StandardMetaobjectDefinitionTemplateQueryBuilder() : GraphQueryBuilder<StandardMetaobjectDefinitionTemplate>("standardMetaobjectDefinitionTemplate")
{
    public StandardMetaobjectDefinitionTemplateQueryBuilder AddFieldDescription()
    {
        AddField("description");
        return this;
    }

    public StandardMetaobjectDefinitionTemplateQueryBuilder AddFieldDisplayNameKey()
    {
        AddField("displayNameKey");
        return this;
    }

    public StandardMetaobjectDefinitionTemplateQueryBuilder AddFieldEnabledCapabilities(Func<StandardMetaobjectCapabilityTemplateQueryBuilder, StandardMetaobjectCapabilityTemplateQueryBuilder> build)
    {
        AddField<StandardMetaobjectCapabilityTemplate, StandardMetaobjectCapabilityTemplateQueryBuilder>("enabledCapabilities", build);
        return this;
    }

    public StandardMetaobjectDefinitionTemplateQueryBuilder AddFieldFieldDefinitions(Func<StandardMetaobjectDefinitionFieldTemplateQueryBuilder, StandardMetaobjectDefinitionFieldTemplateQueryBuilder> build)
    {
        AddField<StandardMetaobjectDefinitionFieldTemplate, StandardMetaobjectDefinitionFieldTemplateQueryBuilder>("fieldDefinitions", build);
        return this;
    }

    public StandardMetaobjectDefinitionTemplateQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public StandardMetaobjectDefinitionTemplateQueryBuilder AddFieldType()
    {
        AddField("type");
        return this;
    }
}