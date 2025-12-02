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

public class CustomerAddressUpdateQueryBuilder() : GraphQueryBuilder<CustomerAddressUpdatePayload>("customerAddressUpdate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public CustomerAddressUpdateQueryBuilder AddArgumentAddress(MailingAddressInput? address)
    {
        AddArgument("address", address);
        return this;
    }

    public CustomerAddressUpdateQueryBuilder AddArgumentAddressId(string? addressId)
    {
        AddArgument("addressId", addressId);
        return this;
    }

    public CustomerAddressUpdateQueryBuilder AddArgumentCustomerId(string? customerId)
    {
        AddArgument("customerId", customerId);
        return this;
    }

    public CustomerAddressUpdateQueryBuilder AddArgumentSetAsDefault(bool? setAsDefault)
    {
        AddArgument("setAsDefault", setAsDefault);
        return this;
    }
}