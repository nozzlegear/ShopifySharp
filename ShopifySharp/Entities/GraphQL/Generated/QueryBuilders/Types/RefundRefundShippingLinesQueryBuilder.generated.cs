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
    public sealed class RefundRefundShippingLinesQueryBuilder : FieldsQueryBuilderBase<RefundShippingLineConnection, RefundRefundShippingLinesQueryBuilder>, IHasArguments<RefundRefundShippingLinesArgumentsBuilder>
    {
        public RefundRefundShippingLinesArgumentsBuilder Arguments { get; }
        protected override RefundRefundShippingLinesQueryBuilder Self => this;

        public RefundRefundShippingLinesQueryBuilder(string name) : base(new Query<RefundShippingLineConnection>(name))
        {
            Arguments = new RefundRefundShippingLinesArgumentsBuilder(base.InnerQuery);
        }

        public RefundRefundShippingLinesQueryBuilder(IQuery<RefundShippingLineConnection> query) : base(query)
        {
            Arguments = new RefundRefundShippingLinesArgumentsBuilder(base.InnerQuery);
        }

        public RefundRefundShippingLinesQueryBuilder SetArguments(Action<RefundRefundShippingLinesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public RefundRefundShippingLinesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundShippingLineEdgeQueryBuilder> build)
        {
            var query = new Query<RefundShippingLineEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundShippingLineEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RefundShippingLineEdge>(query);
            return this;
        }

        public RefundRefundShippingLinesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundShippingLineQueryBuilder> build)
        {
            var query = new Query<RefundShippingLine>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundShippingLineQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RefundShippingLine>(query);
            return this;
        }

        public RefundRefundShippingLinesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}