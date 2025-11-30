#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class ConsentPolicyUpdatePayloadQueryBuilder() : GraphQueryBuilder<ConsentPolicyUpdatePayload>("consentPolicyUpdatePayload")
{
    public ConsentPolicyUpdatePayloadQueryBuilder AddFieldUpdatedPolicies(Func<ConsentPolicyQueryBuilder, ConsentPolicyQueryBuilder> build)
    {
        AddField<ConsentPolicy, ConsentPolicyQueryBuilder>("updatedPolicies", build);
        return this;
    }

    public ConsentPolicyUpdatePayloadQueryBuilder AddFieldUserErrors(Func<ConsentPolicyErrorQueryBuilder, ConsentPolicyErrorQueryBuilder> build)
    {
        AddField<ConsentPolicyError, ConsentPolicyErrorQueryBuilder>("userErrors", build);
        return this;
    }
}