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

public class SellingPlanGroupAddProductVariantsQueryBuilder() : GraphQueryBuilder<SellingPlanGroupAddProductVariantsPayload>("query sellingPlanGroupAddProductVariants")
{
    public SellingPlanGroupAddProductVariantsQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public SellingPlanGroupAddProductVariantsQueryBuilder AddArgumentProductVariantIds(ICollection<string>? productVariantIds)
    {
        AddArgument("productVariantIds", productVariantIds);
        return this;
    }
}