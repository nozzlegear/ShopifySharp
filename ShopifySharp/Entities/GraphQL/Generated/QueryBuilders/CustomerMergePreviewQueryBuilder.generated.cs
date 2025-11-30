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

public class CustomerMergePreviewQueryBuilder() : GraphQueryBuilder<CustomerMergePreview>("customerMergePreview"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Query;

    public CustomerMergePreviewQueryBuilder AddArgumentCustomerOneId(string? customerOneId)
    {
        AddArgument("customerOneId", customerOneId);
        return this;
    }

    public CustomerMergePreviewQueryBuilder AddArgumentCustomerTwoId(string? customerTwoId)
    {
        AddArgument("customerTwoId", customerTwoId);
        return this;
    }

    public CustomerMergePreviewQueryBuilder AddArgumentOverrideFields(CustomerMergeOverrideFields? overrideFields)
    {
        AddArgument("overrideFields", overrideFields);
        return this;
    }
}