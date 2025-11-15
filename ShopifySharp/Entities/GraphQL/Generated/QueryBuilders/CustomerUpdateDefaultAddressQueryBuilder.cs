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

public class CustomerUpdateDefaultAddressQueryBuilder() : GraphQueryBuilder<CustomerUpdateDefaultAddressPayload>("query customerUpdateDefaultAddress")
{
    public CustomerUpdateDefaultAddressQueryBuilder AddArgumentAddressId(string? addressId)
    {
        AddArgument("addressId", addressId);
        return this;
    }

    public CustomerUpdateDefaultAddressQueryBuilder AddArgumentCustomerId(string? customerId)
    {
        AddArgument("customerId", customerId);
        return this;
    }
}