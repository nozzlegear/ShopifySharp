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

public class MetaobjectFieldDefinitionQueryBuilder() : GraphQueryBuilder<MetaobjectFieldDefinition>("query metaobjectFieldDefinition")
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

    public MetaobjectFieldDefinitionQueryBuilder AddFieldType()
    {
        AddField("type");
        return this;
    }

    public MetaobjectFieldDefinitionQueryBuilder AddFieldValidations()
    {
        AddField("validations");
        return this;
    }
}