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

public class TaxonomyValueEdgeQueryBuilder() : GraphQueryBuilder<TaxonomyValueEdge>("taxonomyValueEdge")
{
    public TaxonomyValueEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public TaxonomyValueEdgeQueryBuilder AddFieldNode(Func<TaxonomyValueQueryBuilder, TaxonomyValueQueryBuilder> build)
    {
        AddField<TaxonomyValue, TaxonomyValueQueryBuilder>("node", build);
        return this;
    }
}