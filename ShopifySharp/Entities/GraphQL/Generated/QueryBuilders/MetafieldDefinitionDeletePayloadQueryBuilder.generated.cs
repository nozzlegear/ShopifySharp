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

public class MetafieldDefinitionDeletePayloadQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionDeletePayload>("metafieldDefinitionDeletePayload")
{
    public MetafieldDefinitionDeletePayloadQueryBuilder AddFieldDeletedDefinition(Func<MetafieldDefinitionIdentifierQueryBuilder, MetafieldDefinitionIdentifierQueryBuilder> build)
    {
        AddField<MetafieldDefinitionIdentifier, MetafieldDefinitionIdentifierQueryBuilder>("deletedDefinition", build);
        return this;
    }

    public MetafieldDefinitionDeletePayloadQueryBuilder AddFieldDeletedDefinitionId()
    {
        AddField("deletedDefinitionId");
        return this;
    }

    public MetafieldDefinitionDeletePayloadQueryBuilder AddFieldUserErrors(Func<MetafieldDefinitionDeleteUserErrorQueryBuilder, MetafieldDefinitionDeleteUserErrorQueryBuilder> build)
    {
        AddField<MetafieldDefinitionDeleteUserError, MetafieldDefinitionDeleteUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}