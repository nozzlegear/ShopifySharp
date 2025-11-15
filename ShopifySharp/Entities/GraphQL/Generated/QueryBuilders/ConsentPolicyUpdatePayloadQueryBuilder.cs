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

public class ConsentPolicyUpdatePayloadQueryBuilder() : GraphQueryBuilder<ConsentPolicyUpdatePayload>("query consentPolicyUpdatePayload")
{
    public ConsentPolicyUpdatePayloadQueryBuilder AddFieldUpdatedPolicies()
    {
        AddField("updatedPolicies");
        return this;
    }

    public ConsentPolicyUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}