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

public class MetaobjectCapabilitiesQueryBuilder() : GraphQueryBuilder<MetaobjectCapabilities>("query metaobjectCapabilities")
{
    public MetaobjectCapabilitiesQueryBuilder AddFieldOnlineStore()
    {
        AddField("onlineStore");
        return this;
    }

    public MetaobjectCapabilitiesQueryBuilder AddFieldPublishable()
    {
        AddField("publishable");
        return this;
    }

    public MetaobjectCapabilitiesQueryBuilder AddFieldRenderable()
    {
        AddField("renderable");
        return this;
    }

    public MetaobjectCapabilitiesQueryBuilder AddFieldTranslatable()
    {
        AddField("translatable");
        return this;
    }
}