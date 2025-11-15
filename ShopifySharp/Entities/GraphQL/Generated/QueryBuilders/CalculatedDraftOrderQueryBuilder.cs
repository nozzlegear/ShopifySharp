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

public class CalculatedDraftOrderQueryBuilder() : GraphQueryBuilder<CalculatedDraftOrder>("query calculatedDraftOrder")
{
    public CalculatedDraftOrderQueryBuilder AddFieldAcceptAutomaticDiscounts()
    {
        AddField("acceptAutomaticDiscounts");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldAlerts()
    {
        AddField("alerts");
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

    public CalculatedDraftOrderQueryBuilder AddFieldAppliedDiscount()
    {
        AddField("appliedDiscount");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldAvailableShippingRates()
    {
        AddField("availableShippingRates");
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

    public CalculatedDraftOrderQueryBuilder AddFieldCustomer()
    {
        AddField("customer");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldDiscountCodes()
    {
        AddField("discountCodes");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldLineItems()
    {
        AddField("lineItems");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldLineItemsSubtotalPrice()
    {
        AddField("lineItemsSubtotalPrice");
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

    public CalculatedDraftOrderQueryBuilder AddFieldPlatformDiscounts()
    {
        AddField("platformDiscounts");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldPresentmentCurrencyCode()
    {
        AddField("presentmentCurrencyCode");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldPurchasingEntity()
    {
        AddField("purchasingEntity");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldShippingLine()
    {
        AddField("shippingLine");
        return this;
    }

    [Obsolete("Use `subtotalPriceSet` instead.")]
    public CalculatedDraftOrderQueryBuilder AddFieldSubtotalPrice()
    {
        AddField("subtotalPrice");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldSubtotalPriceSet()
    {
        AddField("subtotalPriceSet");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldTaxesIncluded()
    {
        AddField("taxesIncluded");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldTaxLines()
    {
        AddField("taxLines");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldTotalDiscountsSet()
    {
        AddField("totalDiscountsSet");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldTotalLineItemsPriceSet()
    {
        AddField("totalLineItemsPriceSet");
        return this;
    }

    [Obsolete("Use `totalPriceSet` instead.")]
    public CalculatedDraftOrderQueryBuilder AddFieldTotalPrice()
    {
        AddField("totalPrice");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldTotalPriceSet()
    {
        AddField("totalPriceSet");
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

    public CalculatedDraftOrderQueryBuilder AddFieldTotalShippingPriceSet()
    {
        AddField("totalShippingPriceSet");
        return this;
    }

    [Obsolete("Use `totalTaxSet` instead.")]
    public CalculatedDraftOrderQueryBuilder AddFieldTotalTax()
    {
        AddField("totalTax");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldTotalTaxSet()
    {
        AddField("totalTaxSet");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldTransformerFingerprint()
    {
        AddField("transformerFingerprint");
        return this;
    }

    public CalculatedDraftOrderQueryBuilder AddFieldWarnings()
    {
        AddField("warnings");
        return this;
    }
}