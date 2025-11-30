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

public class SubscriptionContractFailPayloadQueryBuilder() : GraphQueryBuilder<SubscriptionContractFailPayload>("subscriptionContractFailPayload")
{
    public SubscriptionContractFailPayloadQueryBuilder AddFieldContract(Func<SubscriptionContractQueryBuilder, SubscriptionContractQueryBuilder> build)
    {
        AddField<SubscriptionContract, SubscriptionContractQueryBuilder>("contract", build);
        return this;
    }

    public SubscriptionContractFailPayloadQueryBuilder AddFieldUserErrors(Func<SubscriptionContractStatusUpdateUserErrorQueryBuilder, SubscriptionContractStatusUpdateUserErrorQueryBuilder> build)
    {
        AddField<SubscriptionContractStatusUpdateUserError, SubscriptionContractStatusUpdateUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}