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

public class AppSubscriptionTrialExtendPayloadQueryBuilder() : GraphQueryBuilder<AppSubscriptionTrialExtendPayload>("appSubscriptionTrialExtendPayload")
{
    public AppSubscriptionTrialExtendPayloadQueryBuilder AddFieldAppSubscription(Func<AppSubscriptionQueryBuilder, AppSubscriptionQueryBuilder> build)
    {
        AddField<AppSubscription, AppSubscriptionQueryBuilder>("appSubscription", build);
        return this;
    }

    public AppSubscriptionTrialExtendPayloadQueryBuilder AddFieldUserErrors(Func<AppSubscriptionTrialExtendUserErrorQueryBuilder, AppSubscriptionTrialExtendUserErrorQueryBuilder> build)
    {
        AddField<AppSubscriptionTrialExtendUserError, AppSubscriptionTrialExtendUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}