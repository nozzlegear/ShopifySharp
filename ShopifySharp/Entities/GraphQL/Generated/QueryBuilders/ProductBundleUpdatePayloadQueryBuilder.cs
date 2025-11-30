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

public class ProductBundleUpdatePayloadQueryBuilder() : GraphQueryBuilder<ProductBundleUpdatePayload>("query productBundleUpdatePayload")
{
    public ProductBundleUpdatePayloadQueryBuilder AddFieldProductBundleOperation()
    {
        AddField("productBundleOperation");
        return this;
    }

    public ProductBundleUpdatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}