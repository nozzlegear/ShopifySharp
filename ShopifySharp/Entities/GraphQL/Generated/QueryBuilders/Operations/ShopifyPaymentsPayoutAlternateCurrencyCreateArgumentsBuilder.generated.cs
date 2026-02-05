#nullable enable
using System;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.Linq.Expressions;
using ShopifySharp.Credentials;
using ShopifySharp.GraphQL;
using ShopifySharp.Infrastructure;
using ShopifySharp.Infrastructure.Serialization.Json;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Operations;
using ShopifySharp.GraphQL.Generated.QueryBuilders.Types;

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
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