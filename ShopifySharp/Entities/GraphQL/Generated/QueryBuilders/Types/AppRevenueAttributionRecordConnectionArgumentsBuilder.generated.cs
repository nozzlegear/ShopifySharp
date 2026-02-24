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
    public sealed class AppRevenueAttributionRecordConnectionArgumentsBuilder : ArgumentsBuilderBase<AppRevenueAttributionRecordConnection, AppRevenueAttributionRecordConnectionArgumentsBuilder>
    {
        protected override AppRevenueAttributionRecordConnectionArgumentsBuilder Self => this;

        public AppRevenueAttributionRecordConnectionArgumentsBuilder(IQuery<AppRevenueAttributionRecordConnection> query) : base(query)
        {
        }

        public AppRevenueAttributionRecordConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public AppRevenueAttributionRecordConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public AppRevenueAttributionRecordConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public AppRevenueAttributionRecordConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public AppRevenueAttributionRecordConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public AppRevenueAttributionRecordConnectionArgumentsBuilder SortKey(AppRevenueAttributionRecordSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}