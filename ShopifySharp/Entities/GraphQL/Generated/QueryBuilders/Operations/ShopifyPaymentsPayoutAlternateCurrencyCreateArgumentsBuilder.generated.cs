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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class ShopifyPaymentsPayoutAlternateCurrencyCreateArgumentsBuilder : ArgumentsBuilderBase<ShopifyPaymentsPayoutAlternateCurrencyCreatePayload, ShopifyPaymentsPayoutAlternateCurrencyCreateArgumentsBuilder>
    {
        protected override ShopifyPaymentsPayoutAlternateCurrencyCreateArgumentsBuilder Self => this;

        public ShopifyPaymentsPayoutAlternateCurrencyCreateArgumentsBuilder(IQuery<ShopifyPaymentsPayoutAlternateCurrencyCreatePayload> query) : base(query)
        {
        }

        public ShopifyPaymentsPayoutAlternateCurrencyCreateArgumentsBuilder AccountId(string? accountId)
        {
            base.InnerQuery.AddArgument("accountId", accountId);
            return this;
        }

        public ShopifyPaymentsPayoutAlternateCurrencyCreateArgumentsBuilder Currency(CurrencyCode? currency)
        {
            base.InnerQuery.AddArgument("currency", currency);
            return this;
        }
    }
}