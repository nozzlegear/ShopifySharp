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

public class ProductDeleteMediaPayloadQueryBuilder() : GraphQueryBuilder<ProductDeleteMediaPayload>("query productDeleteMediaPayload")
{
    public ProductDeleteMediaPayloadQueryBuilder AddFieldDeletedMediaIds()
    {
        AddField("deletedMediaIds");
        return this;
    }

    public ProductDeleteMediaPayloadQueryBuilder AddFieldDeletedProductImageIds()
    {
        AddField("deletedProductImageIds");
        return this;
    }

    public ProductDeleteMediaPayloadQueryBuilder AddFieldMediaUserErrors()
    {
        AddField("mediaUserErrors");
        return this;
    }

    public ProductDeleteMediaPayloadQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }

    [Obsolete("Use `mediaUserErrors` instead.")]
    public ProductDeleteMediaPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}