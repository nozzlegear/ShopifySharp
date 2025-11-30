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

public class SubscriptionBillingAttemptOutOfStockProductVariantsErrorQueryBuilder() : GraphQueryBuilder<SubscriptionBillingAttemptOutOfStockProductVariantsError>("subscriptionBillingAttemptOutOfStockProductVariantsError")
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

    public SubscriptionBillingAttemptOutOfStockProductVariantsErrorQueryBuilder AddFieldOutOfStockProductVariants(Func<ProductVariantConnectionQueryBuilder, ProductVariantConnectionQueryBuilder> build)
    {
        AddField<ProductVariantConnection, ProductVariantConnectionQueryBuilder>("outOfStockProductVariants", build);
        return this;
    }
}