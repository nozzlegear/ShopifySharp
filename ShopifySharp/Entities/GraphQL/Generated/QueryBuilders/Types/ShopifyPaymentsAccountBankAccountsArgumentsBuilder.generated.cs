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
    public sealed class ShopifyPaymentsAccountBankAccountsArgumentsBuilder : ArgumentsBuilderBase<ShopifyPaymentsBankAccountConnection?, ShopifyPaymentsAccountBankAccountsArgumentsBuilder>
    {
        protected override ShopifyPaymentsAccountBankAccountsArgumentsBuilder Self => this;

        public ShopifyPaymentsAccountBankAccountsArgumentsBuilder(IQuery<ShopifyPaymentsBankAccountConnection?> query) : base(query)
        {
        }

        public ShopifyPaymentsAccountBankAccountsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ShopifyPaymentsAccountBankAccountsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ShopifyPaymentsAccountBankAccountsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ShopifyPaymentsAccountBankAccountsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ShopifyPaymentsAccountBankAccountsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}