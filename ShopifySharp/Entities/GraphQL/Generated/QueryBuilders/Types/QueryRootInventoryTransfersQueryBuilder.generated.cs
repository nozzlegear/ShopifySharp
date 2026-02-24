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
    public sealed class QueryRootInventoryTransfersQueryBuilder : FieldsQueryBuilderBase<InventoryTransferConnection, QueryRootInventoryTransfersQueryBuilder>, IHasArguments<QueryRootInventoryTransfersArgumentsBuilder>
    {
        public QueryRootInventoryTransfersArgumentsBuilder Arguments { get; }
        protected override QueryRootInventoryTransfersQueryBuilder Self => this;

        public QueryRootInventoryTransfersQueryBuilder(string name) : base(new Query<InventoryTransferConnection>(name))
        {
            Arguments = new QueryRootInventoryTransfersArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootInventoryTransfersQueryBuilder(IQuery<InventoryTransferConnection> query) : base(query)
        {
            Arguments = new QueryRootInventoryTransfersArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootInventoryTransfersQueryBuilder SetArguments(Action<QueryRootInventoryTransfersArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootInventoryTransfersQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferEdgeQueryBuilder> build)
        {
            var query = new Query<InventoryTransferEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferEdge>(query);
            return this;
        }

        public QueryRootInventoryTransfersQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferQueryBuilder> build)
        {
            var query = new Query<InventoryTransfer>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransfer>(query);
            return this;
        }

        public QueryRootInventoryTransfersQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}