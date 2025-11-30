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

public class PublicationConnectionQueryBuilder() : GraphQueryBuilder<PublicationConnection>("publicationConnection")
{
    public PublicationConnectionQueryBuilder AddFieldEdges(Func<PublicationEdgeQueryBuilder, PublicationEdgeQueryBuilder> build)
    {
        AddField<PublicationEdge, PublicationEdgeQueryBuilder>("edges", build);
        return this;
    }

    public PublicationConnectionQueryBuilder AddFieldNodes(Func<PublicationQueryBuilder, PublicationQueryBuilder> build)
    {
        AddField<Publication, PublicationQueryBuilder>("nodes", build);
        return this;
    }

    public PublicationConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}