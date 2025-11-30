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

public class AppInstallationConnectionQueryBuilder() : GraphQueryBuilder<AppInstallationConnection>("appInstallationConnection")
{
    public AppInstallationConnectionQueryBuilder AddFieldEdges(Func<AppInstallationEdgeQueryBuilder, AppInstallationEdgeQueryBuilder> build)
    {
        AddField<AppInstallationEdge, AppInstallationEdgeQueryBuilder>("edges", build);
        return this;
    }

    public AppInstallationConnectionQueryBuilder AddFieldNodes(Func<AppInstallationQueryBuilder, AppInstallationQueryBuilder> build)
    {
        AddField<AppInstallation, AppInstallationQueryBuilder>("nodes", build);
        return this;
    }

    public AppInstallationConnectionQueryBuilder AddFieldPageInfo(Func<PageInfoQueryBuilder, PageInfoQueryBuilder> build)
    {
        AddField<PageInfo, PageInfoQueryBuilder>("pageInfo", build);
        return this;
    }
}