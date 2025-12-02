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

public class SegmentAttributeStatisticsQueryBuilder() : GraphQueryBuilder<SegmentAttributeStatistics>("segmentAttributeStatistics")
{
    public SegmentAttributeStatisticsQueryBuilder AddFieldAverage()
    {
        AddField("average");
        return this;
    }

    public SegmentAttributeStatisticsQueryBuilder AddFieldSum()
    {
        AddField("sum");
        return this;
    }
}