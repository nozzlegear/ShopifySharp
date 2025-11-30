#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class QuantityPricingByVariantUpdatePayloadQueryBuilder() : GraphQueryBuilder<QuantityPricingByVariantUpdatePayload>("quantityPricingByVariantUpdatePayload")
{
    public QuantityPricingByVariantUpdatePayloadQueryBuilder AddFieldProductVariants(Func<ProductVariantQueryBuilder, ProductVariantQueryBuilder> build)
    {
        AddField<ProductVariant, ProductVariantQueryBuilder>("productVariants", build);
        return this;
    }

    public QuantityPricingByVariantUpdatePayloadQueryBuilder AddFieldUserErrors(Func<QuantityPricingByVariantUserErrorQueryBuilder, QuantityPricingByVariantUserErrorQueryBuilder> build)
    {
        AddField<QuantityPricingByVariantUserError, QuantityPricingByVariantUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}