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

public class ProductBundleComponentQuantityOptionValueQueryBuilder() : GraphQueryBuilder<ProductBundleComponentQuantityOptionValue>("query productBundleComponentQuantityOptionValue")
{
    public ProductBundleComponentQuantityOptionValueQueryBuilder AddFieldName()
    {
        AddField("name");
        return this;
    }

    public ProductBundleComponentQuantityOptionValueQueryBuilder AddFieldQuantity()
    {
        AddField("quantity");
        return this;
    }
}