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
    public sealed class QueryRootShopPayPaymentRequestReceiptsArgumentsBuilder : ArgumentsBuilderBase<ShopPayPaymentRequestReceiptConnection?, QueryRootShopPayPaymentRequestReceiptsArgumentsBuilder>
    {
        protected override QueryRootShopPayPaymentRequestReceiptsArgumentsBuilder Self => this;

        public QueryRootShopPayPaymentRequestReceiptsArgumentsBuilder(IQuery<ShopPayPaymentRequestReceiptConnection?> query) : base(query)
        {
        }

        public QueryRootShopPayPaymentRequestReceiptsArgumentsBuilder After(string? after)
        {
            base.InnerQuery.AddArgument("after", after);
            return this;
        }

        public QueryRootShopPayPaymentRequestReceiptsArgumentsBuilder Before(string? before)
        {
            base.InnerQuery.AddArgument("before", before);
            return this;
        }

        public QueryRootShopPayPaymentRequestReceiptsArgumentsBuilder First(int? first)
        {
            base.InnerQuery.AddArgument("first", first);
            return this;
        }

        public QueryRootShopPayPaymentRequestReceiptsArgumentsBuilder Last(int? last)
        {
            base.InnerQuery.AddArgument("last", last);
            return this;
        }

        public QueryRootShopPayPaymentRequestReceiptsArgumentsBuilder Query(string? query)
        {
            base.InnerQuery.AddArgument("query", query);
            return this;
        }

        public QueryRootShopPayPaymentRequestReceiptsArgumentsBuilder Reverse(bool? reverse)
        {
            base.InnerQuery.AddArgument("reverse", reverse);
            return this;
        }

        public QueryRootShopPayPaymentRequestReceiptsArgumentsBuilder SortKey(ShopPayPaymentRequestReceiptsSortKeys? sortKey)
        {
            base.InnerQuery.AddArgument("sortKey", sortKey);
            return this;
        }
    }
}