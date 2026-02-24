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
    public sealed class ShopifyPaymentsPayoutConnectionArgumentsBuilder : ArgumentsBuilderBase<ShopifyPaymentsPayoutConnection, ShopifyPaymentsPayoutConnectionArgumentsBuilder>
    {
        protected override ShopifyPaymentsPayoutConnectionArgumentsBuilder Self => this;

        public ShopifyPaymentsPayoutConnectionArgumentsBuilder(IQuery<ShopifyPaymentsPayoutConnection> query) : base(query)
        {
        }

        public ShopifyPaymentsPayoutConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ShopifyPaymentsPayoutConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ShopifyPaymentsPayoutConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ShopifyPaymentsPayoutConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ShopifyPaymentsPayoutConnectionArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public ShopifyPaymentsPayoutConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public ShopifyPaymentsPayoutConnectionArgumentsBuilder SavedSearchId(string? savedSearchId)
        {
            base.InnerQuery.AddArgument("savedSearchId", savedSearchId);
            return this;
        }

        public ShopifyPaymentsPayoutConnectionArgumentsBuilder SortKey(PayoutSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }

        public ShopifyPaymentsPayoutConnectionArgumentsBuilder TransactionType(ShopifyPaymentsPayoutTransactionType? transactionType)
        {
            base.InnerQuery.AddArgument("transactionType", transactionType);
            return this;
        }
    }
}