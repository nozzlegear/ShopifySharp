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

public class SegmentFloatFilterQueryBuilder() : GraphQueryBuilder<SegmentFloatFilter>("query segmentFloatFilter")
{
    public SegmentFloatFilterQueryBuilder AddFieldLocalizedName()
    {
        AddField("localizedName");
        return this;
    }

    public SegmentFloatFilterQueryBuilder AddFieldMaxRange()
    {
        AddField("maxRange");
        return this;
    }

    public SegmentFloatFilterQueryBuilder AddFieldMinRange()
    {
        AddField("minRange");
        return this;
    }

    public SegmentFloatFilterQueryBuilder AddFieldMultiValue()
    {
        AddField("multiValue");
        return this;
    }

    public SegmentFloatFilterQueryBuilder AddFieldQueryName()
    {
        AddField("queryName");
        return this;
    }
}