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

public class StandardMetafieldDefinitionEnablePayloadQueryBuilder() : GraphQueryBuilder<StandardMetafieldDefinitionEnablePayload>("standardMetafieldDefinitionEnablePayload")
{
    public StandardMetafieldDefinitionEnablePayloadQueryBuilder AddFieldCreatedDefinition(Func<MetafieldDefinitionQueryBuilder, MetafieldDefinitionQueryBuilder> build)
    {
        AddField<MetafieldDefinition, MetafieldDefinitionQueryBuilder>("createdDefinition", build);
        return this;
    }

    public StandardMetafieldDefinitionEnablePayloadQueryBuilder AddFieldUserErrors(Func<StandardMetafieldDefinitionEnableUserErrorQueryBuilder, StandardMetafieldDefinitionEnableUserErrorQueryBuilder> build)
    {
        AddField<StandardMetafieldDefinitionEnableUserError, StandardMetafieldDefinitionEnableUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}