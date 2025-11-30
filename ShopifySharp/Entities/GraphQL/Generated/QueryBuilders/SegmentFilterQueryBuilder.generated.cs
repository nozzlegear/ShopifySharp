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

public class SegmentFilterQueryBuilder() : GraphQueryBuilder<ISegmentFilter>("segmentFilter")
{
    public SegmentFilterQueryBuilder AddFieldLocalizedName()
    {
        AddField("localizedName");
        return this;
    }

    public SegmentFilterQueryBuilder AddFieldMultiValue()
    {
        AddField("multiValue");
        return this;
    }

    public SegmentFilterQueryBuilder AddFieldQueryName()
    {
        AddField("queryName");
        return this;
    }
}