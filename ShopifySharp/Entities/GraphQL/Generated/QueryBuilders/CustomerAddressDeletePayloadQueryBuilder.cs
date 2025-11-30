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

public class CustomerAddressDeletePayloadQueryBuilder() : GraphQueryBuilder<CustomerAddressDeletePayload>("query customerAddressDeletePayload")
{
    public CustomerAddressDeletePayloadQueryBuilder AddFieldDeletedAddressId()
    {
        AddField("deletedAddressId");
        return this;
    }

    public CustomerAddressDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}