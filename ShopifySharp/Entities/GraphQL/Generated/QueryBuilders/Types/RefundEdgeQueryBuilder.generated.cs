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
    public sealed class RefundEdgeQueryBuilder : FieldsQueryBuilderBase<RefundEdge, RefundEdgeQueryBuilder>
    {
        protected override RefundEdgeQueryBuilder Self => this;

        public RefundEdgeQueryBuilder() : this("refundEdge")
        {
        }

        public RefundEdgeQueryBuilder(string name) : base(new Query<RefundEdge>(name))
        {
        }

        public RefundEdgeQueryBuilder(IQuery<RefundEdge> query) : base(query)
        {
        }

        public RefundEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public RefundEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundQueryBuilder> build)
        {
            var query = new Query<Refund>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Refund>(query);
            return this;
        }
    }
}