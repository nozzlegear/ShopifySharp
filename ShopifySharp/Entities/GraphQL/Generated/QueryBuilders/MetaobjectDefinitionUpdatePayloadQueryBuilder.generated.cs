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

public class MetaobjectDefinitionUpdatePayloadQueryBuilder() : GraphQueryBuilder<MetaobjectDefinitionUpdatePayload>("metaobjectDefinitionUpdatePayload")
{
    public MetaobjectDefinitionUpdatePayloadQueryBuilder AddFieldMetaobjectDefinition(Func<MetaobjectDefinitionQueryBuilder, MetaobjectDefinitionQueryBuilder> build)
    {
        AddField<MetaobjectDefinition, MetaobjectDefinitionQueryBuilder>("metaobjectDefinition", build);
        return this;
    }

    public MetaobjectDefinitionUpdatePayloadQueryBuilder AddFieldUserErrors(Func<MetaobjectUserErrorQueryBuilder, MetaobjectUserErrorQueryBuilder> build)
    {
        AddField<MetaobjectUserError, MetaobjectUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}