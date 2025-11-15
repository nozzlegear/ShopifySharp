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

public class AppSubscriptionCreatePayloadQueryBuilder() : GraphQueryBuilder<AppSubscriptionCreatePayload>("query appSubscriptionCreatePayload")
{
    public AppSubscriptionCreatePayloadQueryBuilder AddFieldAppSubscription()
    {
        AddField("appSubscription");
        return this;
    }

    public AppSubscriptionCreatePayloadQueryBuilder AddFieldConfirmationUrl()
    {
        AddField("confirmationUrl");
        return this;
    }

    public AppSubscriptionCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}