#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class CustomerAddressCreateQueryBuilder() : GraphQueryBuilder<CustomerAddressCreatePayload>("query customerAddressCreate")
{
    public CustomerAddressCreateQueryBuilder AddArgumentAddress(MailingAddressInput? address)
    {
        AddArgument("address", address);
        return this;
    }

    public CustomerAddressCreateQueryBuilder AddArgumentCustomerId(string? customerId)
    {
        AddArgument("customerId", customerId);
        return this;
    }

    public CustomerAddressCreateQueryBuilder AddArgumentSetAsDefault(bool? setAsDefault)
    {
        AddArgument("setAsDefault", setAsDefault);
        return this;
    }
}