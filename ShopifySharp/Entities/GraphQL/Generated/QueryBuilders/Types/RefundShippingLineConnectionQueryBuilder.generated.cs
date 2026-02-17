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
    public sealed class RefundShippingLineConnectionQueryBuilder : FieldsQueryBuilderBase<RefundShippingLineConnection, RefundShippingLineConnectionQueryBuilder>
    {
        protected override RefundShippingLineConnectionQueryBuilder Self => this;

        public RefundShippingLineConnectionQueryBuilder() : this("refundShippingLineConnection")
        {
        }

        public RefundShippingLineConnectionQueryBuilder(string name) : base(new Query<RefundShippingLineConnection>(name))
        {
        }

        public RefundShippingLineConnectionQueryBuilder(IQuery<RefundShippingLineConnection> query) : base(query)
        {
        }

        public RefundShippingLineConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundShippingLineEdgeQueryBuilder> build)
        {
            var query = new Query<RefundShippingLineEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundShippingLineEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RefundShippingLineEdge>(query);
            return this;
        }

        public RefundShippingLineConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundShippingLineQueryBuilder> build)
        {
            var query = new Query<RefundShippingLine>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundShippingLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RefundShippingLine>(query);
            return this;
        }

        public RefundShippingLineConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}