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

public class SellingPlanGroupRemoveProductVariantsQueryBuilder() : GraphQueryBuilder<SellingPlanGroupRemoveProductVariantsPayload>("query sellingPlanGroupRemoveProductVariants")
{
    public SellingPlanGroupRemoveProductVariantsQueryBuilder AddArgumentId(string? id)
    {
        AddArgument("id", id);
        return this;
    }

    public SellingPlanGroupRemoveProductVariantsQueryBuilder AddArgumentProductVariantIds(ICollection<string>? productVariantIds)
    {
        AddArgument("productVariantIds", productVariantIds);
        return this;
    }
}