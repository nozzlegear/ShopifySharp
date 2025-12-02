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

public class StoreCreditAccountDebitQueryBuilder() : GraphQueryBuilder<StoreCreditAccountDebitPayload>("storeCreditAccountDebit"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public StoreCreditAccountDebitQueryBuilder AddArgumentDebitInput(StoreCreditAccountDebitInput? debitInput)
    {
        AddArgument("debitInput", debitInput);
        return this;
    }

    public StoreCreditAccountDebitQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }
}