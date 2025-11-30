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

public class SubscriptionContractQueryBuilder() : GraphQueryBuilder<SubscriptionContract>("subscriptionContract")
{
    public SubscriptionContractQueryBuilder AddFieldApp(Func<AppQueryBuilder, AppQueryBuilder> build)
    {
        AddField<App, AppQueryBuilder>("app", build);
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldAppAdminUrl()
    {
        AddField("appAdminUrl");
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldBillingAttempts(Func<SubscriptionBillingAttemptConnectionQueryBuilder, SubscriptionBillingAttemptConnectionQueryBuilder> build)
    {
        AddField<SubscriptionBillingAttemptConnection, SubscriptionBillingAttemptConnectionQueryBuilder>("billingAttempts", build);
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldBillingPolicy(Func<SubscriptionBillingPolicyQueryBuilder, SubscriptionBillingPolicyQueryBuilder> build)
    {
        AddField<SubscriptionBillingPolicy, SubscriptionBillingPolicyQueryBuilder>("billingPolicy", build);
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldCurrencyCode()
    {
        AddField("currencyCode");
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldCustomAttributes(Func<AttributeQueryBuilder, AttributeQueryBuilder> build)
    {
        AddField<ShopifySharp.GraphQL.Attribute, AttributeQueryBuilder>("customAttributes", build);
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldCustomer(Func<CustomerQueryBuilder, CustomerQueryBuilder> build)
    {
        AddField<Customer, CustomerQueryBuilder>("customer", build);
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldCustomerPaymentMethod(Func<CustomerPaymentMethodQueryBuilder, CustomerPaymentMethodQueryBuilder> build)
    {
        AddField<CustomerPaymentMethod, CustomerPaymentMethodQueryBuilder>("customerPaymentMethod", build);
        return this;
    }

    public SubscriptionContractQueryBuilder AddUnionCaseDeliveryMethod(Func<SubscriptionDeliveryMethodLocalDeliveryQueryBuilder, SubscriptionDeliveryMethodLocalDeliveryQueryBuilder> build)
    {
        AddUnion<SubscriptionDeliveryMethodLocalDelivery, SubscriptionDeliveryMethodLocalDeliveryQueryBuilder>("deliveryMethod", build);
        return this;
    }

    public SubscriptionContractQueryBuilder AddUnionCaseDeliveryMethod(Func<SubscriptionDeliveryMethodPickupQueryBuilder, SubscriptionDeliveryMethodPickupQueryBuilder> build)
    {
        AddUnion<SubscriptionDeliveryMethodPickup, SubscriptionDeliveryMethodPickupQueryBuilder>("deliveryMethod", build);
        return this;
    }

    public SubscriptionContractQueryBuilder AddUnionCaseDeliveryMethod(Func<SubscriptionDeliveryMethodShippingQueryBuilder, SubscriptionDeliveryMethodShippingQueryBuilder> build)
    {
        AddUnion<SubscriptionDeliveryMethodShipping, SubscriptionDeliveryMethodShippingQueryBuilder>("deliveryMethod", build);
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldDeliveryPolicy(Func<SubscriptionDeliveryPolicyQueryBuilder, SubscriptionDeliveryPolicyQueryBuilder> build)
    {
        AddField<SubscriptionDeliveryPolicy, SubscriptionDeliveryPolicyQueryBuilder>("deliveryPolicy", build);
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldDeliveryPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("deliveryPrice", build);
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldDiscounts(Func<SubscriptionManualDiscountConnectionQueryBuilder, SubscriptionManualDiscountConnectionQueryBuilder> build)
    {
        AddField<SubscriptionManualDiscountConnection, SubscriptionManualDiscountConnectionQueryBuilder>("discounts", build);
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldLastBillingAttemptErrorType()
    {
        AddField("lastBillingAttemptErrorType");
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldLastPaymentStatus()
    {
        AddField("lastPaymentStatus");
        return this;
    }

    [Obsolete("Use `linesCount` instead.")]
    public SubscriptionContractQueryBuilder AddFieldLineCount()
    {
        AddField("lineCount");
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldLines(Func<SubscriptionLineConnectionQueryBuilder, SubscriptionLineConnectionQueryBuilder> build)
    {
        AddField<SubscriptionLineConnection, SubscriptionLineConnectionQueryBuilder>("lines", build);
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldLinesCount(Func<CountQueryBuilder, CountQueryBuilder> build)
    {
        AddField<Count, CountQueryBuilder>("linesCount", build);
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldNextBillingDate()
    {
        AddField("nextBillingDate");
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldNote()
    {
        AddField("note");
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldOrders(Func<OrderConnectionQueryBuilder, OrderConnectionQueryBuilder> build)
    {
        AddField<OrderConnection, OrderConnectionQueryBuilder>("orders", build);
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldOriginOrder(Func<OrderQueryBuilder, OrderQueryBuilder> build)
    {
        AddField<Order, OrderQueryBuilder>("originOrder", build);
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldRevisionId()
    {
        AddField("revisionId");
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }
}