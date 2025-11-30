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

public class SellingPlanGroupDeletePayloadQueryBuilder() : GraphQueryBuilder<SellingPlanGroupDeletePayload>("query sellingPlanGroupDeletePayload")
{
    public SellingPlanGroupDeletePayloadQueryBuilder AddFieldDeletedSellingPlanGroupId()
    {
        AddField("deletedSellingPlanGroupId");
        return this;
    }

    public SellingPlanGroupDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}