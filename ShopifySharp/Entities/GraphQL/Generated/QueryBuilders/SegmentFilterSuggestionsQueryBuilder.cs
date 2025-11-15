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

public class SegmentFilterSuggestionsQueryBuilder() : GraphQueryBuilder<SegmentFilterConnection>("query segmentFilterSuggestions")
{
    public SegmentFilterSuggestionsQueryBuilder AddArgumentAfter(string? after)
    {
        AddArgument("after", after);
        return this;
    }

    public SegmentFilterSuggestionsQueryBuilder AddArgumentFirst(int? first)
    {
        AddArgument("first", first);
        return this;
    }

    public SegmentFilterSuggestionsQueryBuilder AddArgumentSearch(string? search)
    {
        AddArgument("search", search);
        return this;
    }
}