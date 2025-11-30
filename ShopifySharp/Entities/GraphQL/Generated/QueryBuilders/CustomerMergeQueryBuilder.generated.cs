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

public class CustomerMergeQueryBuilder() : GraphQueryBuilder<CustomerMergePayload>("customerMerge"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public CustomerMergeQueryBuilder AddArgumentCustomerOneId(string? customerOneId)
    {
        AddArgument("customerOneId", customerOneId);
        return this;
    }

    public CustomerMergeQueryBuilder AddArgumentCustomerTwoId(string? customerTwoId)
    {
        AddArgument("customerTwoId", customerTwoId);
        return this;
    }

    public CustomerMergeQueryBuilder AddArgumentOverrideFields(CustomerMergeOverrideFields? overrideFields)
    {
        AddArgument("overrideFields", overrideFields);
        return this;
    }
}