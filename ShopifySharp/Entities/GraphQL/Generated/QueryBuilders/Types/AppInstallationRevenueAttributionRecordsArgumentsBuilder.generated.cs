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
    public sealed class AppInstallationRevenueAttributionRecordsArgumentsBuilder : ArgumentsBuilderBase<AppRevenueAttributionRecordConnection?, AppInstallationRevenueAttributionRecordsArgumentsBuilder>
    {
        protected override AppInstallationRevenueAttributionRecordsArgumentsBuilder Self => this;

        public AppInstallationRevenueAttributionRecordsArgumentsBuilder(IQuery<AppRevenueAttributionRecordConnection?> query) : base(query)
        {
        }

        public AppInstallationRevenueAttributionRecordsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public AppInstallationRevenueAttributionRecordsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public AppInstallationRevenueAttributionRecordsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public AppInstallationRevenueAttributionRecordsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public AppInstallationRevenueAttributionRecordsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public AppInstallationRevenueAttributionRecordsArgumentsBuilder SortKey(AppRevenueAttributionRecordSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}