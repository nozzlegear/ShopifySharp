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

public class MetaobjectCapabilitiesRenderableQueryBuilder() : GraphQueryBuilder<MetaobjectCapabilitiesRenderable>("metaobjectCapabilitiesRenderable")
{
    public MetaobjectCapabilitiesRenderableQueryBuilder AddFieldData(Func<MetaobjectCapabilityDefinitionDataRenderableQueryBuilder, MetaobjectCapabilityDefinitionDataRenderableQueryBuilder> build)
    {
        AddField<MetaobjectCapabilityDefinitionDataRenderable, MetaobjectCapabilityDefinitionDataRenderableQueryBuilder>("data", build);
        return this;
    }

    public MetaobjectCapabilitiesRenderableQueryBuilder AddFieldEnabled()
    {
        AddField("enabled");
        return this;
    }
}