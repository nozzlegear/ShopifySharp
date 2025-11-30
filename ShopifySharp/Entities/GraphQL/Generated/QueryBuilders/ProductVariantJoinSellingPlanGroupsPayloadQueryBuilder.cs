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

public class ProductVariantJoinSellingPlanGroupsPayloadQueryBuilder() : GraphQueryBuilder<ProductVariantJoinSellingPlanGroupsPayload>("query productVariantJoinSellingPlanGroupsPayload")
{
    public ProductVariantJoinSellingPlanGroupsPayloadQueryBuilder AddFieldProductVariant()
    {
        AddField("productVariant");
        return this;
    }

    public ProductVariantJoinSellingPlanGroupsPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}