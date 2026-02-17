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
    public sealed class ShopPayPaymentRequestReceiptEdgeQueryBuilder : FieldsQueryBuilderBase<ShopPayPaymentRequestReceiptEdge, ShopPayPaymentRequestReceiptEdgeQueryBuilder>
    {
        protected override ShopPayPaymentRequestReceiptEdgeQueryBuilder Self => this;

        public ShopPayPaymentRequestReceiptEdgeQueryBuilder() : this("shopPayPaymentRequestReceiptEdge")
        {
        }

        public ShopPayPaymentRequestReceiptEdgeQueryBuilder(string name) : base(new Query<ShopPayPaymentRequestReceiptEdge>(name))
        {
        }

        public ShopPayPaymentRequestReceiptEdgeQueryBuilder(IQuery<ShopPayPaymentRequestReceiptEdge> query) : base(query)
        {
        }

        public ShopPayPaymentRequestReceiptEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public ShopPayPaymentRequestReceiptEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShopPayPaymentRequestReceiptQueryBuilder> build)
        {
            var query = new Query<ShopPayPaymentRequestReceipt>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShopPayPaymentRequestReceiptQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShopPayPaymentRequestReceipt>(query);
            return this;
        }
    }
}