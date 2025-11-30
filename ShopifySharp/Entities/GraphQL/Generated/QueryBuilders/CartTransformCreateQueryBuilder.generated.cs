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

public class CartTransformCreateQueryBuilder() : GraphQueryBuilder<CartTransformCreatePayload>("cartTransformCreate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public CartTransformCreateQueryBuilder AddArgumentBlockOnFailure(bool? blockOnFailure)
    {
        AddArgument("blockOnFailure", blockOnFailure);
        return this;
    }

    public CartTransformCreateQueryBuilder AddArgumentFunctionId(string? functionId)
    {
        AddArgument("functionId", functionId);
        return this;
    }

    public CartTransformCreateQueryBuilder AddArgumentMetafields(ICollection<MetafieldInput>? metafields)
    {
        AddArgument("metafields", metafields);
        return this;
    }
}