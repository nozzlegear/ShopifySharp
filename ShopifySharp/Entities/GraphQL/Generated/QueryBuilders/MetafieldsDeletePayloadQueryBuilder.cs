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

public class MetafieldsDeletePayloadQueryBuilder() : GraphQueryBuilder<MetafieldsDeletePayload>("query metafieldsDeletePayload")
{
    public MetafieldsDeletePayloadQueryBuilder AddFieldDeletedMetafields()
    {
        AddField("deletedMetafields");
        return this;
    }

    public MetafieldsDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}