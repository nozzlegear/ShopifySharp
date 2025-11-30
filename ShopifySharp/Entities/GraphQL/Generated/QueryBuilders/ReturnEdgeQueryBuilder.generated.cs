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

public class ReturnEdgeQueryBuilder() : GraphQueryBuilder<ReturnEdge>("returnEdge")
{
    public ReturnEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public ReturnEdgeQueryBuilder AddFieldNode(Func<ReturnQueryBuilder, ReturnQueryBuilder> build)
    {
        AddField<Return, ReturnQueryBuilder>("node", build);
        return this;
    }
}