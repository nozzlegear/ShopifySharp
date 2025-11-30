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

public class CalculatedOrderQueryBuilder() : GraphQueryBuilder<CalculatedOrder>("query calculatedOrder")
{
    public CalculatedOrderQueryBuilder AddFieldAddedDiscountApplications()
    {
        AddField("addedDiscountApplications");
        return this;
    }

    public CalculatedOrderQueryBuilder AddFieldAddedLineItems()
    {
        AddField("addedLineItems");
        return this;
    }

    public CalculatedOrderQueryBuilder AddFieldCartDiscountAmountSet()
    {
        AddField("cartDiscountAmountSet");
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

    public CalculatedOrderQueryBuilder AddFieldLineItems()
    {
        AddField("lineItems");
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

    public CalculatedOrderQueryBuilder AddFieldOriginalOrder()
    {
        AddField("originalOrder");
        return this;
    }

    public CalculatedOrderQueryBuilder AddFieldShippingLines()
    {
        AddField("shippingLines");
        return this;
    }

    public CalculatedOrderQueryBuilder AddFieldStagedChanges()
    {
        AddField("stagedChanges");
        return this;
    }

    public CalculatedOrderQueryBuilder AddFieldSubtotalLineItemsQuantity()
    {
        AddField("subtotalLineItemsQuantity");
        return this;
    }

    public CalculatedOrderQueryBuilder AddFieldSubtotalPriceSet()
    {
        AddField("subtotalPriceSet");
        return this;
    }

    public CalculatedOrderQueryBuilder AddFieldTaxLines()
    {
        AddField("taxLines");
        return this;
    }

    public CalculatedOrderQueryBuilder AddFieldTotalOutstandingSet()
    {
        AddField("totalOutstandingSet");
        return this;
    }

    public CalculatedOrderQueryBuilder AddFieldTotalPriceSet()
    {
        AddField("totalPriceSet");
        return this;
    }
}