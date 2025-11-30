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

public class SegmentValueSuggestionsQueryBuilder() : GraphQueryBuilder<SegmentValueConnection>("query segmentValueSuggestions")
{
    public SegmentValueSuggestionsQueryBuilder AddArgumentAfter(string? after)
    {
        AddArgument("after", after);
        return this;
    }

    public SegmentValueSuggestionsQueryBuilder AddArgumentBefore(string? before)
    {
        AddArgument("before", before);
        return this;
    }

    public SegmentValueSuggestionsQueryBuilder AddArgumentFilterQueryName(string? filterQueryName)
    {
        AddArgument("filterQueryName", filterQueryName);
        return this;
    }

    public SegmentValueSuggestionsQueryBuilder AddArgumentFirst(int? first)
    {
        AddArgument("first", first);
        return this;
    }

    public SegmentValueSuggestionsQueryBuilder AddArgumentFunctionParameterQueryName(string? functionParameterQueryName)
    {
        AddArgument("functionParameterQueryName", functionParameterQueryName);
        return this;
    }

    public SegmentValueSuggestionsQueryBuilder AddArgumentLast(int? last)
    {
        AddArgument("last", last);
        return this;
    }

    public SegmentValueSuggestionsQueryBuilder AddArgumentSearch(string? search)
    {
        AddArgument("search", search);
        return this;
    }
}