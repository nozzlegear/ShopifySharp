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

public class SegmentIntegerFilterQueryBuilder() : GraphQueryBuilder<SegmentIntegerFilter>("query segmentIntegerFilter")
{
    public SegmentIntegerFilterQueryBuilder AddFieldLocalizedName()
    {
        AddField("localizedName");
        return this;
    }

    public SegmentIntegerFilterQueryBuilder AddFieldMaxRange()
    {
        AddField("maxRange");
        return this;
    }

    public SegmentIntegerFilterQueryBuilder AddFieldMinRange()
    {
        AddField("minRange");
        return this;
    }

    public SegmentIntegerFilterQueryBuilder AddFieldMultiValue()
    {
        AddField("multiValue");
        return this;
    }

    public SegmentIntegerFilterQueryBuilder AddFieldQueryName()
    {
        AddField("queryName");
        return this;
    }
}