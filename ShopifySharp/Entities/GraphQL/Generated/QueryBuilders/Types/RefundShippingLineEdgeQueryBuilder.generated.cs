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
    public sealed class RefundShippingLineEdgeQueryBuilder : FieldsQueryBuilderBase<RefundShippingLineEdge, RefundShippingLineEdgeQueryBuilder>
    {
        protected override RefundShippingLineEdgeQueryBuilder Self => this;

        public RefundShippingLineEdgeQueryBuilder() : this("refundShippingLineEdge")
        {
        }

        public RefundShippingLineEdgeQueryBuilder(string name) : base(new Query<RefundShippingLineEdge>(name))
        {
        }

        public RefundShippingLineEdgeQueryBuilder(IQuery<RefundShippingLineEdge> query) : base(query)
        {
        }

        public RefundShippingLineEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public RefundShippingLineEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundShippingLineQueryBuilder> build)
        {
            var query = new Query<RefundShippingLine>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundShippingLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RefundShippingLine>(query);
            return this;
        }
    }
}