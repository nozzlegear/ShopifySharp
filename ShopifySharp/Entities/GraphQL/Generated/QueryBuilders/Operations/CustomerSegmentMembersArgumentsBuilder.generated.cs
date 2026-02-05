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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class CustomerSegmentMembersArgumentsBuilder : ArgumentsBuilderBase<CustomerSegmentMemberConnection, CustomerSegmentMembersArgumentsBuilder>
    {
        protected override CustomerSegmentMembersArgumentsBuilder Self => this;

        public CustomerSegmentMembersArgumentsBuilder(IQuery<CustomerSegmentMemberConnection> query) : base(query)
        {
        }

        public CustomerSegmentMembersArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CustomerSegmentMembersArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CustomerSegmentMembersArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CustomerSegmentMembersArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CustomerSegmentMembersArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public CustomerSegmentMembersArgumentsBuilder QueryId(string? queryId)
        {
            base.InnerQuery.AddArgument("queryId", queryId);
            return this;
        }

        public CustomerSegmentMembersArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public CustomerSegmentMembersArgumentsBuilder SegmentId(string? segmentId)
        {
            base.InnerQuery.AddArgument("segmentId", segmentId);
            return this;
        }

        public CustomerSegmentMembersArgumentsBuilder SortKey(string? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }

        public CustomerSegmentMembersArgumentsBuilder Timezone(string? timezone)
        {
            base.InnerQuery.AddArgument("timezone", timezone);
            return this;
        }
    }
}