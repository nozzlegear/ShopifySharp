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
    public sealed class SegmentAttributeStatisticsArgumentsBuilder : ArgumentsBuilderBase<SegmentAttributeStatistics, SegmentAttributeStatisticsArgumentsBuilder>
    {
        protected override SegmentAttributeStatisticsArgumentsBuilder Self => this;

        public SegmentAttributeStatisticsArgumentsBuilder(IQuery<SegmentAttributeStatistics> query) : base(query)
        {
        }

        public SegmentAttributeStatisticsArgumentsBuilder AttributeName(string? attributeName)
        {
            base.InnerQuery.AddArgument("attributeName", attributeName);
            return this;
        }
    }
}