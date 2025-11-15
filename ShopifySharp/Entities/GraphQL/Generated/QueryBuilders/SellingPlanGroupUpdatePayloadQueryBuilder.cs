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

public class SellingPlanGroupUpdatePayloadQueryBuilder() : GraphQueryBuilder<SellingPlanGroupUpdatePayload>("query sellingPlanGroupUpdatePayload")
{
    public SellingPlanGroupUpdatePayloadQueryBuilder AddFieldDeletedSellingPlanIds()
    {
        AddField("deletedSellingPlanIds");
        return this;
    }

    public SellingPlanGroupUpdatePayloadQueryBuilder AddFieldSellingPlanGroup()
    {
        AddField("sellingPlanGroup");
        return this;
    }

    public SellingPlanGroupUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}