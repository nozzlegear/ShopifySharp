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
    public sealed class RefundRefundLineItemsQueryBuilder : FieldsQueryBuilderBase<RefundLineItemConnection, RefundRefundLineItemsQueryBuilder>, IHasArguments<RefundRefundLineItemsArgumentsBuilder>
    {
        public RefundRefundLineItemsArgumentsBuilder Arguments { get; }
        protected override RefundRefundLineItemsQueryBuilder Self => this;

        public RefundRefundLineItemsQueryBuilder(string name) : base(new Query<RefundLineItemConnection>(name))
        {
            Arguments = new RefundRefundLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public RefundRefundLineItemsQueryBuilder(IQuery<RefundLineItemConnection> query) : base(query)
        {
            Arguments = new RefundRefundLineItemsArgumentsBuilder(base.InnerQuery);
        }

        public RefundRefundLineItemsQueryBuilder SetArguments(Action<RefundRefundLineItemsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public RefundRefundLineItemsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundLineItemEdgeQueryBuilder> build)
        {
            var query = new Query<RefundLineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundLineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RefundLineItemEdge>(query);
            return this;
        }

        public RefundRefundLineItemsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.RefundLineItemQueryBuilder> build)
        {
            var query = new Query<RefundLineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.RefundLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<RefundLineItem>(query);
            return this;
        }

        public RefundRefundLineItemsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}