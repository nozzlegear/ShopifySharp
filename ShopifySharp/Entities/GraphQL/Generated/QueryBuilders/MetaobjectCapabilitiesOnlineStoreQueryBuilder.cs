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

public class MetaobjectCapabilitiesOnlineStoreQueryBuilder() : GraphQueryBuilder<MetaobjectCapabilitiesOnlineStore>("query metaobjectCapabilitiesOnlineStore")
{
    public MetaobjectCapabilitiesOnlineStoreQueryBuilder AddFieldData()
    {
        AddField("data");
        return this;
    }

    public MetaobjectCapabilitiesOnlineStoreQueryBuilder AddFieldEnabled()
    {
        AddField("enabled");
        return this;
    }
}