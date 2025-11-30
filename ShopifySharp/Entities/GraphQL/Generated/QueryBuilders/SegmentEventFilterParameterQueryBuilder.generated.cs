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

public class SegmentEventFilterParameterQueryBuilder() : GraphQueryBuilder<SegmentEventFilterParameter>("segmentEventFilterParameter")
{
    public SegmentEventFilterParameterQueryBuilder AddFieldAcceptsMultipleValues()
    {
        AddField("acceptsMultipleValues");
        return this;
    }

    public SegmentEventFilterParameterQueryBuilder AddFieldLocalizedDescription()
    {
        AddField("localizedDescription");
        return this;
    }

    public SegmentEventFilterParameterQueryBuilder AddFieldLocalizedName()
    {
        AddField("localizedName");
        return this;
    }

    public SegmentEventFilterParameterQueryBuilder AddFieldMaxRange()
    {
        AddField("maxRange");
        return this;
    }

    public SegmentEventFilterParameterQueryBuilder AddFieldMinRange()
    {
        AddField("minRange");
        return this;
    }

    public SegmentEventFilterParameterQueryBuilder AddFieldOptional()
    {
        AddField("optional");
        return this;
    }

    public SegmentEventFilterParameterQueryBuilder AddFieldParameterType()
    {
        AddField("parameterType");
        return this;
    }

    public SegmentEventFilterParameterQueryBuilder AddFieldQueryName()
    {
        AddField("queryName");
        return this;
    }
}