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

public class SubscriptionBillingCycleEditedContractQueryBuilder() : GraphQueryBuilder<SubscriptionBillingCycleEditedContract>("subscriptionBillingCycleEditedContract")
{
    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldApp(Func<AppQueryBuilder, AppQueryBuilder> build)
    {
        AddField<App, AppQueryBuilder>("app", build);
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldAppAdminUrl()
    {
        AddField("appAdminUrl");
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldBillingCycles(Func<SubscriptionBillingCycleConnectionQueryBuilder, SubscriptionBillingCycleConnectionQueryBuilder> build)
    {
        AddField<SubscriptionBillingCycleConnection, SubscriptionBillingCycleConnectionQueryBuilder>("billingCycles", build);
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

    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldCustomAttributes(Func<AttributeQueryBuilder, AttributeQueryBuilder> build)
    {
        AddField<ShopifySharp.GraphQL.Attribute, AttributeQueryBuilder>("customAttributes", build);
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldCustomer(Func<CustomerQueryBuilder, CustomerQueryBuilder> build)
    {
        AddField<Customer, CustomerQueryBuilder>("customer", build);
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldCustomerPaymentMethod(Func<CustomerPaymentMethodQueryBuilder, CustomerPaymentMethodQueryBuilder> build)
    {
        AddField<CustomerPaymentMethod, CustomerPaymentMethodQueryBuilder>("customerPaymentMethod", build);
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddUnionCaseDeliveryMethod(Func<SubscriptionDeliveryMethodLocalDeliveryQueryBuilder, SubscriptionDeliveryMethodLocalDeliveryQueryBuilder> build)
    {
        AddUnion<SubscriptionDeliveryMethodLocalDelivery, SubscriptionDeliveryMethodLocalDeliveryQueryBuilder>("deliveryMethod", build);
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddUnionCaseDeliveryMethod(Func<SubscriptionDeliveryMethodPickupQueryBuilder, SubscriptionDeliveryMethodPickupQueryBuilder> build)
    {
        AddUnion<SubscriptionDeliveryMethodPickup, SubscriptionDeliveryMethodPickupQueryBuilder>("deliveryMethod", build);
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddUnionCaseDeliveryMethod(Func<SubscriptionDeliveryMethodShippingQueryBuilder, SubscriptionDeliveryMethodShippingQueryBuilder> build)
    {
        AddUnion<SubscriptionDeliveryMethodShipping, SubscriptionDeliveryMethodShippingQueryBuilder>("deliveryMethod", build);
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldDeliveryPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("deliveryPrice", build);
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldDiscounts(Func<SubscriptionManualDiscountConnectionQueryBuilder, SubscriptionManualDiscountConnectionQueryBuilder> build)
    {
        AddField<SubscriptionManualDiscountConnection, SubscriptionManualDiscountConnectionQueryBuilder>("discounts", build);
        return this;
    }

    [Obsolete("Use `linesCount` instead.")]
    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldLineCount()
    {
        AddField("lineCount");
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldLines(Func<SubscriptionLineConnectionQueryBuilder, SubscriptionLineConnectionQueryBuilder> build)
    {
        AddField<SubscriptionLineConnection, SubscriptionLineConnectionQueryBuilder>("lines", build);
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldLinesCount(Func<CountQueryBuilder, CountQueryBuilder> build)
    {
        AddField<Count, CountQueryBuilder>("linesCount", build);
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldNote()
    {
        AddField("note");
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldOrders(Func<OrderConnectionQueryBuilder, OrderConnectionQueryBuilder> build)
    {
        AddField<OrderConnection, OrderConnectionQueryBuilder>("orders", build);
        return this;
    }

    public SubscriptionBillingCycleEditedContractQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }
}