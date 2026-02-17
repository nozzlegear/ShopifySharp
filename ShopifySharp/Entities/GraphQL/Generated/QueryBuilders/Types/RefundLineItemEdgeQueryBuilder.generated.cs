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
    public sealed class RefundLineItemEdgeQueryBuilder : FieldsQueryBuilderBase<RefundLineItemEdge, RefundLineItemEdgeQueryBuilder>
    {
        protected override RefundLineItemEdgeQueryBuilder Self => this;

        public RefundLineItemEdgeQueryBuilder() : this("refundLineItemEdge")
        {
        }

        public RefundLineItemEdgeQueryBuilder(string name) : base(new Query<RefundLineItemEdge>(name))
        {
        }

        public RefundLineItemEdgeQueryBuilder(IQuery<RefundLineItemEdge> query) : base(query)
        {
        }

        public RefundLineItemEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public RefundLineItemEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundLineItemQueryBuilder> build)
        {
            var query = new Query<RefundLineItem>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RefundLineItem>(query);
            return this;
        }
    }
}