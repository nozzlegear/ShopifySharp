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

public class MetaobjectBulkDeletePayloadQueryBuilder() : GraphQueryBuilder<MetaobjectBulkDeletePayload>("query metaobjectBulkDeletePayload")
{
    public MetaobjectBulkDeletePayloadQueryBuilder AddFieldJob()
    {
        AddField("job");
        return this;
    }

    public MetaobjectBulkDeletePayloadQueryBuilder AddFieldUserErrors()
    {
        AddField("userErrors");
        return this;
    }
}