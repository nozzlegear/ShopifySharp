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

public class CustomerAddressDeleteQueryBuilder() : GraphQueryBuilder<CustomerAddressDeletePayload>("customerAddressDelete"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public CustomerAddressDeleteQueryBuilder AddArgumentAddressId(string? addressId)
    {
        AddArgument("addressId", addressId);
        return this;
    }

    public CustomerAddressDeleteQueryBuilder AddArgumentCustomerId(string? customerId)
    {
        AddArgument("customerId", customerId);
        return this;
    }
}