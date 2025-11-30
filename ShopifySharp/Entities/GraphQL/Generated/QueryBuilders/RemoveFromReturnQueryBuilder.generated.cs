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

public class RemoveFromReturnQueryBuilder() : GraphQueryBuilder<RemoveFromReturnPayload>("removeFromReturn"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public RemoveFromReturnQueryBuilder AddArgumentExchangeLineItems(ICollection<ExchangeLineItemRemoveFromReturnInput>? exchangeLineItems)
    {
        AddArgument("exchangeLineItems", exchangeLineItems);
        return this;
    }

    public RemoveFromReturnQueryBuilder AddArgumentReturnId(string? returnId)
    {
        AddArgument("returnId", returnId);
        return this;
    }

    public RemoveFromReturnQueryBuilder AddArgumentReturnLineItems(ICollection<ReturnLineItemRemoveFromReturnInput>? returnLineItems)
    {
        AddArgument("returnLineItems", returnLineItems);
        return this;
    }
}