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

public class DiscountAllocationQueryBuilder() : GraphQueryBuilder<DiscountAllocation>("query discountAllocation")
{
    [Obsolete("Use `allocatedAmountSet` instead.")]
    public DiscountAllocationQueryBuilder AddFieldAllocatedAmount()
    {
        AddField("allocatedAmount");
        return this;
    }

    public DiscountAllocationQueryBuilder AddFieldAllocatedAmountSet()
    {
        AddField("allocatedAmountSet");
        return this;
    }

    public DiscountAllocationQueryBuilder AddFieldDiscountApplication()
    {
        AddField("discountApplication");
        return this;
    }
}