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

public class StandardMetafieldDefinitionTemplateConnectionQueryBuilder() : GraphQueryBuilder<StandardMetafieldDefinitionTemplateConnection>("standardMetafieldDefinitionTemplateConnection")
{
    public StandardMetafieldDefinitionTemplateConnectionQueryBuilder AddFieldEdges(Func<StandardMetafieldDefinitionTemplateEdgeQueryBuilder, StandardMetafieldDefinitionTemplateEdgeQueryBuilder> build)
    {
        AddField<StandardMetafieldDefinitionTemplateEdge, StandardMetafieldDefinitionTemplateEdgeQueryBuilder>("edges", build);
        return this;
    }

    public StandardMetafieldDefinitionTemplateConnectionQueryBuilder AddFieldNodes(Func<StandardMetafieldDefinitionTemplateQueryBuilder, StandardMetafieldDefinitionTemplateQueryBuilder> build)
    {
        AddField<StandardMetafieldDefinitionTemplate, StandardMetafieldDefinitionTemplateQueryBuilder>("nodes", build);
        return this;
    }

    public StandardMetafieldDefinitionTemplateConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}