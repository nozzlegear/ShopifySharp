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

public class SubscriptionBillingCycleEditedContractQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleEditedContract>("query subscriptionBillingCycleEditedContract")
{
    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldApp()
    {
        AddField("app");
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldAppAdminUrl()
    {
        AddField("appAdminUrl");
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldBillingCycles()
    {
        AddField("billingCycles");
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldCurrencyCode()
    {
        AddField("currencyCode");
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldCustomAttributes()
    {
        AddField("customAttributes");
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldCustomer()
    {
        AddField("customer");
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldCustomerPaymentMethod()
    {
        AddField("customerPaymentMethod");
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldDeliveryMethod()
    {
        AddField("deliveryMethod");
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldDeliveryPrice()
    {
        AddField("deliveryPrice");
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldDiscounts()
    {
        AddField("discounts");
        return this;
    }

    [Obsolete("Use `linesCount` instead.")]
    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldLineCount()
    {
        AddField("lineCount");
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldLines()
    {
        AddField("lines");
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldLinesCount()
    {
        AddField("linesCount");
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldNote()
    {
        AddField("note");
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldOrders()
    {
        AddField("orders");
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }
}