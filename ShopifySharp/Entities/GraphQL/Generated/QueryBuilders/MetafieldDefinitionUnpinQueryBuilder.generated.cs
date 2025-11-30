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

public class MetafieldDefinitionUnpinQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionUnpinPayload>("metafieldDefinitionUnpin"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public MetafieldDefinitionUnpinQueryBuilder AddArgumentDefinitionId(string? definitionId)
    {
        AddArgument("definitionId", definitionId);
        return this;
    }

    public MetafieldDefinitionUnpinQueryBuilder AddArgumentIdentifier(MetafieldDefinitionIdentifierInput? identifier)
    {
        AddArgument("identifier", identifier);
        return this;
    }
}