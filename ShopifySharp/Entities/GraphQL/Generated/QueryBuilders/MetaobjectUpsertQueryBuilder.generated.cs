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

public class MetaobjectUpsertQueryBuilder() : GraphQueryBuilder<MetaobjectUpsertPayload>("metaobjectUpsert"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public MetaobjectUpsertQueryBuilder AddArgumentHandle(MetaobjectHandleInput? handle)
    {
        AddArgument("handle", handle);
        return this;
    }

    public MetaobjectUpsertQueryBuilder AddArgumentMetaobject(MetaobjectUpsertInput? metaobject)
    {
        AddArgument("metaobject", metaobject);
        return this;
    }
}