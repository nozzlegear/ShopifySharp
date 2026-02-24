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
    public sealed class ShopifyPaymentsAccountPayoutsArgumentsBuilder : ArgumentsBuilderBase<ShopifyPaymentsPayoutConnection?, ShopifyPaymentsAccountPayoutsArgumentsBuilder>
    {
        protected override ShopifyPaymentsAccountPayoutsArgumentsBuilder Self => this;

        public ShopifyPaymentsAccountPayoutsArgumentsBuilder(IQuery<ShopifyPaymentsPayoutConnection?> query) : base(query)
        {
        }

        public ShopifyPaymentsAccountPayoutsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ShopifyPaymentsAccountPayoutsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ShopifyPaymentsAccountPayoutsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ShopifyPaymentsAccountPayoutsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ShopifyPaymentsAccountPayoutsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public ShopifyPaymentsAccountPayoutsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public ShopifyPaymentsAccountPayoutsArgumentsBuilder SavedSearchId(string? savedSearchId)
        {
            base.InnerQuery.AddArgument("savedSearchId", savedSearchId);
            return this;
        }

        public ShopifyPaymentsAccountPayoutsArgumentsBuilder SortKey(PayoutSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }

        public ShopifyPaymentsAccountPayoutsArgumentsBuilder TransactionType(ShopifyPaymentsPayoutTransactionType? transactionType)
        {
            base.InnerQuery.AddArgument("transactionType", transactionType);
            return this;
        }
    }
}