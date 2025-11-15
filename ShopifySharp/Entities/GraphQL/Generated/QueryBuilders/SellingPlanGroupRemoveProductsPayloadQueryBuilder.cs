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

public class SellingPlanGroupRemoveProductsPayloadQueryBuilder() : GraphQueryBuilder<SellingPlanGroupRemoveProductsPayload>("query sellingPlanGroupRemoveProductsPayload")
{
    public SellingPlanGroupRemoveProductsPayloadQueryBuilder AddFieldRemovedProductIds()
    {
        AddField("removedProductIds");
        return this;
    }

    public SellingPlanGroupRemoveProductsPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}