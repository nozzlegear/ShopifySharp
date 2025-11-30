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

public class MarketingActivitiesQueryBuilder() : GraphQueryBuilder<MarketingActivityConnection>("query marketingActivities")
{
    public MarketingActivitiesQueryBuilder AddArgumentAfter(string? after)
    {
        AddArgument("after", after);
        return this;
    }

    public MarketingActivitiesQueryBuilder AddArgumentBefore(string? before)
    {
        AddArgument("before", before);
        return this;
    }

    public MarketingActivitiesQueryBuilder AddArgumentFirst(int? first)
    {
        AddArgument("first", first);
        return this;
    }

    public MarketingActivitiesQueryBuilder AddArgumentLast(int? last)
    {
        AddArgument("last", last);
        return this;
    }

    public MarketingActivitiesQueryBuilder AddArgumentMarketingActivityIds(ICollection<string>? marketingActivityIds)
    {
        AddArgument("marketingActivityIds", marketingActivityIds);
        return this;
    }

    public MarketingActivitiesQueryBuilder AddArgumentQuery(string? query)
    {
        AddArgument("query", query);
        return this;
    }

    public MarketingActivitiesQueryBuilder AddArgumentRemoteIds(ICollection<string>? remoteIds)
    {
        AddArgument("remoteIds", remoteIds);
        return this;
    }

    public MarketingActivitiesQueryBuilder AddArgumentReverse(bool? reverse)
    {
        AddArgument("reverse", reverse);
        return this;
    }

    public MarketingActivitiesQueryBuilder AddArgumentSavedSearchId(string? savedSearchId)
    {
        AddArgument("savedSearchId", savedSearchId);
        return this;
    }

    public MarketingActivitiesQueryBuilder AddArgumentSortKey(MarketingActivitySortKeys? sortKey)
    {
        AddArgument("sortKey", sortKey);
        return this;
    }

    public MarketingActivitiesQueryBuilder AddArgumentUtm(UTMInput? utm)
    {
        AddArgument("utm", utm);
        return this;
    }
}