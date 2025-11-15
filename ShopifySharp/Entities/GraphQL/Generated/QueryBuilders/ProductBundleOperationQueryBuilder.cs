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

public class ProductBundleOperationQueryBuilder() : GraphQueryBuilder<ProductBundleOperation>("query productBundleOperation")
{
    public ProductBundleOperationQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ProductBundleOperationQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }

    public ProductBundleOperationQueryBuilder AddFieldStatus()
    {
        AddField("status");
        return this;
    }

    public ProductBundleOperationQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}