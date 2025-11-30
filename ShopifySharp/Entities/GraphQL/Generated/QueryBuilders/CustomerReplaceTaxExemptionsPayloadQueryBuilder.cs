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

public class CustomerReplaceTaxExemptionsPayloadQueryBuilder() : GraphQueryBuilder<CustomerReplaceTaxExemptionsPayload>("query customerReplaceTaxExemptionsPayload")
{
    public CustomerReplaceTaxExemptionsPayloadQueryBuilder AddFieldCustomer()
    {
        AddField("customer");
        return this;
    }

    public CustomerReplaceTaxExemptionsPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}