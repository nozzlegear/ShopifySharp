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

public class ShopifyProtectOrderSummaryQueryBuilder() : GraphQueryBuilder<ShopifyProtectOrderSummary>("query shopifyProtectOrderSummary")
{
    public ShopifyProtectOrderSummaryQueryBuilder AddFieldEligibility()
    {
        AddField("eligibility");
        return this;
    }

    public ShopifyProtectOrderSummaryQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }
}