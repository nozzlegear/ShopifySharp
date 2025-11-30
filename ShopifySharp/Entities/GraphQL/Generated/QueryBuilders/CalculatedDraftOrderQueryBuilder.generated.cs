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

public class CalculatedDraftOrderQueryBuilder() : GraphQueryBuilder<CalculatedDraftOrder>("calculatedDraftOrder")
{
    public CalculatedDraftOrderQueryBuilder AddFieldAcceptAutomaticDiscounts()
    {
        AddField("acceptAutomaticDiscounts");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldAlerts(Func<ResourceAlertQueryBuilder, ResourceAlertQueryBuilder> build)
    {
        AddField<ResourceAlert, ResourceAlertQueryBuilder>("alerts", build);
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldAllVariantPricesOverridden()
    {
        AddField("allVariantPricesOverridden");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldAnyVariantPricesOverridden()
    {
        AddField("anyVariantPricesOverridden");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldAppliedDiscount(Func<DraftOrderAppliedDiscountQueryBuilder, DraftOrderAppliedDiscountQueryBuilder> build)
    {
        AddField<DraftOrderAppliedDiscount, DraftOrderAppliedDiscountQueryBuilder>("appliedDiscount", build);
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldAvailableShippingRates(Func<ShippingRateQueryBuilder, ShippingRateQueryBuilder> build)
    {
        AddField<ShippingRate, ShippingRateQueryBuilder>("availableShippingRates", build);
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldBillingAddressMatchesShippingAddress()
    {
        AddField("billingAddressMatchesShippingAddress");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldCurrencyCode()
    {
        AddField("currencyCode");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldCustomer(Func<CustomerQueryBuilder, CustomerQueryBuilder> build)
    {
        AddField<Customer, CustomerQueryBuilder>("customer", build);
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldDiscountCodes()
    {
        AddField("discountCodes");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldLineItems(Func<CalculatedDraftOrderLineItemQueryBuilder, CalculatedDraftOrderLineItemQueryBuilder> build)
    {
        AddField<CalculatedDraftOrderLineItem, CalculatedDraftOrderLineItemQueryBuilder>("lineItems", build);
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldLineItemsSubtotalPrice(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("lineItemsSubtotalPrice", build);
        return this;
    }

    [Obsolete("This field is now incompatible with Markets.")]
    public CalculatedDraftOrderQueryBuilder AddFieldMarketName()
    {
        AddField("marketName");
        return this;
    }

    [Obsolete("This field is now incompatible with Markets.")]
    public CalculatedDraftOrderQueryBuilder AddFieldMarketRegionCountryCode()
    {
        AddField("marketRegionCountryCode");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldPhone()
    {
        AddField("phone");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldPlatformDiscounts(Func<DraftOrderPlatformDiscountQueryBuilder, DraftOrderPlatformDiscountQueryBuilder> build)
    {
        AddField<DraftOrderPlatformDiscount, DraftOrderPlatformDiscountQueryBuilder>("platformDiscounts", build);
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldPresentmentCurrencyCode()
    {
        AddField("presentmentCurrencyCode");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddUnionCasePurchasingEntity(Func<CustomerQueryBuilder, CustomerQueryBuilder> build)
    {
        AddUnion<Customer, CustomerQueryBuilder>("purchasingEntity", build);
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddUnionCasePurchasingEntity(Func<PurchasingCompanyQueryBuilder, PurchasingCompanyQueryBuilder> build)
    {
        AddUnion<PurchasingCompany, PurchasingCompanyQueryBuilder>("purchasingEntity", build);
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldShippingLine(Func<ShippingLineQueryBuilder, ShippingLineQueryBuilder> build)
    {
        AddField<ShippingLine, ShippingLineQueryBuilder>("shippingLine", build);
        return this;
    }

    [Obsolete("Use `subtotalPriceSet` instead.")]
    public CalculatedDraftOrderQueryBuilder AddFieldSubtotalPrice()
    {
        AddField("subtotalPrice");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldSubtotalPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("subtotalPriceSet", build);
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldTaxesIncluded()
    {
        AddField("taxesIncluded");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldTaxLines(Func<TaxLineQueryBuilder, TaxLineQueryBuilder> build)
    {
        AddField<TaxLine, TaxLineQueryBuilder>("taxLines", build);
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldTotalDiscountsSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalDiscountsSet", build);
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldTotalLineItemsPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalLineItemsPriceSet", build);
        return this;
    }

    [Obsolete("Use `totalPriceSet` instead.")]
    public CalculatedDraftOrderQueryBuilder AddFieldTotalPrice()
    {
        AddField("totalPrice");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldTotalPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalPriceSet", build);
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldTotalQuantityOfLineItems()
    {
        AddField("totalQuantityOfLineItems");
        return this;
    }

    [Obsolete("Use `totalShippingPriceSet` instead.")]
    public CalculatedDraftOrderQueryBuilder AddFieldTotalShippingPrice()
    {
        AddField("totalShippingPrice");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldTotalShippingPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalShippingPriceSet", build);
        return this;
    }

    [Obsolete("Use `totalTaxSet` instead.")]
    public CalculatedDraftOrderQueryBuilder AddFieldTotalTax()
    {
        AddField("totalTax");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldTotalTaxSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalTaxSet", build);
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldTransformerFingerprint()
    {
        AddField("transformerFingerprint");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldWarnings(Func<DraftOrderWarningQueryBuilder, DraftOrderWarningQueryBuilder> build)
    {
        AddField<IDraftOrderWarning, DraftOrderWarningQueryBuilder>("warnings", build);
        return this;
    }
}