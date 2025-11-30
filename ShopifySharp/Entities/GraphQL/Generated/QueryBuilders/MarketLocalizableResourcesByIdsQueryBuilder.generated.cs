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

public class MarketLocalizableResourcesByIdsQueryBuilder() : GraphQueryBuilder<MarketLocalizableResourceConnection>("marketLocalizableResourcesByIds"), IGraphOperationQueryBuilder
{
    public OperationType OperationType { get; } = OperationType.Query;

    public MarketLocalizableResourcesByIdsQueryBuilder AddArgumentAfter(string? after)
    {
        AddArgument("after", after);
        return this;
    }

    public MarketLocalizableResourcesByIdsQueryBuilder AddArgumentBefore(string? before)
    {
        AddArgument("before", before);
        return this;
    }

    public MarketLocalizableResourcesByIdsQueryBuilder AddArgumentFirst(int? first)
    {
        AddArgument("first", first);
        return this;
    }

    public MarketLocalizableResourcesByIdsQueryBuilder AddArgumentLast(int? last)
    {
        AddArgument("last", last);
        return this;
    }

    public MarketLocalizableResourcesByIdsQueryBuilder AddArgumentResourceIds(ICollection<string>? resourceIds)
    {
        AddArgument("resourceIds", resourceIds);
        return this;
    }

    public MarketLocalizableResourcesByIdsQueryBuilder AddArgumentReverse(bool? reverse)
    {
        AddArgument("reverse", reverse);
        return this;
    }
}