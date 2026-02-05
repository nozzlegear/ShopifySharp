#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class SegmentAttributeStatisticsQueryBuilder : FieldsQueryBuilderBase<SegmentAttributeStatistics, SegmentAttributeStatisticsQueryBuilder>
    {
        protected override SegmentAttributeStatisticsQueryBuilder Self => this;

        public SegmentAttributeStatisticsQueryBuilder() : this("segmentAttributeStatistics")
        {
        }

        public SegmentAttributeStatisticsQueryBuilder(string name) : base(new Query<SegmentAttributeStatistics>(name))
        {
        }

        public SegmentAttributeStatisticsQueryBuilder(IQuery<SegmentAttributeStatistics> query) : base(query)
        {
        }

        public SegmentAttributeStatisticsQueryBuilder Average()
        {
            base.InnerQuery.AddField("average");
            return this;
        }

        public SegmentAttributeStatisticsQueryBuilder Sum()
        {
            base.InnerQuery.AddField("sum");
            return this;
        }
    }
}