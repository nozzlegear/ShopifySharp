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
    public sealed class CustomerSegmentMemberConnectionArgumentsBuilder : ArgumentsBuilderBase<CustomerSegmentMemberConnection, CustomerSegmentMemberConnectionArgumentsBuilder>
    {
        protected override CustomerSegmentMemberConnectionArgumentsBuilder Self => this;

        public CustomerSegmentMemberConnectionArgumentsBuilder(IQuery<CustomerSegmentMemberConnection> query) : base(query)
        {
        }

        public CustomerSegmentMemberConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CustomerSegmentMemberConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CustomerSegmentMemberConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CustomerSegmentMemberConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CustomerSegmentMemberConnectionArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public CustomerSegmentMemberConnectionArgumentsBuilder QueryId(string? queryId)
        {
            base.InnerQuery.AddArgument("queryId", queryId);
            return this;
        }

        public CustomerSegmentMemberConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public CustomerSegmentMemberConnectionArgumentsBuilder SegmentId(string? segmentId)
        {
            base.InnerQuery.AddArgument("segmentId", segmentId);
            return this;
        }

        public CustomerSegmentMemberConnectionArgumentsBuilder SortKey(string? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }

        public CustomerSegmentMemberConnectionArgumentsBuilder Timezone(string? timezone)
        {
            base.InnerQuery.AddArgument("timezone", timezone);
            return this;
        }
    }
}