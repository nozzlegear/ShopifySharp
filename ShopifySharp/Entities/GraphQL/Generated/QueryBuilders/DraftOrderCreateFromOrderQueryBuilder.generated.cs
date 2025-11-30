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

public class DraftOrderCreateFromOrderQueryBuilder() : GraphQueryBuilder<DraftOrderCreateFromOrderPayload>("draftOrderCreateFromOrder"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public DraftOrderCreateFromOrderQueryBuilder AddArgumentOrderId(string? orderId)
    {
        AddArgument("orderId", orderId);
        return this;
    }
}