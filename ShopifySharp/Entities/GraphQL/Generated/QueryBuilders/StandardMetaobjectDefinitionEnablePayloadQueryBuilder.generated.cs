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

public class StandardMetaobjectDefinitionEnablePayloadQueryBuilder() : GraphQueryBuilder<StandardMetaobjectDefinitionEnablePayload>("standardMetaobjectDefinitionEnablePayload")
{
    public StandardMetaobjectDefinitionEnablePayloadQueryBuilder AddFieldMetaobjectDefinition(Func<MetaobjectDefinitionQueryBuilder, MetaobjectDefinitionQueryBuilder> build)
    {
        AddField<MetaobjectDefinition, MetaobjectDefinitionQueryBuilder>("metaobjectDefinition", build);
        return this;
    }

    public StandardMetaobjectDefinitionEnablePayloadQueryBuilder AddFieldUserErrors(Func<MetaobjectUserErrorQueryBuilder, MetaobjectUserErrorQueryBuilder> build)
    {
        AddField<MetaobjectUserError, MetaobjectUserErrorQueryBuilder>("userErrors", build);
        return this;
    }
}