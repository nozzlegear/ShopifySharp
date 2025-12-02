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

public class GiftCardDebitQueryBuilder() : GraphQueryBuilder<GiftCardDebitPayload>("giftCardDebit"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public GiftCardDebitQueryBuilder AddArgumentDebitInput(GiftCardDebitInput? debitInput)
    {
        AddArgument("debitInput", debitInput);
        return this;
    }

    public GiftCardDebitQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }
}