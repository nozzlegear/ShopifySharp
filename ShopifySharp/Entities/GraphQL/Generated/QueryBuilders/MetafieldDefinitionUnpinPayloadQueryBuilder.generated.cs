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

public class MetafieldDefinitionUnpinPayloadQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionUnpinPayload>("metafieldDefinitionUnpinPayload")
{
    public MetafieldDefinitionUnpinPayloadQueryBuilder AddFieldUnpinnedDefinition(Func<MetafieldDefinitionQueryBuilder, MetafieldDefinitionQueryBuilder> build)
    {
        AddField<MetafieldDefinition, MetafieldDefinitionQueryBuilder>("unpinnedDefinition", build);
        return this;
    }

    public MetafieldDefinitionUnpinPayloadQueryBuilder AddFieldUserErrors(Func<MetafieldDefinitionUnpinUserErrorQueryBuilder, MetafieldDefinitionUnpinUserErrorQueryBuilder> build)
    {
        AddField<MetafieldDefinitionUnpinUserError, MetafieldDefinitionUnpinUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}