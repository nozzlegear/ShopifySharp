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

public class ProductVariantConnectionQueryBuilder() : GraphQueryBuilder<ProductVariantConnection>("query productVariantConnection")
{
    public ProductVariantConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public ProductVariantConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public ProductVariantConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}