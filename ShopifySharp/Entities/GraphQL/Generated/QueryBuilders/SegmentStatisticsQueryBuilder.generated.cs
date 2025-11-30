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

public class SegmentStatisticsQueryBuilder() : GraphQueryBuilder<SegmentStatistics>("segmentStatistics")
{
    public SegmentStatisticsQueryBuilder AddFieldAttributeStatistics(Func<SegmentAttributeStatisticsQueryBuilder, SegmentAttributeStatisticsQueryBuilder> build)
    {
        AddField<SegmentAttributeStatistics, SegmentAttributeStatisticsQueryBuilder>("attributeStatistics", build);
        return this;
    }
}