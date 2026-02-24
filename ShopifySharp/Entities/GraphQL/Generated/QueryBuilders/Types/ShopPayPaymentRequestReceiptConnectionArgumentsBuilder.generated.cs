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
    public sealed class ShopPayPaymentRequestReceiptConnectionArgumentsBuilder : ArgumentsBuilderBase<ShopPayPaymentRequestReceiptConnection, ShopPayPaymentRequestReceiptConnectionArgumentsBuilder>
    {
        protected override ShopPayPaymentRequestReceiptConnectionArgumentsBuilder Self => this;

        public ShopPayPaymentRequestReceiptConnectionArgumentsBuilder(IQuery<ShopPayPaymentRequestReceiptConnection> query) : base(query)
        {
        }

        public ShopPayPaymentRequestReceiptConnectionArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ShopPayPaymentRequestReceiptConnectionArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ShopPayPaymentRequestReceiptConnectionArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ShopPayPaymentRequestReceiptConnectionArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ShopPayPaymentRequestReceiptConnectionArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public ShopPayPaymentRequestReceiptConnectionArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public ShopPayPaymentRequestReceiptConnectionArgumentsBuilder SortKey(ShopPayPaymentRequestReceiptsSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}