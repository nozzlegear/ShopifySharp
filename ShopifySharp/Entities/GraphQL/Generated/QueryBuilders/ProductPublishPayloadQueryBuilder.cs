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

public class ProductPublishPayloadQueryBuilder() : GraphQueryBuilder<ProductPublishPayload>("query productPublishPayload")
{
    public ProductPublishPayloadQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }

    [Obsolete("Use Product.publications instead.")]
    public ProductPublishPayloadQueryBuilder AddFieldProductPublications()
    {
        AddField("productPublications");
        return this;
    }

    public ProductPublishPayloadQueryBuilder AddFieldShop()
    {
        AddField("shop");
        return this;
    }

    public ProductPublishPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}