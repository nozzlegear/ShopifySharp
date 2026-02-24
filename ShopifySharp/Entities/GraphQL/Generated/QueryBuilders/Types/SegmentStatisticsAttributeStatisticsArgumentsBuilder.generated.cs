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
    public sealed class SegmentStatisticsAttributeStatisticsArgumentsBuilder : ArgumentsBuilderBase<SegmentAttributeStatistics?, SegmentStatisticsAttributeStatisticsArgumentsBuilder>
    {
        protected override SegmentStatisticsAttributeStatisticsArgumentsBuilder Self => this;

        public SegmentStatisticsAttributeStatisticsArgumentsBuilder(IQuery<SegmentAttributeStatistics?> query) : base(query)
        {
        }

        public SegmentStatisticsAttributeStatisticsArgumentsBuilder AttributeName(string? attributeName)
        {
            base.InnerQuery.AddArgument("attributeName", attributeName);
            return this;
        }
    }
}