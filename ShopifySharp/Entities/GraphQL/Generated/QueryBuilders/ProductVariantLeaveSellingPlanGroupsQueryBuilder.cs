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

public class ProductVariantLeaveSellingPlanGroupsQueryBuilder() : GraphQueryBuilder<ProductVariantLeaveSellingPlanGroupsPayload>("query productVariantLeaveSellingPlanGroups")
{
    public ProductVariantLeaveSellingPlanGroupsQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public ProductVariantLeaveSellingPlanGroupsQueryBuilder AddArgumentSellingPlanGroupIds(ICollection<string>? sellingPlanGroupIds)
    {
        AddArgument("sellingPlanGroupIds", sellingPlanGroupIds);
        return this;
    }
}