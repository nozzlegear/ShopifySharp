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

public class DraftOrderPlatformDiscountAllocationQueryBuilder() : GraphQueryBuilder<DraftOrderPlatformDiscountAllocation>("query draftOrderPlatformDiscountAllocation")
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

    public DraftOrderPlatformDiscountAllocationQueryBuilder AddFieldReductionAmount()
    {
        AddField("reductionAmount");
        return this;
    }

    public DraftOrderPlatformDiscountAllocationQueryBuilder AddFieldReductionAmountSet()
    {
        AddField("reductionAmountSet");
        return this;
    }

    public DraftOrderPlatformDiscountAllocationQueryBuilder AddFieldTarget()
    {
        AddField("target");
        return this;
    }
}