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

public class ScriptTagEdgeQueryBuilder() : GraphQueryBuilder<ScriptTagEdge>("scriptTagEdge")
{
    public ScriptTagEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ScriptTagEdgeQueryBuilder AddFieldNode(Func<ScriptTagQueryBuilder, ScriptTagQueryBuilder> build)
    {
        AddField<ScriptTag, ScriptTagQueryBuilder>("node", build);
        return this;
    }
}