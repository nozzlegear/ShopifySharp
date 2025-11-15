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

public class ProductVariantPricePairConnectionQueryBuilder() : GraphQueryBuilder<ProductVariantPricePairConnection>("query productVariantPricePairConnection")
{
    public ProductVariantPricePairConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public ProductVariantPricePairConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public ProductVariantPricePairConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}