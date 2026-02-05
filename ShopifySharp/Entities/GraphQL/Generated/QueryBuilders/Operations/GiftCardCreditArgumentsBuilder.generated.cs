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
    public sealed class GiftCardCreditArgumentsBuilder : ArgumentsBuilderBase<GiftCardCreditPayload, GiftCardCreditArgumentsBuilder>
    {
        protected override GiftCardCreditArgumentsBuilder Self => this;

        public GiftCardCreditArgumentsBuilder(IQuery<GiftCardCreditPayload> query) : base(query)
        {
        }

        public GiftCardCreditArgumentsBuilder CreditInput(GiftCardCreditInput? creditInput)
        {
            base.InnerQuery.AddArgument("creditInput", creditInput);
            return this;
        }

        public GiftCardCreditArgumentsBuilder Id(string? id)
        {
            base.InnerQuery.AddArgument("id", id);
            return this;
        }
    }
}