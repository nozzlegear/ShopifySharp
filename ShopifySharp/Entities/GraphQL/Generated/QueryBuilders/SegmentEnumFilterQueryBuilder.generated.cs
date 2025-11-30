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

public class SegmentEnumFilterQueryBuilder() : GraphQueryBuilder<SegmentEnumFilter>("segmentEnumFilter")
{
    public SegmentEnumFilterQueryBuilder AddFieldLocalizedName()
    {
        AddField("localizedName");
        return this;
    }

    public SegmentEnumFilterQueryBuilder AddFieldMultiValue()
    {
        AddField("multiValue");
        return this;
    }

    public SegmentEnumFilterQueryBuilder AddFieldQueryName()
    {
        AddField("queryName");
        return this;
    }
}