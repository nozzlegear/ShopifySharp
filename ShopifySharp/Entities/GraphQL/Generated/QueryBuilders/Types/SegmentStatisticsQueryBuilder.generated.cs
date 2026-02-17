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
    public sealed class SegmentStatisticsQueryBuilder : FieldsQueryBuilderBase<SegmentStatistics, SegmentStatisticsQueryBuilder>
    {
        protected override SegmentStatisticsQueryBuilder Self => this;

        public SegmentStatisticsQueryBuilder() : this("segmentStatistics")
        {
        }

        public SegmentStatisticsQueryBuilder(string name) : base(new Query<SegmentStatistics>(name))
        {
        }

        public SegmentStatisticsQueryBuilder(IQuery<SegmentStatistics> query) : base(query)
        {
        }

        public SegmentStatisticsQueryBuilder AttributeStatistics(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SegmentAttributeStatisticsQueryBuilder> build)
        {
            var query = new Query<SegmentAttributeStatistics>("attributeStatistics");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SegmentAttributeStatisticsQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SegmentAttributeStatistics>(query);
            return this;
        }
    }
}