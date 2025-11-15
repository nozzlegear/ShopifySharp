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

public class CustomerMergePayloadQueryBuilder() : GraphQueryBuilder<CustomerMergePayload>("query customerMergePayload")
{
    public CustomerMergePayloadQueryBuilder AddFieldJob()
    {
        AddField("job");
        return this;
    }

    public CustomerMergePayloadQueryBuilder AddFieldResultingCustomerId()
    {
        AddField("resultingCustomerId");
        return this;
    }

    public CustomerMergePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}