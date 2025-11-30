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

public class FulfillmentOrderLineItemQueryBuilder() : GraphQueryBuilder<FulfillmentOrderLineItem>("fulfillmentOrderLineItem")
{
    public FulfillmentOrderLineItemQueryBuilder AddFieldFinancialSummaries(Func<FulfillmentOrderLineItemFinancialSummaryQueryBuilder, FulfillmentOrderLineItemFinancialSummaryQueryBuilder> build)
    {
        AddField<FulfillmentOrderLineItemFinancialSummary, FulfillmentOrderLineItemFinancialSummaryQueryBuilder>("financialSummaries", build);
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldImage(Func<ImageQueryBuilder, ImageQueryBuilder> build)
    {
        AddField<Image, ImageQueryBuilder>("image", build);
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldInventoryItemId()
    {
        AddField("inventoryItemId");
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldLineItem(Func<LineItemQueryBuilder, LineItemQueryBuilder> build)
    {
        AddField<LineItem, LineItemQueryBuilder>("lineItem", build);
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldOriginalUnitPriceSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("originalUnitPriceSet", build);
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldProductTitle()
    {
        AddField("productTitle");
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldRemainingQuantity()
    {
        AddField("remainingQuantity");
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldRequiresShipping()
    {
        AddField("requiresShipping");
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldSku()
    {
        AddField("sku");
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldTotalQuantity()
    {
        AddField("totalQuantity");
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldVariant(Func<ProductVariantQueryBuilder, ProductVariantQueryBuilder> build)
    {
        AddField<ProductVariant, ProductVariantQueryBuilder>("variant", build);
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldVariantTitle()
    {
        AddField("variantTitle");
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldVendor()
    {
        AddField("vendor");
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldWarnings(Func<FulfillmentOrderLineItemWarningQueryBuilder, FulfillmentOrderLineItemWarningQueryBuilder> build)
    {
        AddField<FulfillmentOrderLineItemWarning, FulfillmentOrderLineItemWarningQueryBuilder>("warnings", build);
        return this;
    }

    public FulfillmentOrderLineItemQueryBuilder AddFieldWeight(Func<WeightQueryBuilder, WeightQueryBuilder> build)
    {
        AddField<Weight, WeightQueryBuilder>("weight", build);
        return this;
    }
}