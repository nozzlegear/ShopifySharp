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

public class SubscriptionBillingAttemptQueryBuilder() : GraphQueryBuilder<SubscriptionBillingAttempt>("subscriptionBillingAttempt")
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

    public SubscriptionBillingAttemptQueryBuilder AddFieldOrder(Func<OrderQueryBuilder, OrderQueryBuilder> build)
    {
        AddField<Order, OrderQueryBuilder>("order", build);
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

    public SubscriptionBillingAttemptQueryBuilder AddFieldProcessingError(Func<SubscriptionBillingAttemptProcessingErrorQueryBuilder, SubscriptionBillingAttemptProcessingErrorQueryBuilder> build)
    {
        AddField<ISubscriptionBillingAttemptProcessingError, SubscriptionBillingAttemptProcessingErrorQueryBuilder>("processingError", build);
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

    public SubscriptionBillingAttemptQueryBuilder AddFieldSubscriptionContract(Func<SubscriptionContractQueryBuilder, SubscriptionContractQueryBuilder> build)
    {
        AddField<SubscriptionContract, SubscriptionContractQueryBuilder>("subscriptionContract", build);
        return this;
    }

    public SubscriptionBillingAttemptQueryBuilder AddFieldTransactions(Func<OrderTransactionConnectionQueryBuilder, OrderTransactionConnectionQueryBuilder> build)
    {
        AddField<OrderTransactionConnection, OrderTransactionConnectionQueryBuilder>("transactions", build);
        return this;
    }
}