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
    public sealed class ShopPayPaymentRequestReceiptsArgumentsBuilder : ArgumentsBuilderBase<ShopPayPaymentRequestReceiptConnection, ShopPayPaymentRequestReceiptsArgumentsBuilder>
    {
        protected override ShopPayPaymentRequestReceiptsArgumentsBuilder Self => this;

        public ShopPayPaymentRequestReceiptsArgumentsBuilder(IQuery<ShopPayPaymentRequestReceiptConnection> query) : base(query)
        {
        }

        public ShopPayPaymentRequestReceiptsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public ShopPayPaymentRequestReceiptsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public ShopPayPaymentRequestReceiptsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public ShopPayPaymentRequestReceiptsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public ShopPayPaymentRequestReceiptsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public ShopPayPaymentRequestReceiptsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public ShopPayPaymentRequestReceiptsArgumentsBuilder SortKey(ShopPayPaymentRequestReceiptsSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}