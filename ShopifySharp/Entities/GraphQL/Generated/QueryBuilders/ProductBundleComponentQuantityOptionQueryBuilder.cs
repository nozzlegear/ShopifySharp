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

public class ProductBundleComponentQuantityOptionQueryBuilder() : GraphQueryBuilder<ProductBundleComponentQuantityOption>("query productBundleComponentQuantityOption")
{
    public ProductBundleComponentQuantityOptionQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public ProductBundleComponentQuantityOptionQueryBuilder AddFieldParentOption()
    {
        AddField("parentOption");
        return this;
    }

    public ProductBundleComponentQuantityOptionQueryBuilder AddFieldValues()
    {
        AddField("values");
        return this;
    }
}