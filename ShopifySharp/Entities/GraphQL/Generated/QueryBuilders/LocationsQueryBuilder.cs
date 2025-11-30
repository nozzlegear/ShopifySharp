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

public class LocationsQueryBuilder() : GraphQueryBuilder<LocationConnection>("query locations")
{
    public LocationsQueryBuilder AddArgumentAfter(string? after)
    {
        AddArgument("after", after);
        return this;
    }

    public LocationsQueryBuilder AddArgumentBefore(string? before)
    {
        AddArgument("before", before);
        return this;
    }

    public LocationsQueryBuilder AddArgumentFirst(int? first)
    {
        AddArgument("first", first);
        return this;
    }

    public LocationsQueryBuilder AddArgumentIncludeInactive(bool? includeInactive)
    {
        AddArgument("includeInactive", includeInactive);
        return this;
    }

    public LocationsQueryBuilder AddArgumentIncludeLegacy(bool? includeLegacy)
    {
        AddArgument("includeLegacy", includeLegacy);
        return this;
    }

    public LocationsQueryBuilder AddArgumentLast(int? last)
    {
        AddArgument("last", last);
        return this;
    }

    public LocationsQueryBuilder AddArgumentQuery(string? query)
    {
        AddArgument("query", query);
        return this;
    }

    public LocationsQueryBuilder AddArgumentReverse(bool? reverse)
    {
        AddArgument("reverse", reverse);
        return this;
    }

    public LocationsQueryBuilder AddArgumentSortKey(LocationSortKeys? sortKey)
    {
        AddArgument("sortKey", sortKey);
        return this;
    }
}