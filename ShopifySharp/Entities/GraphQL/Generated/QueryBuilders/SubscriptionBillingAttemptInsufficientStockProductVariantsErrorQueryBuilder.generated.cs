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

public class SubscriptionBillingAttemptInsufficientStockProductVariantsErrorQueryBuilder() : GraphQueryBuilder<SubscriptionBillingAttemptInsufficientStockProductVariantsError>("subscriptionBillingAttemptInsufficientStockProductVariantsError")
{
    public SubscriptionBillingAttemptInsufficientStockProductVariantsErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public SubscriptionBillingAttemptInsufficientStockProductVariantsErrorQueryBuilder AddFieldInsufficientStockProductVariants(Func<ProductVariantConnectionQueryBuilder, ProductVariantConnectionQueryBuilder> build)
    {
        AddField<ProductVariantConnection, ProductVariantConnectionQueryBuilder>("insufficientStockProductVariants", build);
        return this;
    }

    public SubscriptionBillingAttemptInsufficientStockProductVariantsErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}