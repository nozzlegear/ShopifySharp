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

public class CustomerUpdatePayloadQueryBuilder() : GraphQueryBuilder<CustomerUpdatePayload>("query customerUpdatePayload")
{
    public CustomerUpdatePayloadQueryBuilder AddFieldCustomer()
    {
        AddField("customer");
        return this;
    }

    public CustomerUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}