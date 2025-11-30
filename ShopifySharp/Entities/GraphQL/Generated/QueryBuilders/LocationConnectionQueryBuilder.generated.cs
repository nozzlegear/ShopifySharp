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

public class LocationConnectionQueryBuilder() : GraphQueryBuilder<LocationConnection>("locationConnection")
{
    public LocationConnectionQueryBuilder AddFieldEdges(Func<LocationEdgeQueryBuilder, LocationEdgeQueryBuilder> build)
    {
        AddField<LocationEdge, LocationEdgeQueryBuilder>("edges", build);
        return this;
    }

    public LocationConnectionQueryBuilder AddFieldNodes(Func<LocationQueryBuilder, LocationQueryBuilder> build)
    {
        AddField<Location, LocationQueryBuilder>("nodes", build);
        return this;
    }

    public LocationConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}