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

public class ProductBundleComponentConnectionQueryBuilder() : GraphQueryBuilder<ProductBundleComponentConnection>("query productBundleComponentConnection")
{
    public ProductBundleComponentConnectionQueryBuilder AddFieldEdges()
    {
        AddField("edges");
        return this;
    }

    public ProductBundleComponentConnectionQueryBuilder AddFieldNodes()
    {
        AddField("nodes");
        return this;
    }

    public ProductBundleComponentConnectionQueryBuilder AddFieldPageInfo()
    {
        AddField("pageInfo");
        return this;
    }
}