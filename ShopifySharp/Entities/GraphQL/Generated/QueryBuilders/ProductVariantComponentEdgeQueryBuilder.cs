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

public class ProductVariantComponentEdgeQueryBuilder() : GraphQueryBuilder<ProductVariantComponentEdge>("query productVariantComponentEdge")
{
    public ProductVariantComponentEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ProductVariantComponentEdgeQueryBuilder AddFieldNode()
    {
        AddField("node");
        return this;
    }
}