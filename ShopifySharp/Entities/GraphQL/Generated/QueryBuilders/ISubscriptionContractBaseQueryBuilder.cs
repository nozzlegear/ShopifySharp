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

public class ISubscriptionContractBaseQueryBuilder() : GraphQueryBuilder<ISubscriptionContractBase>("query iSubscriptionContractBase")
{
    public ISubscriptionContractBaseQueryBuilder AddFieldApp()
    {
        AddField("app");
        return this;
    }

    public ISubscriptionContractBaseQueryBuilder AddFieldAppAdminUrl()
    {
        AddField("appAdminUrl");
        return this;
    }

    public ISubscriptionContractBaseQueryBuilder AddFieldCurrencyCode()
    {
        AddField("currencyCode");
        return this;
    }

    public ISubscriptionContractBaseQueryBuilder AddFieldCustomAttributes()
    {
        AddField("customAttributes");
        return this;
    }

    public ISubscriptionContractBaseQueryBuilder AddFieldCustomer()
    {
        AddField("customer");
        return this;
    }

    public ISubscriptionContractBaseQueryBuilder AddFieldCustomerPaymentMethod()
    {
        AddField("customerPaymentMethod");
        return this;
    }

    public ISubscriptionContractBaseQueryBuilder AddFieldDeliveryMethod()
    {
        AddField("deliveryMethod");
        return this;
    }

    public ISubscriptionContractBaseQueryBuilder AddFieldDeliveryPrice()
    {
        AddField("deliveryPrice");
        return this;
    }

    public ISubscriptionContractBaseQueryBuilder AddFieldDiscounts()
    {
        AddField("discounts");
        return this;
    }

    [Obsolete("Use `linesCount` instead.")]
    public ISubscriptionContractBaseQueryBuilder AddFieldLineCount()
    {
        AddField("lineCount");
        return this;
    }

    public ISubscriptionContractBaseQueryBuilder AddFieldLines()
    {
        AddField("lines");
        return this;
    }

    public ISubscriptionContractBaseQueryBuilder AddFieldLinesCount()
    {
        AddField("linesCount");
        return this;
    }

    public ISubscriptionContractBaseQueryBuilder AddFieldNote()
    {
        AddField("note");
        return this;
    }

    public ISubscriptionContractBaseQueryBuilder AddFieldOrders()
    {
        AddField("orders");
        return this;
    }

    public ISubscriptionContractBaseQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }
}