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

public class MetafieldDefinitionCreatePayloadQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionCreatePayload>("metafieldDefinitionCreatePayload")
{
    public MetafieldDefinitionCreatePayloadQueryBuilder AddFieldCreatedDefinition(Func<MetafieldDefinitionQueryBuilder, MetafieldDefinitionQueryBuilder> build)
    {
        AddField<MetafieldDefinition, MetafieldDefinitionQueryBuilder>("createdDefinition", build);
        return this;
    }

    public MetafieldDefinitionCreatePayloadQueryBuilder AddFieldUserErrors(Func<MetafieldDefinitionCreateUserErrorQueryBuilder, MetafieldDefinitionCreateUserErrorQueryBuilder> build)
    {
        AddField<MetafieldDefinitionCreateUserError, MetafieldDefinitionCreateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}