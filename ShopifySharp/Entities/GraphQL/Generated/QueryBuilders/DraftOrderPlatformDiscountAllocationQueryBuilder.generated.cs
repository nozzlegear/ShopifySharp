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

public class DraftOrderPlatformDiscountAllocationQueryBuilder() : GraphQueryBuilder<DraftOrderPlatformDiscountAllocation>("draftOrderPlatformDiscountAllocation")
{
    public DraftOrderPlatformDiscountAllocationQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public DraftOrderPlatformDiscountAllocationQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }

    public DraftOrderPlatformDiscountAllocationQueryBuilder AddFieldReductionAmount(Func<MoneyV2QueryBuilder, MoneyV2QueryBuilder> build)
    {
        AddField<MoneyV2, MoneyV2QueryBuilder>("reductionAmount", build);
        return this;
    }

    public DraftOrderPlatformDiscountAllocationQueryBuilder AddFieldReductionAmountSet(Func<MoneyBagQueryBuilder, MoneyBagQueryBuilder> build)
    {
        AddField<MoneyBag, MoneyBagQueryBuilder>("reductionAmountSet", build);
        return this;
    }

    public DraftOrderPlatformDiscountAllocationQueryBuilder AddUnionCaseTarget(Func<CalculatedDraftOrderLineItemQueryBuilder, CalculatedDraftOrderLineItemQueryBuilder> build)
    {
        AddUnion<CalculatedDraftOrderLineItem, CalculatedDraftOrderLineItemQueryBuilder>("target", build);
        return this;
    }

    public DraftOrderPlatformDiscountAllocationQueryBuilder AddUnionCaseTarget(Func<DraftOrderLineItemQueryBuilder, DraftOrderLineItemQueryBuilder> build)
    {
        AddUnion<DraftOrderLineItem, DraftOrderLineItemQueryBuilder>("target", build);
        return this;
    }

    public DraftOrderPlatformDiscountAllocationQueryBuilder AddUnionCaseTarget(Func<ShippingLineQueryBuilder, ShippingLineQueryBuilder> build)
    {
        AddUnion<ShippingLine, ShippingLineQueryBuilder>("target", build);
        return this;
    }
}