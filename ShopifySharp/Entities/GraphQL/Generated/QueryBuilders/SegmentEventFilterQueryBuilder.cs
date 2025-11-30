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

public class SegmentEventFilterQueryBuilder() : GraphQueryBuilder<SegmentEventFilter>("query segmentEventFilter")
{
    public SegmentEventFilterQueryBuilder AddFieldLocalizedName()
    {
        AddField("localizedName");
        return this;
    }

    public SegmentEventFilterQueryBuilder AddFieldMultiValue()
    {
        AddField("multiValue");
        return this;
    }

    public SegmentEventFilterQueryBuilder AddFieldParameters()
    {
        AddField("parameters");
        return this;
    }

    public SegmentEventFilterQueryBuilder AddFieldQueryName()
    {
        AddField("queryName");
        return this;
    }

    public SegmentEventFilterQueryBuilder AddFieldReturnValueType()
    {
        AddField("returnValueType");
        return this;
    }
}