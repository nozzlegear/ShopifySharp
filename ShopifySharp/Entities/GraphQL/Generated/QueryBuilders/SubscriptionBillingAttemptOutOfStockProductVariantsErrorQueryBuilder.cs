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

public class SubscriptionBillingAttemptOutOfStockProductVariantsErrorQueryBuilder() : GraphQueryBuilder<SubscriptionBillingAttemptOutOfStockProductVariantsError>("query subscriptionBillingAttemptOutOfStockProductVariantsError")
{
    public SubscriptionBillingAttemptOutOfStockProductVariantsErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public SubscriptionBillingAttemptOutOfStockProductVariantsErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }

    [Obsolete("Use `subscriptionBillingAttemptInsufficientStockProductVariantsError` type instead.")]
    public SubscriptionBillingAttemptOutOfStockProductVariantsErrorQueryBuilder AddFieldOutOfStockProductVariants()
    {
        AddField("outOfStockProductVariants");
        return this;
    }
}