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

public class CompanyLocationsQueryBuilder() : GraphQueryBuilder<CompanyLocationConnection>("companyLocations"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Query;

    public CompanyLocationsQueryBuilder AddArgumentAfter(string? after)
    {
        AddArgument("after", after);
        return this;
    }

    public CompanyLocationsQueryBuilder AddArgumentBefore(string? before)
    {
        AddArgument("before", before);
        return this;
    }

    public CompanyLocationsQueryBuilder AddArgumentFirst(int? first)
    {
        AddArgument("first", first);
        return this;
    }

    public CompanyLocationsQueryBuilder AddArgumentLast(int? last)
    {
        AddArgument("last", last);
        return this;
    }

    public CompanyLocationsQueryBuilder AddArgumentQuery(string? query)
    {
        AddArgument("query", query);
        return this;
    }

    public CompanyLocationsQueryBuilder AddArgumentReverse(bool? reverse)
    {
        AddArgument("reverse", reverse);
        return this;
    }

    public CompanyLocationsQueryBuilder AddArgumentSortKey(CompanyLocationSortKeys? sortKey)
    {
        AddArgument("sortKey", sortKey);
        return this;
    }
}