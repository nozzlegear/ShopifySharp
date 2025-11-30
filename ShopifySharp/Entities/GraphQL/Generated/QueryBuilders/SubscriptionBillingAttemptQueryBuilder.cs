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

public class SubscriptionBillingAttemptQueryBuilder() : GraphQueryBuilder<SubscriptionBillingAttempt>("query subscriptionBillingAttempt")
{
    public SubscriptionBillingAttemptQueryBuilder AddFieldCompletedAt()
    {
        AddField("completedAt");
        return this;
    }

    public SubscriptionBillingAttemptQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    [Obsolete("Use `processingError.code` instead to get the errorCode")]
    public SubscriptionBillingAttemptQueryBuilder AddFieldErrorCode()
    {
        AddField("errorCode");
        return this;
    }

    [Obsolete("Use `processingError.message` instead to get the errorMessage")]
    public SubscriptionBillingAttemptQueryBuilder AddFieldErrorMessage()
    {
        AddField("errorMessage");
        return this;
    }

    public SubscriptionBillingAttemptQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public SubscriptionBillingAttemptQueryBuilder AddFieldIdempotencyKey()
    {
        AddField("idempotencyKey");
        return this;
    }

    public SubscriptionBillingAttemptQueryBuilder AddFieldNextActionUrl()
    {
        AddField("nextActionUrl");
        return this;
    }

    public SubscriptionBillingAttemptQueryBuilder AddFieldOrder()
    {
        AddField("order");
        return this;
    }

    public SubscriptionBillingAttemptQueryBuilder AddFieldOriginTime()
    {
        AddField("originTime");
        return this;
    }

    public SubscriptionBillingAttemptQueryBuilder AddFieldPaymentGroupId()
    {
        AddField("paymentGroupId");
        return this;
    }

    public SubscriptionBillingAttemptQueryBuilder AddFieldPaymentSessionId()
    {
        AddField("paymentSessionId");
        return this;
    }

    public SubscriptionBillingAttemptQueryBuilder AddFieldProcessingError()
    {
        AddField("processingError");
        return this;
    }

    public SubscriptionBillingAttemptQueryBuilder AddFieldReady()
    {
        AddField("ready");
        return this;
    }

    public SubscriptionBillingAttemptQueryBuilder AddFieldRespectInventoryPolicy()
    {
        AddField("respectInventoryPolicy");
        return this;
    }

    public SubscriptionBillingAttemptQueryBuilder AddFieldSubscriptionContract()
    {
        AddField("subscriptionContract");
        return this;
    }

    public SubscriptionBillingAttemptQueryBuilder AddFieldTransactions()
    {
        AddField("transactions");
        return this;
    }
}