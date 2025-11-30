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

public class CustomerPaymentMethodGetDuplicationDataQueryBuilder() : GraphQueryBuilder<CustomerPaymentMethodGetDuplicationDataPayload>("customerPaymentMethodGetDuplicationData"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public CustomerPaymentMethodGetDuplicationDataQueryBuilder AddArgumentCustomerPaymentMethodId(string? customerPaymentMethodId)
    {
        AddArgument("customerPaymentMethodId", customerPaymentMethodId);
        return this;
    }

    public CustomerPaymentMethodGetDuplicationDataQueryBuilder AddArgumentTargetCustomerId(string? targetCustomerId)
    {
        AddArgument("targetCustomerId", targetCustomerId);
        return this;
    }

    public CustomerPaymentMethodGetDuplicationDataQueryBuilder AddArgumentTargetShopId(string? targetShopId)
    {
        AddArgument("targetShopId", targetShopId);
        return this;
    }
}