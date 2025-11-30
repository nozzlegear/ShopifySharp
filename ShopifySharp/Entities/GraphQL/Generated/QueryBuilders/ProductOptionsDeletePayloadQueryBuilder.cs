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

public class ProductOptionsDeletePayloadQueryBuilder() : GraphQueryBuilder<ProductOptionsDeletePayload>("query productOptionsDeletePayload")
{
    public ProductOptionsDeletePayloadQueryBuilder AddFieldDeletedOptionsIds()
    {
        AddField("deletedOptionsIds");
        return this;
    }

    public ProductOptionsDeletePayloadQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }

    public ProductOptionsDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}