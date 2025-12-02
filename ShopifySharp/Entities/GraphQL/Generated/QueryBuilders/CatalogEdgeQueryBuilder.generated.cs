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

public class CatalogEdgeQueryBuilder() : GraphQueryBuilder<CatalogEdge>("catalogEdge")
{
    public CatalogEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public CatalogEdgeQueryBuilder AddFieldNode(Func<CatalogQueryBuilder, CatalogQueryBuilder> build)
    {
        AddField<ICatalog, CatalogQueryBuilder>("node", build);
        return this;
    }
}