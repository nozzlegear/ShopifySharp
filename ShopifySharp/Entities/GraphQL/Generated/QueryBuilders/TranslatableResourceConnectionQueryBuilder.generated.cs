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

public class TranslatableResourceConnectionQueryBuilder() : GraphQueryBuilder<TranslatableResourceConnection>("translatableResourceConnection")
{
    public TranslatableResourceConnectionQueryBuilder AddFieldEdges(Func<TranslatableResourceEdgeQueryBuilder, TranslatableResourceEdgeQueryBuilder> build)
    {
        AddField<TranslatableResourceEdge, TranslatableResourceEdgeQueryBuilder>("edges", build);
        return this;
    }

    public TranslatableResourceConnectionQueryBuilder AddFieldNodes(Func<TranslatableResourceQueryBuilder, TranslatableResourceQueryBuilder> build)
    {
        AddField<TranslatableResource, TranslatableResourceQueryBuilder>("nodes", build);
        return this;
    }

    public TranslatableResourceConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}