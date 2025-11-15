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

public class ConsentPolicyUpdateQueryBuilder() : GraphQueryBuilder<ConsentPolicyUpdatePayload>("query consentPolicyUpdate")
{
    public ConsentPolicyUpdateQueryBuilder AddArgumentConsentPolicies(ICollection<ConsentPolicyInput>? consentPolicies)
    {
        AddArgument("consentPolicies", consentPolicies);
        return this;
    }
}