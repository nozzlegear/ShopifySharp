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

public class ProductLeaveSellingPlanGroupsPayloadQueryBuilder() : GraphQueryBuilder<ProductLeaveSellingPlanGroupsPayload>("query productLeaveSellingPlanGroupsPayload")
{
    public ProductLeaveSellingPlanGroupsPayloadQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }

    public ProductLeaveSellingPlanGroupsPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}