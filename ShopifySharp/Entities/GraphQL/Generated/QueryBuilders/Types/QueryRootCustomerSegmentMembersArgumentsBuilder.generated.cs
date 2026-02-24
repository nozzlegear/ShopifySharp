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
    public sealed class QueryRootCustomerSegmentMembersArgumentsBuilder : ArgumentsBuilderBase<CustomerSegmentMemberConnection?, QueryRootCustomerSegmentMembersArgumentsBuilder>
    {
        protected override QueryRootCustomerSegmentMembersArgumentsBuilder Self => this;

        public QueryRootCustomerSegmentMembersArgumentsBuilder(IQuery<CustomerSegmentMemberConnection?> query) : base(query)
        {
        }

        public QueryRootCustomerSegmentMembersArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public QueryRootCustomerSegmentMembersArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public QueryRootCustomerSegmentMembersArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public QueryRootCustomerSegmentMembersArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public QueryRootCustomerSegmentMembersArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public QueryRootCustomerSegmentMembersArgumentsBuilder QueryId(string? queryId)
        {
            base.InnerQuery.AddArgument("queryId", queryId);
            return this;
        }

        public QueryRootCustomerSegmentMembersArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public QueryRootCustomerSegmentMembersArgumentsBuilder SegmentId(string? segmentId)
        {
            base.InnerQuery.AddArgument("segmentId", segmentId);
            return this;
        }

        public QueryRootCustomerSegmentMembersArgumentsBuilder SortKey(string? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }

        public QueryRootCustomerSegmentMembersArgumentsBuilder Timezone(string? timezone)
        {
            base.InnerQuery.AddArgument("timezone", timezone);
            return this;
        }
    }
}