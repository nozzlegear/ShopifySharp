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

public class AppSubscriptionLineItemUpdatePayloadQueryBuilder() : GraphQueryBuilder<AppSubscriptionLineItemUpdatePayload>("appSubscriptionLineItemUpdatePayload")
{
    public AppSubscriptionLineItemUpdatePayloadQueryBuilder AddFieldAppSubscription(Func<AppSubscriptionQueryBuilder, AppSubscriptionQueryBuilder> build)
    {
        AddField<AppSubscription, AppSubscriptionQueryBuilder>("appSubscription", build);
        return this;
    }

    public AppSubscriptionLineItemUpdatePayloadQueryBuilder AddFieldConfirmationUrl()
    {
        AddField("confirmationUrl");
        return this;
    }

    public AppSubscriptionLineItemUpdatePayloadQueryBuilder AddFieldUserErrors(Func<UserErrorQueryBuilder, UserErrorQueryBuilder> build)
    {
        AddField<UserError, UserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}