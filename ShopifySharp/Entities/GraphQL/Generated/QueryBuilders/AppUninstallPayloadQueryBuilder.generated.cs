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

public class AppUninstallPayloadQueryBuilder() : GraphQueryBuilder<AppUninstallPayload>("appUninstallPayload")
{
    public AppUninstallPayloadQueryBuilder AddFieldApp(Func<AppQueryBuilder, AppQueryBuilder> build)
    {
        AddField<App, AppQueryBuilder>("app", build);
        return this;
    }

    public AppUninstallPayloadQueryBuilder AddFieldUserErrors(Func<AppUninstallAppUninstallErrorQueryBuilder, AppUninstallAppUninstallErrorQueryBuilder> build)
    {
        AddField<AppUninstallAppUninstallError, AppUninstallAppUninstallErrorQueryBuilder>("userErrors", build);
        return this;
    }
}