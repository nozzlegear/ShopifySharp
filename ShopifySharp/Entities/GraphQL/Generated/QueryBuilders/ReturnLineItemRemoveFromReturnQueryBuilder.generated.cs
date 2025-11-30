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

[Obsolete("Use `removeFromReturn` instead.")]
public class ReturnLineItemRemoveFromReturnQueryBuilder() : GraphQueryBuilder<ReturnLineItemRemoveFromReturnPayload>("returnLineItemRemoveFromReturn"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public ReturnLineItemRemoveFromReturnQueryBuilder AddArgumentReturnId(string? returnId)
    {
        AddArgument("returnId", returnId);
        return this;
    }

    public ReturnLineItemRemoveFromReturnQueryBuilder AddArgumentReturnLineItems(ICollection<ReturnLineItemRemoveFromReturnInput>? returnLineItems)
    {
        AddArgument("returnLineItems", returnLineItems);
        return this;
    }
}