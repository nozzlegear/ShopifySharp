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

public class CustomerAddressUpdatePayloadQueryBuilder() : GraphQueryBuilder<CustomerAddressUpdatePayload>("query customerAddressUpdatePayload")
{
    public CustomerAddressUpdatePayloadQueryBuilder AddFieldAddress()
    {
        AddField("address");
        return this;
    }

    public CustomerAddressUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}