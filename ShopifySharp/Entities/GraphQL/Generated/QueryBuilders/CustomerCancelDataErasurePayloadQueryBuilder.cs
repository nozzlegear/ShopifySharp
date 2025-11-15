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

public class CustomerCancelDataErasurePayloadQueryBuilder() : GraphQueryBuilder<CustomerCancelDataErasurePayload>("query customerCancelDataErasurePayload")
{
    public CustomerCancelDataErasurePayloadQueryBuilder AddFieldCustomerId()
    {
        AddField("customerId");
        return this;
    }

    public CustomerCancelDataErasurePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}