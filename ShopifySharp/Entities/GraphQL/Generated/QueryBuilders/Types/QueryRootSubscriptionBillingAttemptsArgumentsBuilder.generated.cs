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
    public sealed class QueryRootSubscriptionBillingAttemptsArgumentsBuilder : ArgumentsBuilderBase<SubscriptionBillingAttemptConnection?, QueryRootSubscriptionBillingAttemptsArgumentsBuilder>
    {
        protected override QueryRootSubscriptionBillingAttemptsArgumentsBuilder Self => this;

        public QueryRootSubscriptionBillingAttemptsArgumentsBuilder(IQuery<SubscriptionBillingAttemptConnection?> query) : base(query)
        {
        }

        public QueryRootSubscriptionBillingAttemptsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public QueryRootSubscriptionBillingAttemptsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public QueryRootSubscriptionBillingAttemptsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public QueryRootSubscriptionBillingAttemptsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public QueryRootSubscriptionBillingAttemptsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public QueryRootSubscriptionBillingAttemptsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public QueryRootSubscriptionBillingAttemptsArgumentsBuilder SortKey(SubscriptionBillingAttemptsSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}