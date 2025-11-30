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

public class MetafieldDefinitionPinPayloadQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionPinPayload>("metafieldDefinitionPinPayload")
{
    public MetafieldDefinitionPinPayloadQueryBuilder AddFieldPinnedDefinition(Func<MetafieldDefinitionQueryBuilder, MetafieldDefinitionQueryBuilder> build)
    {
        AddField<MetafieldDefinition, MetafieldDefinitionQueryBuilder>("pinnedDefinition", build);
        return this;
    }

    public MetafieldDefinitionPinPayloadQueryBuilder AddFieldUserErrors(Func<MetafieldDefinitionPinUserErrorQueryBuilder, MetafieldDefinitionPinUserErrorQueryBuilder> build)
    {
        AddField<MetafieldDefinitionPinUserError, MetafieldDefinitionPinUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}