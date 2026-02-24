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
    public sealed class SegmentStatisticsAttributeStatisticsQueryBuilder : FieldsQueryBuilderBase<SegmentAttributeStatistics, SegmentStatisticsAttributeStatisticsQueryBuilder>, IHasArguments<SegmentStatisticsAttributeStatisticsArgumentsBuilder>
    {
        public SegmentStatisticsAttributeStatisticsArgumentsBuilder Arguments { get; }
        protected override SegmentStatisticsAttributeStatisticsQueryBuilder Self => this;

        public SegmentStatisticsAttributeStatisticsQueryBuilder(string name) : base(new Query<SegmentAttributeStatistics>(name))
        {
            Arguments = new SegmentStatisticsAttributeStatisticsArgumentsBuilder(base.InnerQuery);
        }

        public SegmentStatisticsAttributeStatisticsQueryBuilder(IQuery<SegmentAttributeStatistics> query) : base(query)
        {
            Arguments = new SegmentStatisticsAttributeStatisticsArgumentsBuilder(base.InnerQuery);
        }

        public SegmentStatisticsAttributeStatisticsQueryBuilder SetArguments(Action<SegmentStatisticsAttributeStatisticsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public SegmentStatisticsAttributeStatisticsQueryBuilder Average()
        {
            base.InnerQuery.AddField("average");
            return this;
        }

        public SegmentStatisticsAttributeStatisticsQueryBuilder Sum()
        {
            base.InnerQuery.AddField("sum");
            return this;
        }
    }
}