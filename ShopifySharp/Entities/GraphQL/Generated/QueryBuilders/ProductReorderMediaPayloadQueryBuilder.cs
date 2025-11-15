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

public class ProductReorderMediaPayloadQueryBuilder() : GraphQueryBuilder<ProductReorderMediaPayload>("query productReorderMediaPayload")
{
    public ProductReorderMediaPayloadQueryBuilder AddFieldJob()
    {
        AddField("job");
        return this;
    }

    public ProductReorderMediaPayloadQueryBuilder AddFieldMediaUserErrors()
    {
        AddField("mediaUserErrors");
        return this;
    }

    [Obsolete("Use `mediaUserErrors` instead.")]
    public ProductReorderMediaPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}