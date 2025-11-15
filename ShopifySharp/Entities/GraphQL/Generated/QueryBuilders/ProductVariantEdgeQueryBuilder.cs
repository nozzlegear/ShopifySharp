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

public class ProductVariantEdgeQueryBuilder() : GraphQueryBuilder<ProductVariantEdge>("query productVariantEdge")
{
    public ProductVariantEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ProductVariantEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}