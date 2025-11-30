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

public class ScriptTagConnectionQueryBuilder() : GraphQueryBuilder<ScriptTagConnection>("scriptTagConnection")
{
    public ScriptTagConnectionQueryBuilder AddFieldEdges(Func<ScriptTagEdgeQueryBuilder, ScriptTagEdgeQueryBuilder> build)
    {
        AddField<ScriptTagEdge, ScriptTagEdgeQueryBuilder>("edges", build);
        return this;
    }

    public ScriptTagConnectionQueryBuilder AddFieldNodes(Func<ScriptTagQueryBuilder, ScriptTagQueryBuilder> build)
    {
        AddField<ScriptTag, ScriptTagQueryBuilder>("nodes", build);
        return this;
    }

    public ScriptTagConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}