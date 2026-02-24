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
    public sealed class ShopifyPaymentsAccountBalanceTransactionsArgumentsBuilder : ArgumentsBuilderBase<ShopifyPaymentsBalanceTransactionConnection?, ShopifyPaymentsAccountBalanceTransactionsArgumentsBuilder>
    {
        protected override ShopifyPaymentsAccountBalanceTransactionsArgumentsBuilder Self => this;

        public ShopifyPaymentsAccountBalanceTransactionsArgumentsBuilder(IQuery<ShopifyPaymentsBalanceTransactionConnection?> query) : base(query)
        {
        }

        public ShopifyPaymentsAccountBalanceTransactionsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ShopifyPaymentsAccountBalanceTransactionsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ShopifyPaymentsAccountBalanceTransactionsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ShopifyPaymentsAccountBalanceTransactionsArgumentsBuilder HideTransfers(bool? hideTransfers)
        {
            base.InnerQuery.AddArgument("hideTransfers", hideTransfers);
            return this;
        }

        public ShopifyPaymentsAccountBalanceTransactionsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ShopifyPaymentsAccountBalanceTransactionsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public ShopifyPaymentsAccountBalanceTransactionsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public ShopifyPaymentsAccountBalanceTransactionsArgumentsBuilder SavedSearchId(string? savedSearchId)
        {
            base.InnerQuery.AddArgument("savedSearchId", savedSearchId);
            return this;
        }

        public ShopifyPaymentsAccountBalanceTransactionsArgumentsBuilder SortKey(BalanceTransactionSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}