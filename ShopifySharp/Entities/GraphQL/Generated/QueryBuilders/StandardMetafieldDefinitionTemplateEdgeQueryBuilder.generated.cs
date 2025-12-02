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

public class StandardMetafieldDefinitionTemplateEdgeQueryBuilder() : GraphQueryBuilder<StandardMetafieldDefinitionTemplateEdge>("standardMetafieldDefinitionTemplateEdge")
{
    public StandardMetafieldDefinitionTemplateEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public StandardMetafieldDefinitionTemplateEdgeQueryBuilder AddFieldNode(Func<StandardMetafieldDefinitionTemplateQueryBuilder, StandardMetafieldDefinitionTemplateQueryBuilder> build)
    {
        AddField<StandardMetafieldDefinitionTemplate, StandardMetafieldDefinitionTemplateQueryBuilder>("node", build);
        return this;
    }
}