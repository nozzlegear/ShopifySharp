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

public class MetaobjectUpdateQueryBuilder() : GraphQueryBuilder<MetaobjectUpdatePayload>("metaobjectUpdate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public MetaobjectUpdateQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public MetaobjectUpdateQueryBuilder AddArgumentMetaobject(MetaobjectUpdateInput? metaobject)
    {
        AddArgument("metaobject", metaobject);
        return this;
    }
}