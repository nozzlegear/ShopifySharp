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

public class SubscriptionBillingAttemptCreateQueryBuilder() : GraphQueryBuilder<SubscriptionBillingAttemptCreatePayload>("subscriptionBillingAttemptCreate"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Mutation;

    public SubscriptionBillingAttemptCreateQueryBuilder AddArgumentSubscriptionBillingAttemptInput(SubscriptionBillingAttemptInput? subscriptionBillingAttemptInput)
    {
        AddArgument("subscriptionBillingAttemptInput", subscriptionBillingAttemptInput);
        return this;
    }

    public SubscriptionBillingAttemptCreateQueryBuilder AddArgumentSubscriptionContractId(string? subscriptionContractId)
    {
        AddArgument("subscriptionContractId", subscriptionContractId);
        return this;
    }
}