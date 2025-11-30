#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class MetaobjectCapabilitiesOnlineStoreQueryBuilder() : GraphQueryBuilder<MetaobjectCapabilitiesOnlineStore>("metaobjectCapabilitiesOnlineStore")
{
    public MetaobjectCapabilitiesOnlineStoreQueryBuilder AddFieldData(Func<MetaobjectCapabilityDefinitionDataOnlineStoreQueryBuilder, MetaobjectCapabilityDefinitionDataOnlineStoreQueryBuilder> build)
    {
        AddField<MetaobjectCapabilityDefinitionDataOnlineStore, MetaobjectCapabilityDefinitionDataOnlineStoreQueryBuilder>("data", build);
        return this;
    }

    public MetaobjectCapabilitiesOnlineStoreQueryBuilder AddFieldEnabled()
    {
        AddField("enabled");
        return this;
    }
}