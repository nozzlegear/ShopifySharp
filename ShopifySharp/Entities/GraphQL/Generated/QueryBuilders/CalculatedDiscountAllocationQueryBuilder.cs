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

public class CalculatedDiscountAllocationQueryBuilder() : GraphQueryBuilder<CalculatedDiscountAllocation>("query calculatedDiscountAllocation")
{
    public CalculatedDiscountAllocationQueryBuilder AddFieldAllocatedAmountSet()
    {
        AddField("allocatedAmountSet");
        return this;
    }

    public CalculatedDiscountAllocationQueryBuilder AddFieldDiscountApplication()
    {
        AddField("discountApplication");
        return this;
    }
}