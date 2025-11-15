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

public class SubscriptionDraftQueryBuilder() : GraphQueryBuilder<SubscriptionDraft>("query subscriptionDraft")
{
    public SubscriptionDraftQueryBuilder AddFieldBillingCycle()
    {
        AddField("billingCycle");
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldBillingPolicy()
    {
        AddField("billingPolicy");
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldConcatenatedBillingCycles()
    {
        AddField("concatenatedBillingCycles");
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldCurrencyCode()
    {
        AddField("currencyCode");
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldCustomAttributes()
    {
        AddField("customAttributes");
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldCustomer()
    {
        AddField("customer");
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldCustomerPaymentMethod()
    {
        AddField("customerPaymentMethod");
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldDeliveryMethod()
    {
        AddField("deliveryMethod");
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldDeliveryOptions()
    {
        AddField("deliveryOptions");
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldDeliveryPolicy()
    {
        AddField("deliveryPolicy");
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldDeliveryPrice()
    {
        AddField("deliveryPrice");
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldDiscounts()
    {
        AddField("discounts");
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldDiscountsAdded()
    {
        AddField("discountsAdded");
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldDiscountsRemoved()
    {
        AddField("discountsRemoved");
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldDiscountsUpdated()
    {
        AddField("discountsUpdated");
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldLines()
    {
        AddField("lines");
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldLinesAdded()
    {
        AddField("linesAdded");
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldLinesRemoved()
    {
        AddField("linesRemoved");
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

    public SubscriptionDraftQueryBuilder AddFieldOriginalContract()
    {
        AddField("originalContract");
        return this;
    }

    [Obsolete("Use `deliveryOptions` instead.")]
    public SubscriptionDraftQueryBuilder AddFieldShippingOptions()
    {
        AddField("shippingOptions");
        return this;
    }

    public SubscriptionDraftQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }
}