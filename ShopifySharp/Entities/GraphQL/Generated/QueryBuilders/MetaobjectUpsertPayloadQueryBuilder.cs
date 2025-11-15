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

public class MetaobjectUpsertPayloadQueryBuilder() : GraphQueryBuilder<MetaobjectUpsertPayload>("query metaobjectUpsertPayload")
{
    public MetaobjectUpsertPayloadQueryBuilder AddFieldMetaobject()
    {
        AddField("metaobject");
        return this;
    }

    public MetaobjectUpsertPayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}