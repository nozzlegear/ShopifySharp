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

public class CalculatedOrderQueryBuilder() : GraphQueryBuilder<CalculatedOrder>("calculatedOrder")
{
    public CalculatedOrderQueryBuilder AddFieldAddedDiscountApplications(Func<CalculatedDiscountApplicationConnectionQueryBuilder, CalculatedDiscountApplicationConnectionQueryBuilder> build)
    {
        AddField<CalculatedDiscountApplicationConnection, CalculatedDiscountApplicationConnectionQueryBuilder>("addedDiscountApplications", build);
        return this;
    }

    public CalculatedOrderQueryBuilder AddFieldAddedLineItems(Func<CalculatedLineItemConnectionQueryBuilder, CalculatedLineItemConnectionQueryBuilder> build)
    {
        AddField<CalculatedLineItemConnection, CalculatedLineItemConnectionQueryBuilder>("addedLineItems", build);
        return this;
    }

    public CalculatedOrderQueryBuilder AddFieldCartDiscountAmountSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("cartDiscountAmountSet", build);
        return this;
    }

    [Obsolete("CalculatedOrder for committed order edits is being deprecated, and this field will also be removed in a future version.  See [changelog](https://shopify.dev/changelog/deprecation-notice-calculatedorder-for-committed-order-edits) for more details.")]
    public CalculatedOrderQueryBuilder AddFieldCommitted()
    {
        AddField("committed");
        return this;
    }

    public CalculatedOrderQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public CalculatedOrderQueryBuilder AddFieldLineItems(Func<CalculatedLineItemConnectionQueryBuilder, CalculatedLineItemConnectionQueryBuilder> build)
    {
        AddField<CalculatedLineItemConnection, CalculatedLineItemConnectionQueryBuilder>("lineItems", build);
        return this;
    }

    public CalculatedOrderQueryBuilder AddFieldNotificationPreviewHtml()
    {
        AddField("notificationPreviewHtml");
        return this;
    }

    public CalculatedOrderQueryBuilder AddFieldNotificationPreviewTitle()
    {
        AddField("notificationPreviewTitle");
        return this;
    }

    public CalculatedOrderQueryBuilder AddFieldOriginalOrder(Func<OrderQueryBuilder, OrderQueryBuilder> build)
    {
        AddField<Order, OrderQueryBuilder>("originalOrder", build);
        return this;
    }

    public CalculatedOrderQueryBuilder AddFieldShippingLines(Func<CalculatedShippingLineQueryBuilder, CalculatedShippingLineQueryBuilder> build)
    {
        AddField<CalculatedShippingLine, CalculatedShippingLineQueryBuilder>("shippingLines", build);
        return this;
    }

    public CalculatedOrderQueryBuilder AddFieldStagedChanges(Func<OrderStagedChangeConnectionQueryBuilder, OrderStagedChangeConnectionQueryBuilder> build)
    {
        AddField<OrderStagedChangeConnection, OrderStagedChangeConnectionQueryBuilder>("stagedChanges", build);
        return this;
    }

    public CalculatedOrderQueryBuilder AddFieldSubtotalLineItemsQuantity()
    {
        AddField("subtotalLineItemsQuantity");
        return this;
    }

    public CalculatedOrderQueryBuilder AddFieldSubtotalPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("subtotalPriceSet", build);
        return this;
    }

    public CalculatedOrderQueryBuilder AddFieldTaxLines(Func<TaxLineQueryBuilder, TaxLineQueryBuilder> build)
    {
        AddField<TaxLine, TaxLineQueryBuilder>("taxLines", build);
        return this;
    }

    public CalculatedOrderQueryBuilder AddFieldTotalOutstandingSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalOutstandingSet", build);
        return this;
    }

    public CalculatedOrderQueryBuilder AddFieldTotalPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("totalPriceSet", build);
        return this;
    }
}