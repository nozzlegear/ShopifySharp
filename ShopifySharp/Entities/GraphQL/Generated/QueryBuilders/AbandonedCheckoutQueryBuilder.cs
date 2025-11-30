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

public class AbandonedCheckoutQueryBuilder() : GraphQueryBuilder<AbandonedCheckout>("query abandonedCheckout")
{
    public AbandonedCheckoutQueryBuilder AddFieldAbandonedCheckoutUrl()
    {
        AddField("abandonedCheckoutUrl");
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldBillingAddress()
    {
        AddField("billingAddress");
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldCompletedAt()
    {
        AddField("completedAt");
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldCreatedAt()
    {
        AddField("createdAt");
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldCustomAttributes()
    {
        AddField("customAttributes");
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldCustomer()
    {
        AddField("customer");
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldDefaultCursor()
    {
        AddField("defaultCursor");
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldDiscountCodes()
    {
        AddField("discountCodes");
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldLineItems()
    {
        AddField("lineItems");
        return this;
    }

    [Obsolete("Use [AbandonedCheckoutLineItem.quantity](https://shopify.dev/api/admin-graphql/unstable/objects/AbandonedCheckoutLineItem#field-quantity) instead.")]
    public AbandonedCheckoutQueryBuilder AddFieldLineItemsQuantity()
    {
        AddField("lineItemsQuantity");
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldNote()
    {
        AddField("note");
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldShippingAddress()
    {
        AddField("shippingAddress");
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldSubtotalPriceSet()
    {
        AddField("subtotalPriceSet");
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldTaxesIncluded()
    {
        AddField("taxesIncluded");
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldTaxLines()
    {
        AddField("taxLines");
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldTotalDiscountSet()
    {
        AddField("totalDiscountSet");
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldTotalDutiesSet()
    {
        AddField("totalDutiesSet");
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldTotalLineItemsPriceSet()
    {
        AddField("totalLineItemsPriceSet");
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldTotalPriceSet()
    {
        AddField("totalPriceSet");
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldTotalTaxSet()
    {
        AddField("totalTaxSet");
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }
}