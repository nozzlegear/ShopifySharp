#nullable enable
namespace ShopifySharp.Services.Generated;
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;

public class AppInstallationsQueryBuilder() : GraphQueryBuilder<AppInstallationConnection>("query appInstallations")
{
    public AppInstallationsQueryBuilder AddArgumentAfter(string? after)
    {
        AddArgument("after", after);
        return this;
    }

    public AppInstallationsQueryBuilder AddArgumentBefore(string? before)
    {
        AddArgument("before", before);
        return this;
    }

    public AppInstallationsQueryBuilder AddArgumentCategory(AppInstallationCategory? category)
    {
        AddArgument("category", category);
        return this;
    }

    public AppInstallationsQueryBuilder AddArgumentFirst(int? first)
    {
        AddArgument("first", first);
        return this;
    }

    public AppInstallationsQueryBuilder AddArgumentLast(int? last)
    {
        AddArgument("last", last);
        return this;
    }

    public AppInstallationsQueryBuilder AddArgumentPrivacy(AppInstallationPrivacy? privacy)
    {
        AddArgument("privacy", privacy);
        return this;
    }

    public AppInstallationsQueryBuilder AddArgumentReverse(bool? reverse)
    {
        AddArgument("reverse", reverse);
        return this;
    }

    public AppInstallationsQueryBuilder AddArgumentSortKey(AppInstallationSortKeys? sortKey)
    {
        AddArgument("sortKey", sortKey);
        return this;
    }
}