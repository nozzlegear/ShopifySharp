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

public class CustomerRequestDataErasurePayloadQueryBuilder() : GraphQueryBuilder<CustomerRequestDataErasurePayload>("query customerRequestDataErasurePayload")
{
    public CustomerRequestDataErasurePayloadQueryBuilder AddFieldCustomerId()
    {
        AddField("customerId");
        return this;
    }

    public CustomerRequestDataErasurePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}