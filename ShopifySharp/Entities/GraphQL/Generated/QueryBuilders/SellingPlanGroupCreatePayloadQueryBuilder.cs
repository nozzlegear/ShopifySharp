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

public class SellingPlanGroupCreatePayloadQueryBuilder() : GraphQueryBuilder<SellingPlanGroupCreatePayload>("query sellingPlanGroupCreatePayload")
{
    public SellingPlanGroupCreatePayloadQueryBuilder AddFieldSellingPlanGroup()
    {
        AddField("sellingPlanGroup");
        return this;
    }

    public SellingPlanGroupCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}