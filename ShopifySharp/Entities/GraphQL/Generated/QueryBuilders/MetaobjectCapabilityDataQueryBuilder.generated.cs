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

public class MetaobjectCapabilityDataQueryBuilder() : GraphQueryBuilder<MetaobjectCapabilityData>("metaobjectCapabilityData")
{
    public MetaobjectCapabilityDataQueryBuilder AddFieldOnlineStore(Func<MetaobjectCapabilityDataOnlineStoreQueryBuilder, MetaobjectCapabilityDataOnlineStoreQueryBuilder> build)
    {
        AddField<MetaobjectCapabilityDataOnlineStore, MetaobjectCapabilityDataOnlineStoreQueryBuilder>("onlineStore", build);
        return this;
    }

    public MetaobjectCapabilityDataQueryBuilder AddFieldPublishable(Func<MetaobjectCapabilityDataPublishableQueryBuilder, MetaobjectCapabilityDataPublishableQueryBuilder> build)
    {
        AddField<MetaobjectCapabilityDataPublishable, MetaobjectCapabilityDataPublishableQueryBuilder>("publishable", build);
        return this;
    }
}