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

public class QuantityPricingByVariantUpdatePayloadQueryBuilder() : GraphQueryBuilder<QuantityPricingByVariantUpdatePayload>("query quantityPricingByVariantUpdatePayload")
{
    public QuantityPricingByVariantUpdatePayloadQueryBuilder AddFieldProductVariants()
    {
        AddField("productVariants");
        return this;
    }

    public QuantityPricingByVariantUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}