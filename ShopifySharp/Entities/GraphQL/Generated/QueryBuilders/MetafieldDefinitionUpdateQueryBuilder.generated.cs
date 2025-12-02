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

public class MetafieldDefinitionUpdateQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionUpdatePayload>("metafieldDefinitionUpdate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public MetafieldDefinitionUpdateQueryBuilder AddArgumentDefinition(MetafieldDefinitionUpdateInput? definition)
    {
        AddArgument("definition", definition);
        return this;
    }
}