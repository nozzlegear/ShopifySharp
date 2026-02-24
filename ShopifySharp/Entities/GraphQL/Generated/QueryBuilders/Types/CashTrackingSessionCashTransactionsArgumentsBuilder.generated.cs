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
    public sealed class CashTrackingSessionCashTransactionsArgumentsBuilder : ArgumentsBuilderBase<OrderTransactionConnection?, CashTrackingSessionCashTransactionsArgumentsBuilder>
    {
        protected override CashTrackingSessionCashTransactionsArgumentsBuilder Self => this;

        public CashTrackingSessionCashTransactionsArgumentsBuilder(IQuery<OrderTransactionConnection?> query) : base(query)
        {
        }

        public CashTrackingSessionCashTransactionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CashTrackingSessionCashTransactionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CashTrackingSessionCashTransactionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CashTrackingSessionCashTransactionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CashTrackingSessionCashTransactionsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public CashTrackingSessionCashTransactionsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public CashTrackingSessionCashTransactionsArgumentsBuilder SortKey(CashTrackingSessionTransactionsSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}