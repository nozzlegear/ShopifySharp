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

public class ProductVariantComponentConnectionQueryBuilder() : GraphQueryBuilder<ProductVariantComponentConnection>("query productVariantComponentConnection")
{
    public ProductVariantComponentConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public ProductVariantComponentConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public ProductVariantComponentConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}