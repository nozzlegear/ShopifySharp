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

public class SubscriptionContractBaseQueryBuilder() : GraphQueryBuilder<ISubscriptionContractBase>("subscriptionContractBase")
{
    public SubscriptionContractBaseQueryBuilder AddFieldApp(Func<AppQueryBuilder, AppQueryBuilder> build)
    {
        AddField<App, AppQueryBuilder>("app", build);
        return this;
    }

    public SubscriptionContractBaseQueryBuilder AddFieldAppAdminUrl()
    {
        AddField("appAdminUrl");
        return this;
    }

    public SubscriptionContractBaseQueryBuilder AddFieldCurrencyCode()
    {
        AddField("currencyCode");
        return this;
    }

    public SubscriptionContractBaseQueryBuilder AddFieldCustomAttributes(Func<AttributeQueryBuilder, AttributeQueryBuilder> build)
    {
        AddField<ShopifySharp.GraphQL.Attribute, AttributeQueryBuilder>("customAttributes", build);
        return this;
    }

    public SubscriptionContractBaseQueryBuilder AddFieldCustomer(Func<CustomerQueryBuilder, CustomerQueryBuilder> build)
    {
        AddField<Customer, CustomerQueryBuilder>("customer", build);
        return this;
    }

    public SubscriptionContractBaseQueryBuilder AddFieldCustomerPaymentMethod(Func<CustomerPaymentMethodQueryBuilder, CustomerPaymentMethodQueryBuilder> build)
    {
        AddField<CustomerPaymentMethod, CustomerPaymentMethodQueryBuilder>("customerPaymentMethod", build);
        return this;
    }

    public SubscriptionContractBaseQueryBuilder AddUnionCaseDeliveryMethod(Func<SubscriptionDeliveryMethodLocalDeliveryQueryBuilder, SubscriptionDeliveryMethodLocalDeliveryQueryBuilder> build)
    {
        AddUnion<SubscriptionDeliveryMethodLocalDelivery, SubscriptionDeliveryMethodLocalDeliveryQueryBuilder>("deliveryMethod", build);
        return this;
    }

    public SubscriptionContractBaseQueryBuilder AddUnionCaseDeliveryMethod(Func<SubscriptionDeliveryMethodPickupQueryBuilder, SubscriptionDeliveryMethodPickupQueryBuilder> build)
    {
        AddUnion<SubscriptionDeliveryMethodPickup, SubscriptionDeliveryMethodPickupQueryBuilder>("deliveryMethod", build);
        return this;
    }

    public SubscriptionContractBaseQueryBuilder AddUnionCaseDeliveryMethod(Func<SubscriptionDeliveryMethodShippingQueryBuilder, SubscriptionDeliveryMethodShippingQueryBuilder> build)
    {
        AddUnion<SubscriptionDeliveryMethodShipping, SubscriptionDeliveryMethodShippingQueryBuilder>("deliveryMethod", build);
        return this;
    }

    public SubscriptionContractBaseQueryBuilder AddFieldDeliveryPrice(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("deliveryPrice", build);
        return this;
    }

    public SubscriptionContractBaseQueryBuilder AddFieldDiscounts(Func<SubscriptionManualDiscountConnectionQueryBuilder, SubscriptionManualDiscountConnectionQueryBuilder> build)
    {
        AddField<SubscriptionManualDiscountConnection, SubscriptionManualDiscountConnectionQueryBuilder>("discounts", build);
        return this;
    }

    [Obsolete("Use `linesCount` instead.")]
    public SubscriptionContractBaseQueryBuilder AddFieldLineCount()
    {
        AddField("lineCount");
        return this;
    }

    public SubscriptionContractBaseQueryBuilder AddFieldLines(Func<SubscriptionLineConnectionQueryBuilder, SubscriptionLineConnectionQueryBuilder> build)
    {
        AddField<SubscriptionLineConnection, SubscriptionLineConnectionQueryBuilder>("lines", build);
        return this;
    }

    public SubscriptionContractBaseQueryBuilder AddFieldLinesCount(Func<CountQueryBuilder, CountQueryBuilder> build)
    {
        AddField<Count, CountQueryBuilder>("linesCount", build);
        return this;
    }

    public SubscriptionContractBaseQueryBuilder AddFieldNote()
    {
        AddField("note");
        return this;
    }

    public SubscriptionContractBaseQueryBuilder AddFieldOrders(Func<OrderConnectionQueryBuilder, OrderConnectionQueryBuilder> build)
    {
        AddField<OrderConnection, OrderConnectionQueryBuilder>("orders", build);
        return this;
    }

    public SubscriptionContractBaseQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }
}