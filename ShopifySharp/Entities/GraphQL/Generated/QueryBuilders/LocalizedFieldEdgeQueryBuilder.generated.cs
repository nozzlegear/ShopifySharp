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

public class LocalizedFieldEdgeQueryBuilder() : GraphQueryBuilder<LocalizedFieldEdge>("localizedFieldEdge")
{
    public LocalizedFieldEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public LocalizedFieldEdgeQueryBuilder AddFieldNode(Func<LocalizedFieldQueryBuilder, LocalizedFieldQueryBuilder> build)
    {
        AddField<LocalizedField, LocalizedFieldQueryBuilder>("node", build);
        return this;
    }
}