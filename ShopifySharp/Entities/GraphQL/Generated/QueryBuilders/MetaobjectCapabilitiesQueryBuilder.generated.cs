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

public class MetaobjectCapabilitiesQueryBuilder() : GraphQueryBuilder<MetaobjectCapabilities>("metaobjectCapabilities")
{
    public MetaobjectCapabilitiesQueryBuilder AddFieldOnlineStore(Func<MetaobjectCapabilitiesOnlineStoreQueryBuilder, MetaobjectCapabilitiesOnlineStoreQueryBuilder> build)
    {
        AddField<MetaobjectCapabilitiesOnlineStore, MetaobjectCapabilitiesOnlineStoreQueryBuilder>("onlineStore", build);
        return this;
    }

    public MetaobjectCapabilitiesQueryBuilder AddFieldPublishable(Func<MetaobjectCapabilitiesPublishableQueryBuilder, MetaobjectCapabilitiesPublishableQueryBuilder> build)
    {
        AddField<MetaobjectCapabilitiesPublishable, MetaobjectCapabilitiesPublishableQueryBuilder>("publishable", build);
        return this;
    }

    public MetaobjectCapabilitiesQueryBuilder AddFieldRenderable(Func<MetaobjectCapabilitiesRenderableQueryBuilder, MetaobjectCapabilitiesRenderableQueryBuilder> build)
    {
        AddField<MetaobjectCapabilitiesRenderable, MetaobjectCapabilitiesRenderableQueryBuilder>("renderable", build);
        return this;
    }

    public MetaobjectCapabilitiesQueryBuilder AddFieldTranslatable(Func<MetaobjectCapabilitiesTranslatableQueryBuilder, MetaobjectCapabilitiesTranslatableQueryBuilder> build)
    {
        AddField<MetaobjectCapabilitiesTranslatable, MetaobjectCapabilitiesTranslatableQueryBuilder>("translatable", build);
        return this;
    }
}