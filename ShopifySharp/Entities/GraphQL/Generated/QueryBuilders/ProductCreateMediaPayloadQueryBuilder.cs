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

public class ProductCreateMediaPayloadQueryBuilder() : GraphQueryBuilder<ProductCreateMediaPayload>("query productCreateMediaPayload")
{
    public ProductCreateMediaPayloadQueryBuilder AddFieldMedia()
    {
        AddField("media");
        return this;
    }

    public ProductCreateMediaPayloadQueryBuilder AddFieldMediaUserErrors()
    {
        AddField("mediaUserErrors");
        return this;
    }

    public ProductCreateMediaPayloadQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }

    [Obsolete("Use `mediaUserErrors` instead.")]
    public ProductCreateMediaPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}