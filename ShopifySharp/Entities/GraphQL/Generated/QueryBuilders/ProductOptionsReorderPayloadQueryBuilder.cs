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

public class ProductOptionsReorderPayloadQueryBuilder() : GraphQueryBuilder<ProductOptionsReorderPayload>("query productOptionsReorderPayload")
{
    public ProductOptionsReorderPayloadQueryBuilder AddFieldProduct()
    {
        AddField("product");
        return this;
    }

    public ProductOptionsReorderPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}