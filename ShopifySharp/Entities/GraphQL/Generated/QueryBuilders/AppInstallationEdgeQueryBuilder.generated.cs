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

public class AppInstallationEdgeQueryBuilder() : GraphQueryBuilder<AppInstallationEdge>("appInstallationEdge")
{
    public AppInstallationEdgeQueryBuilder AddFieldCursor()
    {
        AddField("cursor");
        return this;
    }

    public AppInstallationEdgeQueryBuilder AddFieldNode(Func<AppInstallationQueryBuilder, AppInstallationQueryBuilder> build)
    {
        AddField<AppInstallation, AppInstallationQueryBuilder>("node", build);
        return this;
    }
}