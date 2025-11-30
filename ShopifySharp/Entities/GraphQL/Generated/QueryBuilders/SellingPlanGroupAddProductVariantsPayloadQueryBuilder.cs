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

public class SellingPlanGroupAddProductVariantsPayloadQueryBuilder() : GraphQueryBuilder<SellingPlanGroupAddProductVariantsPayload>("query sellingPlanGroupAddProductVariantsPayload")
{
    public SellingPlanGroupAddProductVariantsPayloadQueryBuilder AddFieldSellingPlanGroup()
    {
        AddField("sellingPlanGroup");
        return this;
    }

    public SellingPlanGroupAddProductVariantsPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}