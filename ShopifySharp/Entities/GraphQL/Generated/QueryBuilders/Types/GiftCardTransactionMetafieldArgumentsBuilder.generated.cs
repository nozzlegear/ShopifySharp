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
    public sealed class GiftCardTransactionMetafieldArgumentsBuilder : ArgumentsBuilderBase<Metafield?, GiftCardTransactionMetafieldArgumentsBuilder>
    {
        protected override GiftCardTransactionMetafieldArgumentsBuilder Self => this;

        public GiftCardTransactionMetafieldArgumentsBuilder(IQuery<Metafield?> query) : base(query)
        {
        }

        public GiftCardTransactionMetafieldArgumentsBuilder Key(string? key)
        {
            base.InnerQuery.AddArgument("key", key);
            return this;
        }

        public GiftCardTransactionMetafieldArgumentsBuilder Namespace(string? @namespace)
        {
            base.InnerQuery.AddArgument("namespace", @namespace);
            return this;
        }
    }
}