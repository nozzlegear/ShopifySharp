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

public class MetaobjectCapabilityDefinitionDataRenderableQueryBuilder() : GraphQueryBuilder<MetaobjectCapabilityDefinitionDataRenderable>("query metaobjectCapabilityDefinitionDataRenderable")
{
    public MetaobjectCapabilityDefinitionDataRenderableQueryBuilder AddFieldMetaDescriptionKey()
    {
        AddField("metaDescriptionKey");
        return this;
    }

    public MetaobjectCapabilityDefinitionDataRenderableQueryBuilder AddFieldMetaTitleKey()
    {
        AddField("metaTitleKey");
        return this;
    }
}