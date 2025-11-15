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

public class QuantityPricingByVariantUserErrorQueryBuilder() : GraphQueryBuilder<QuantityPricingByVariantUserError>("query quantityPricingByVariantUserError")
{
    public QuantityPricingByVariantUserErrorQueryBuilder AddFieldCode()
    {
        AddField("code");
        return this;
    }

    public QuantityPricingByVariantUserErrorQueryBuilder AddFieldField()
    {
        AddField("field");
        return this;
    }

    public QuantityPricingByVariantUserErrorQueryBuilder AddFieldMessage()
    {
        AddField("message");
        return this;
    }
}