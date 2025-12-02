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

public class SubscriptionContractSetNextBillingDatePayloadQueryBuilder() : GraphQueryBuilder<SubscriptionContractSetNextBillingDatePayload>("subscriptionContractSetNextBillingDatePayload")
{
    public SubscriptionContractSetNextBillingDatePayloadQueryBuilder AddFieldContract(Func<SubscriptionContractQueryBuilder, SubscriptionContractQueryBuilder> build)
    {
        AddField<SubscriptionContract, SubscriptionContractQueryBuilder>("contract", build);
        return this;
    }

    public SubscriptionContractSetNextBillingDatePayloadQueryBuilder AddFieldUserErrors(Func<SubscriptionContractUserErrorQueryBuilder, SubscriptionContractUserErrorQueryBuilder> build)
    {
        AddField<SubscriptionContractUserError, SubscriptionContractUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}