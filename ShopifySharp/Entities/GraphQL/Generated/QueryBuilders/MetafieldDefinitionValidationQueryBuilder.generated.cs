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

public class MetafieldDefinitionValidationQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionValidation>("metafieldDefinitionValidation")
{
    public MetafieldDefinitionValidationQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public MetafieldDefinitionValidationQueryBuilder AddFieldType()
    {
        AddField("type");
        return this;
    }

    public MetafieldDefinitionValidationQueryBuilder AddFieldValue()
    {
        AddField("value");
        return this;
    }
}