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

public class AbandonedCheckoutQueryBuilder() : GraphQueryBuilder<AbandonedCheckout>("abandonedCheckout")
{
    public AbandonedCheckoutQueryBuilder AddFieldAbandonedCheckoutUrl()
    {
        AddField("abandonedCheckoutUrl");
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldBillingAddress(Func<MailingAddressQueryBuilder, MailingAddressQueryBuilder> build)
    {
        AddField<MailingAddress, MailingAddressQueryBuilder>("billingAddress", build);
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

    public AbandonedCheckoutQueryBuilder AddFieldCustomAttributes(Func<AttributeQueryBuilder, AttributeQueryBuilder> build)
    {
        AddField<ShopifySharp.GraphQL.Attribute, AttributeQueryBuilder>("customAttributes", build);
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldCustomer(Func<CustomerQueryBuilder, CustomerQueryBuilder> build)
    {
        AddField<Customer, CustomerQueryBuilder>("customer", build);
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

    public AbandonedCheckoutQueryBuilder AddFieldLineItems(Func<AbandonedCheckoutLineItemConnectionQueryBuilder, AbandonedCheckoutLineItemConnectionQueryBuilder> build)
    {
        AddField<AbandonedCheckoutLineItemConnection, AbandonedCheckoutLineItemConnectionQueryBuilder>("lineItems", build);
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

    public AbandonedCheckoutQueryBuilder AddFieldShippingAddress(Func<MailingAddressQueryBuilder, MailingAddressQueryBuilder> build)
    {
        AddField<MailingAddress, MailingAddressQueryBuilder>("shippingAddress", build);
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldSubtotalPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("subtotalPriceSet", build);
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldTaxesIncluded()
    {
        AddField("taxesIncluded");
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldTaxLines(Func<TaxLineQueryBuilder, TaxLineQueryBuilder> build)
    {
        AddField<TaxLine, TaxLineQueryBuilder>("taxLines", build);
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldTotalDiscountSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalDiscountSet", build);
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldTotalDutiesSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalDutiesSet", build);
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldTotalLineItemsPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalLineItemsPriceSet", build);
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldTotalPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalPriceSet", build);
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldTotalTaxSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalTaxSet", build);
        return this;
    }

    public AbandonedCheckoutQueryBuilder AddFieldUpdatedAt()
    {
        AddField("updatedAt");
        return this;
    }
}