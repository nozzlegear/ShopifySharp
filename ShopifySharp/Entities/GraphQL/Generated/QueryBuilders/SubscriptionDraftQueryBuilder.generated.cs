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

public class SubscriptionDraftQueryBuilder() : GraphQueryBuilder<SubscriptionDraft>("subscriptionDraft")
{
    public SubscriptionDraftQueryBuilder AddFieldBillingCycle(Func<SubscriptionBillingCycleQueryBuilder, SubscriptionBillingCycleQueryBuilder> build)
    {
        AddField<SubscriptionBillingCycle, SubscriptionBillingCycleQueryBuilder>("billingCycle", build);
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldBillingPolicy(Func<SubscriptionBillingPolicyQueryBuilder, SubscriptionBillingPolicyQueryBuilder> build)
    {
        AddField<SubscriptionBillingPolicy, SubscriptionBillingPolicyQueryBuilder>("billingPolicy", build);
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldConcatenatedBillingCycles(Func<SubscriptionBillingCycleConnectionQueryBuilder, SubscriptionBillingCycleConnectionQueryBuilder> build)
    {
        AddField<SubscriptionBillingCycleConnection, SubscriptionBillingCycleConnectionQueryBuilder>("concatenatedBillingCycles", build);
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldCurrencyCode()
    {
        AddField("currencyCode");
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldCustomAttributes(Func<AttributeQueryBuilder, AttributeQueryBuilder> build)
    {
        AddField<ShopifySharp.GraphQL.Attribute, AttributeQueryBuilder>("customAttributes", build);
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldCustomer(Func<CustomerQueryBuilder, CustomerQueryBuilder> build)
    {
        AddField<Customer, CustomerQueryBuilder>("customer", build);
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldCustomerPaymentMethod(Func<CustomerPaymentMethodQueryBuilder, CustomerPaymentMethodQueryBuilder> build)
    {
        AddField<CustomerPaymentMethod, CustomerPaymentMethodQueryBuilder>("customerPaymentMethod", build);
        return this;
    }

    public SubscriptionDraftQueryBuilder AddUnionCaseDeliveryMethod(Func<SubscriptionDeliveryMethodLocalDeliveryQueryBuilder, SubscriptionDeliveryMethodLocalDeliveryQueryBuilder> build)
    {
        AddUnion<SubscriptionDeliveryMethodLocalDelivery, SubscriptionDeliveryMethodLocalDeliveryQueryBuilder>("deliveryMethod", build);
        return this;
    }

    public SubscriptionDraftQueryBuilder AddUnionCaseDeliveryMethod(Func<SubscriptionDeliveryMethodPickupQueryBuilder, SubscriptionDeliveryMethodPickupQueryBuilder> build)
    {
        AddUnion<SubscriptionDeliveryMethodPickup, SubscriptionDeliveryMethodPickupQueryBuilder>("deliveryMethod", build);
        return this;
    }

    public SubscriptionDraftQueryBuilder AddUnionCaseDeliveryMethod(Func<SubscriptionDeliveryMethodShippingQueryBuilder, SubscriptionDeliveryMethodShippingQueryBuilder> build)
    {
        AddUnion<SubscriptionDeliveryMethodShipping, SubscriptionDeliveryMethodShippingQueryBuilder>("deliveryMethod", build);
        return this;
    }

    public SubscriptionDraftQueryBuilder AddUnionCaseDeliveryOptions(Func<SubscriptionDeliveryOptionResultFailureQueryBuilder, SubscriptionDeliveryOptionResultFailureQueryBuilder> build)
    {
        AddUnion<SubscriptionDeliveryOptionResultFailure, SubscriptionDeliveryOptionResultFailureQueryBuilder>("deliveryOptions", build);
        return this;
    }

    public SubscriptionDraftQueryBuilder AddUnionCaseDeliveryOptions(Func<SubscriptionDeliveryOptionResultSuccessQueryBuilder, SubscriptionDeliveryOptionResultSuccessQueryBuilder> build)
    {
        AddUnion<SubscriptionDeliveryOptionResultSuccess, SubscriptionDeliveryOptionResultSuccessQueryBuilder>("deliveryOptions", build);
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldDeliveryPolicy(Func<SubscriptionDeliveryPolicyQueryBuilder, SubscriptionDeliveryPolicyQueryBuilder> build)
    {
        AddField<SubscriptionDeliveryPolicy, SubscriptionDeliveryPolicyQueryBuilder>("deliveryPolicy", build);
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldDeliveryPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("deliveryPrice", build);
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldDiscounts(Func<SubscriptionDiscountConnectionQueryBuilder, SubscriptionDiscountConnectionQueryBuilder> build)
    {
        AddField<SubscriptionDiscountConnection, SubscriptionDiscountConnectionQueryBuilder>("discounts", build);
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldDiscountsAdded(Func<SubscriptionDiscountConnectionQueryBuilder, SubscriptionDiscountConnectionQueryBuilder> build)
    {
        AddField<SubscriptionDiscountConnection, SubscriptionDiscountConnectionQueryBuilder>("discountsAdded", build);
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldDiscountsRemoved(Func<SubscriptionDiscountConnectionQueryBuilder, SubscriptionDiscountConnectionQueryBuilder> build)
    {
        AddField<SubscriptionDiscountConnection, SubscriptionDiscountConnectionQueryBuilder>("discountsRemoved", build);
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldDiscountsUpdated(Func<SubscriptionDiscountConnectionQueryBuilder, SubscriptionDiscountConnectionQueryBuilder> build)
    {
        AddField<SubscriptionDiscountConnection, SubscriptionDiscountConnectionQueryBuilder>("discountsUpdated", build);
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldLines(Func<SubscriptionLineConnectionQueryBuilder, SubscriptionLineConnectionQueryBuilder> build)
    {
        AddField<SubscriptionLineConnection, SubscriptionLineConnectionQueryBuilder>("lines", build);
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldLinesAdded(Func<SubscriptionLineConnectionQueryBuilder, SubscriptionLineConnectionQueryBuilder> build)
    {
        AddField<SubscriptionLineConnection, SubscriptionLineConnectionQueryBuilder>("linesAdded", build);
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldLinesRemoved(Func<SubscriptionLineConnectionQueryBuilder, SubscriptionLineConnectionQueryBuilder> build)
    {
        AddField<SubscriptionLineConnection, SubscriptionLineConnectionQueryBuilder>("linesRemoved", build);
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldNextBillingDate()
    {
        AddField("nextBillingDate");
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldNote()
    {
        AddField("note");
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldOriginalContract(Func<SubscriptionContractQueryBuilder, SubscriptionContractQueryBuilder> build)
    {
        AddField<SubscriptionContract, SubscriptionContractQueryBuilder>("originalContract", build);
        return this;
    }

    public SubscriptionDraftQueryBuilder AddUnionCaseShippingOptions(Func<SubscriptionShippingOptionResultFailureQueryBuilder, SubscriptionShippingOptionResultFailureQueryBuilder> build)
    {
        AddUnion<SubscriptionShippingOptionResultFailure, SubscriptionShippingOptionResultFailureQueryBuilder>("shippingOptions", build);
        return this;
    }

    public SubscriptionDraftQueryBuilder AddUnionCaseShippingOptions(Func<SubscriptionShippingOptionResultSuccessQueryBuilder, SubscriptionShippingOptionResultSuccessQueryBuilder> build)
    {
        AddUnion<SubscriptionShippingOptionResultSuccess, SubscriptionShippingOptionResultSuccessQueryBuilder>("shippingOptions", build);
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }
}