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

[Obsolete("Use `publishableUnpublish` instead.")]
public class CollectionUnpublishQueryBuilder() : GraphQueryBuilder<CollectionUnpublishPayload>("collectionUnpublish"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public CollectionUnpublishQueryBuilder AddArgumentInput(CollectionUnpublishInput? input)
    {
        AddArgument("input", input);
        return this;
    }
}