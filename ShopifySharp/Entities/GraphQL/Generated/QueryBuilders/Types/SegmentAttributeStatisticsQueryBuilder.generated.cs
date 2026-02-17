#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.GraphQL.QueryBuilders;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.QueryBuilders.Operations;
using ShopifySharp.GraphQL.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.QueryBuilders.Types
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