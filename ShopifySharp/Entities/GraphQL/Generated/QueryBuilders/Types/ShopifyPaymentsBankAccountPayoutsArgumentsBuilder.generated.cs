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
    public sealed class ShopifyPaymentsBankAccountPayoutsArgumentsBuilder : ArgumentsBuilderBase<ShopifyPaymentsPayoutConnection?, ShopifyPaymentsBankAccountPayoutsArgumentsBuilder>
    {
        protected override ShopifyPaymentsBankAccountPayoutsArgumentsBuilder Self => this;

        public ShopifyPaymentsBankAccountPayoutsArgumentsBuilder(IQuery<ShopifyPaymentsPayoutConnection?> query) : base(query)
        {
        }

        public ShopifyPaymentsBankAccountPayoutsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ShopifyPaymentsBankAccountPayoutsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ShopifyPaymentsBankAccountPayoutsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ShopifyPaymentsBankAccountPayoutsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ShopifyPaymentsBankAccountPayoutsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public ShopifyPaymentsBankAccountPayoutsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public ShopifyPaymentsBankAccountPayoutsArgumentsBuilder SavedSearchId(string? savedSearchId)
        {
            base.InnerQuery.AddArgument("savedSearchId", savedSearchId);
            return this;
        }

        public ShopifyPaymentsBankAccountPayoutsArgumentsBuilder SortKey(PayoutSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }

        public ShopifyPaymentsBankAccountPayoutsArgumentsBuilder TransactionType(ShopifyPaymentsPayoutTransactionType? transactionType)
        {
            base.InnerQuery.AddArgument("transactionType", transactionType);
            return this;
        }
    }
}