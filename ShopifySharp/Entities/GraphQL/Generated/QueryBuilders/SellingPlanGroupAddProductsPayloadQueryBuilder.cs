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

public class SellingPlanGroupAddProductsPayloadQueryBuilder() : GraphQueryBuilder<SellingPlanGroupAddProductsPayload>("query sellingPlanGroupAddProductsPayload")
{
    public SellingPlanGroupAddProductsPayloadQueryBuilder AddFieldSellingPlanGroup()
    {
        AddField("sellingPlanGroup");
        return this;
    }

    public SellingPlanGroupAddProductsPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}