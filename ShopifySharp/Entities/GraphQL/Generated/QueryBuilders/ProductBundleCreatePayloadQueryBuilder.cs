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

public class ProductBundleCreatePayloadQueryBuilder() : GraphQueryBuilder<ProductBundleCreatePayload>("query productBundleCreatePayload")
{
    public ProductBundleCreatePayloadQueryBuilder AddFieldProductBundleOperation()
    {
        AddField("productBundleOperation");
        return this;
    }

    public ProductBundleCreatePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}