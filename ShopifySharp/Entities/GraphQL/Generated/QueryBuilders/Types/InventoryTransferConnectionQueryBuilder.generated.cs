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
    public sealed class InventoryTransferConnectionQueryBuilder : FieldsQueryBuilderBase<InventoryTransferConnection, InventoryTransferConnectionQueryBuilder>
    {
        protected override InventoryTransferConnectionQueryBuilder Self => this;

        public InventoryTransferConnectionQueryBuilder() : this("inventoryTransferConnection")
        {
        }

        public InventoryTransferConnectionQueryBuilder(string name) : base(new Query<InventoryTransferConnection>(name))
        {
        }

        public InventoryTransferConnectionQueryBuilder(IQuery<InventoryTransferConnection> query) : base(query)
        {
        }

        public InventoryTransferConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferEdgeQueryBuilder> build)
        {
            var query = new Query<InventoryTransferEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferEdge>(query);
            return this;
        }

        public InventoryTransferConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferQueryBuilder> build)
        {
            var query = new Query<InventoryTransfer>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransfer>(query);
            return this;
        }

        public InventoryTransferConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}