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

public class ProductUpdateMediaPayloadQueryBuilder() : GraphQueryBuilder<ProductUpdateMediaPayload>("query productUpdateMediaPayload")
{
    public ProductUpdateMediaPayloadQueryBuilder AddFieldMedia()
    {
        AddField("media");
        return this;
    }

    public ProductUpdateMediaPayloadQueryBuilder AddFieldMediaUserErrors()
    {
        AddField("mediaUserErrors");
        return this;
    }

    public ProductUpdateMediaPayloadQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }

    [Obsolete("Use `mediaUserErrors` instead.")]
    public ProductUpdateMediaPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}