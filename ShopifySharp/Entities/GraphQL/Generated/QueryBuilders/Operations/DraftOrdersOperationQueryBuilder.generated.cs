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
    public sealed class DraftOrdersOperationQueryBuilder : FieldsQueryBuilderBase<DraftOrderConnection, DraftOrdersOperationQueryBuilder>, IGraphOperationQueryBuilder<DraftOrderConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public DraftOrdersArgumentsBuilder Arguments { get; }
        protected override DraftOrdersOperationQueryBuilder Self => this;

        public DraftOrdersOperationQueryBuilder() : this("draftOrders")
        {
        }

        public DraftOrdersOperationQueryBuilder(string name) : base(new Query<DraftOrderConnection>(name))
        {
            Arguments = new DraftOrdersArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrdersOperationQueryBuilder(IQuery<DraftOrderConnection> query) : base(query)
        {
            Arguments = new DraftOrdersArgumentsBuilder(base.InnerQuery);
        }

        public DraftOrdersOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderEdgeQueryBuilder> build)
        {
            var query = new Query<DraftOrderEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrderEdge>(query);
            return this;
        }

        public DraftOrdersOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderQueryBuilder> build)
        {
            var query = new Query<DraftOrder>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.DraftOrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DraftOrder>(query);
            return this;
        }

        public DraftOrdersOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}