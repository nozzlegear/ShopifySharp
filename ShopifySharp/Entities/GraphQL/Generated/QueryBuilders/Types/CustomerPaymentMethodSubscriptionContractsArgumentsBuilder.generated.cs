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
    public sealed class CustomerPaymentMethodSubscriptionContractsArgumentsBuilder : ArgumentsBuilderBase<SubscriptionContractConnection?, CustomerPaymentMethodSubscriptionContractsArgumentsBuilder>
    {
        protected override CustomerPaymentMethodSubscriptionContractsArgumentsBuilder Self => this;

        public CustomerPaymentMethodSubscriptionContractsArgumentsBuilder(IQuery<SubscriptionContractConnection?> query) : base(query)
        {
        }

        public CustomerPaymentMethodSubscriptionContractsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public CustomerPaymentMethodSubscriptionContractsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public CustomerPaymentMethodSubscriptionContractsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public CustomerPaymentMethodSubscriptionContractsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public CustomerPaymentMethodSubscriptionContractsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}