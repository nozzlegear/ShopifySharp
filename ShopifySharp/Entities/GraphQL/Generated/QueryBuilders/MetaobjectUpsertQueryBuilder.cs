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

public class MetaobjectUpsertQueryBuilder() : GraphQueryBuilder<MetaobjectUpsertPayload>("query metaobjectUpsert")
{
    public MetaobjectUpsertQueryBuilder AddArgumentHandle(MetaobjectHandleInput? handle)
    {
        AddArgument("handle", handle);
        return this;
    }

    public MetaobjectUpsertQueryBuilder AddArgumentMetaobject(MetaobjectUpsertInput? metaobject)
    {
        AddArgument("metaobject", metaobject);
        return this;
    }
}