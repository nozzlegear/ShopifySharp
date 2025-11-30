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

public class SubscriptionContractProductChangePayloadQueryBuilder() : GraphQueryBuilder<SubscriptionContractProductChangePayload>("subscriptionContractProductChangePayload")
{
    public SubscriptionContractProductChangePayloadQueryBuilder AddFieldContract(Func<SubscriptionContractQueryBuilder, SubscriptionContractQueryBuilder> build)
    {
        AddField<SubscriptionContract, SubscriptionContractQueryBuilder>("contract", build);
        return this;
    }

    public SubscriptionContractProductChangePayloadQueryBuilder AddFieldLineUpdated(Func<SubscriptionLineQueryBuilder, SubscriptionLineQueryBuilder> build)
    {
        AddField<SubscriptionLine, SubscriptionLineQueryBuilder>("lineUpdated", build);
        return this;
    }

    public SubscriptionContractProductChangePayloadQueryBuilder AddFieldUserErrors(Func<SubscriptionDraftUserErrorQueryBuilder, SubscriptionDraftUserErrorQueryBuilder> build)
    {
        AddField<SubscriptionDraftUserError, SubscriptionDraftUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}