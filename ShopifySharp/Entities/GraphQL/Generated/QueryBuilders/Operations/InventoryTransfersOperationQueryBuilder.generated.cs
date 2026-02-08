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
    public sealed class InventoryTransfersOperationQueryBuilder : FieldsQueryBuilderBase<InventoryTransferConnection, InventoryTransfersOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryTransferConnection>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public InventoryTransfersArgumentsBuilder Arguments { get; }
        protected override InventoryTransfersOperationQueryBuilder Self => this;

        public InventoryTransfersOperationQueryBuilder() : this("inventoryTransfers")
        {
        }

        public InventoryTransfersOperationQueryBuilder(string name) : base(new Query<InventoryTransferConnection>(name))
        {
            Arguments = new InventoryTransfersArgumentsBuilder(base.InnerQuery);
        }

        public InventoryTransfersOperationQueryBuilder(IQuery<InventoryTransferConnection> query) : base(query)
        {
            Arguments = new InventoryTransfersArgumentsBuilder(base.InnerQuery);
        }

        public InventoryTransfersOperationQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferEdgeQueryBuilder> build)
        {
            var query = new Query<InventoryTransferEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferEdge>(query);
            return this;
        }

        public InventoryTransfersOperationQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder> build)
        {
            var query = new Query<InventoryTransfer>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransfer>(query);
            return this;
        }

        public InventoryTransfersOperationQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}