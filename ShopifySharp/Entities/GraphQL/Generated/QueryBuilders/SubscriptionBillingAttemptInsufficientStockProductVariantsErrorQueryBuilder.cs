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

public class SubscriptionBillingAttemptInsufficientStockProductVariantsErrorQueryBuilder() : GraphQueryBuilder<SubscriptionBillingAttemptInsufficientStockProductVariantsError>("query subscriptionBillingAttemptInsufficientStockProductVariantsError")
{
    public SubscriptionBillingAttemptInsufficientStockProductVariantsErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public SubscriptionBillingAttemptInsufficientStockProductVariantsErrorQueryBuilder AddFieldInsufficientStockProductVariants()
    {
        AddField("insufficientStockProductVariants");
        return this;
    }

    public SubscriptionBillingAttemptInsufficientStockProductVariantsErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}