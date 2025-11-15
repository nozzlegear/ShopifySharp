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

public class MetafieldDefinitionUpdatePayloadQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionUpdatePayload>("query metafieldDefinitionUpdatePayload")
{
    public MetafieldDefinitionUpdatePayloadQueryBuilder AddFieldUpdatedDefinition()
    {
        AddField("updatedDefinition");
        return this;
    }

    public MetafieldDefinitionUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }

    public MetafieldDefinitionUpdatePayloadQueryBuilder AddFieldValidationJob()
    {
        AddField("validationJob");
        return this;
    }
}