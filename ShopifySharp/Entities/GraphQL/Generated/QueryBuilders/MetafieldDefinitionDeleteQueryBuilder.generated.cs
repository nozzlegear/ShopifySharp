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

public class MetafieldDefinitionDeleteQueryBuilder() : GraphQueryBuilder<MetafieldDefinitionDeletePayload>("metafieldDefinitionDelete"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public MetafieldDefinitionDeleteQueryBuilder AddArgumentDeleteAllAssociatedMetafields(bool? deleteAllAssociatedMetafields)
    {
        AddArgument("deleteAllAssociatedMetafields", deleteAllAssociatedMetafields);
        return this;
    }

    public MetafieldDefinitionDeleteQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public MetafieldDefinitionDeleteQueryBuilder AddArgumentIdentifier(MetafieldDefinitionIdentifierInput? identifier)
    {
        AddArgument("identifier", identifier);
        return this;
    }
}