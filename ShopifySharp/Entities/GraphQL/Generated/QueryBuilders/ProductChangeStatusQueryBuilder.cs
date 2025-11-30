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

[Obsolete("Use `productUpdate` instead.")]
public class ProductChangeStatusQueryBuilder() : GraphQueryBuilder<ProductChangeStatusPayload>("query productChangeStatus")
{
    public ProductChangeStatusQueryBuilder AddArgumentProductId(string? productId)
    {
        AddArgument("productId", productId);
        return this;
    }

    public ProductChangeStatusQueryBuilder AddArgumentStatus(ProductStatus? status)
    {
        AddArgument("status", status);
        return this;
    }
}