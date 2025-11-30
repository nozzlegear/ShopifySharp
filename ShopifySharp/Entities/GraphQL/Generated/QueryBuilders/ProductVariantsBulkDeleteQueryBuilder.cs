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

public class ProductVariantsBulkDeleteQueryBuilder() : GraphQueryBuilder<ProductVariantsBulkDeletePayload>("query productVariantsBulkDelete")
{
    public ProductVariantsBulkDeleteQueryBuilder AddArgumentProductId(string? productId)
    {
        AddArgument("productId", productId);
        return this;
    }

    public ProductVariantsBulkDeleteQueryBuilder AddArgumentVariantsIds(ICollection<string>? variantsIds)
    {
        AddArgument("variantsIds", variantsIds);
        return this;
    }
}