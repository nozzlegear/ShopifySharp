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

public class StandardMetaobjectDefinitionTemplateQueryBuilder() : GraphQueryBuilder<StandardMetaobjectDefinitionTemplate>("query standardMetaobjectDefinitionTemplate")
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

    public StandardMetaobjectDefinitionTemplateQueryBuilder AddFieldEnabledCapabilities()
    {
        AddField("enabledCapabilities");
        return this;
    }

    public StandardMetaobjectDefinitionTemplateQueryBuilder AddFieldFieldDefinitions()
    {
        AddField("fieldDefinitions");
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