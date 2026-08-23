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
    public sealed class GiftCardCashOutTransactionMetafieldsArgumentsBuilder : ArgumentsBuilderBase<MetafieldConnection?, GiftCardCashOutTransactionMetafieldsArgumentsBuilder>
    {
        protected override GiftCardCashOutTransactionMetafieldsArgumentsBuilder Self => this;

        public GiftCardCashOutTransactionMetafieldsArgumentsBuilder(IQuery<MetafieldConnection?> query) : base(query)
        {
        }

        public GiftCardCashOutTransactionMetafieldsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public GiftCardCashOutTransactionMetafieldsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public GiftCardCashOutTransactionMetafieldsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public GiftCardCashOutTransactionMetafieldsArgumentsBuilder Keys(ICollection<string>? keys)
        {
            base.InnerQuery.AddArgument("keys", keys);
            return this;
        }

        public GiftCardCashOutTransactionMetafieldsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public GiftCardCashOutTransactionMetafieldsArgumentsBuilder Namespace(string? @namespace)
        {
            base.InnerQuery.AddArgument("namespace", @namespace);
            return this;
        }

        public GiftCardCashOutTransactionMetafieldsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }
    }
}