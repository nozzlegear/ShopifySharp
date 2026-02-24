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
    public sealed class AppSubscriptionLineItemUsageRecordsArgumentsBuilder : ArgumentsBuilderBase<AppUsageRecordConnection?, AppSubscriptionLineItemUsageRecordsArgumentsBuilder>
    {
        protected override AppSubscriptionLineItemUsageRecordsArgumentsBuilder Self => this;

        public AppSubscriptionLineItemUsageRecordsArgumentsBuilder(IQuery<AppUsageRecordConnection?> query) : base(query)
        {
        }

        public AppSubscriptionLineItemUsageRecordsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public AppSubscriptionLineItemUsageRecordsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public AppSubscriptionLineItemUsageRecordsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public AppSubscriptionLineItemUsageRecordsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public AppSubscriptionLineItemUsageRecordsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public AppSubscriptionLineItemUsageRecordsArgumentsBuilder SortKey(AppUsageRecordSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}