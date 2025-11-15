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

public class ProductFullSyncPayloadQueryBuilder() : GraphQueryBuilder<ProductFullSyncPayload>("query productFullSyncPayload")
{
    public ProductFullSyncPayloadQueryBuilder AddFieldId()
    {
        AddField("id");
        return this;
    }

    public ProductFullSyncPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}