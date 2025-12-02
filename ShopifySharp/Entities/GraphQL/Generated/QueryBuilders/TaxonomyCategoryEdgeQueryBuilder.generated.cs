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

public class TaxonomyCategoryEdgeQueryBuilder() : GraphQueryBuilder<TaxonomyCategoryEdge>("taxonomyCategoryEdge")
{
    public TaxonomyCategoryEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public TaxonomyCategoryEdgeQueryBuilder AddFieldNode(Func<TaxonomyCategoryQueryBuilder, TaxonomyCategoryQueryBuilder> build)
    {
        AddField<TaxonomyCategory, TaxonomyCategoryQueryBuilder>("node", build);
        return this;
    }
}