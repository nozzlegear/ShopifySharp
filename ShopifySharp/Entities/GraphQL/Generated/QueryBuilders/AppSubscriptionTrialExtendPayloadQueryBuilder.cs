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

public class AppSubscriptionTrialExtendPayloadQueryBuilder() : GraphQueryBuilder<AppSubscriptionTrialExtendPayload>("query appSubscriptionTrialExtendPayload")
{
    public AppSubscriptionTrialExtendPayloadQueryBuilder AddFieldAppSubscription()
    {
        AddField("appSubscription");
        return this;
    }

    public AppSubscriptionTrialExtendPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}