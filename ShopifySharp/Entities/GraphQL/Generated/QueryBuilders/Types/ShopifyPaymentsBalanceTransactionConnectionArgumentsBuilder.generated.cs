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
    public sealed class ShopifyPaymentsBalanceTransactionConnectionArgumentsBuilder : ArgumentsBuilderBase<ShopifyPaymentsBalanceTransactionConnection, ShopifyPaymentsBalanceTransactionConnectionArgumentsBuilder>
    {
        protected override ShopifyPaymentsBalanceTransactionConnectionArgumentsBuilder Self => this;

        public ShopifyPaymentsBalanceTransactionConnectionArgumentsBuilder(IQuery<ShopifyPaymentsBalanceTransactionConnection> query) : base(query)
        {
        }

        public ShopifyPaymentsBalanceTransactionConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ShopifyPaymentsBalanceTransactionConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ShopifyPaymentsBalanceTransactionConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ShopifyPaymentsBalanceTransactionConnectionArgumentsBuilder HideTransfers(bool? hideTransfers)
        {
            base.InnerQuery.AddArgument("hideTransfers", hideTransfers);
            return this;
        }

        public ShopifyPaymentsBalanceTransactionConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ShopifyPaymentsBalanceTransactionConnectionArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public ShopifyPaymentsBalanceTransactionConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public ShopifyPaymentsBalanceTransactionConnectionArgumentsBuilder SavedSearchId(string? savedSearchId)
        {
            base.InnerQuery.AddArgument("savedSearchId", savedSearchId);
            return this;
        }

        public ShopifyPaymentsBalanceTransactionConnectionArgumentsBuilder SortKey(BalanceTransactionSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}