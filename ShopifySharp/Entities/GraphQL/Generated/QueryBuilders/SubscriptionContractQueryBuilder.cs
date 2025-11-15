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

public class SubscriptionContractQueryBuilder() : GraphQueryBuilder<SubscriptionContract>("query subscriptionContract")
{
    public SubscriptionContractQueryBuilder AddFieldApp()
    {
        AddField("app");
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldAppAdminUrl()
    {
        AddField("appAdminUrl");
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldBillingAttempts()
    {
        AddField("billingAttempts");
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldBillingPolicy()
    {
        AddField("billingPolicy");
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

    public SubscriptionContractQueryBuilder AddFieldCustomAttributes()
    {
        AddField("customAttributes");
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldCustomer()
    {
        AddField("customer");
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldCustomerPaymentMethod()
    {
        AddField("customerPaymentMethod");
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldDeliveryMethod()
    {
        AddField("deliveryMethod");
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldDeliveryPolicy()
    {
        AddField("deliveryPolicy");
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldDeliveryPrice()
    {
        AddField("deliveryPrice");
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldDiscounts()
    {
        AddField("discounts");
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

    public SubscriptionContractQueryBuilder AddFieldLines()
    {
        AddField("lines");
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldLinesCount()
    {
        AddField("linesCount");
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

    public SubscriptionContractQueryBuilder AddFieldOrders()
    {
        AddField("orders");
        return this;
    }

    public SubscriptionContractQueryBuilder AddFieldOriginOrder()
    {
        AddField("originOrder");
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