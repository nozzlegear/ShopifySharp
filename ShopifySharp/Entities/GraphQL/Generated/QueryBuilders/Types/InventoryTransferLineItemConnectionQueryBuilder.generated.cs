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
    public sealed class InventoryTransferLineItemConnectionQueryBuilder : FieldsQueryBuilderBase<InventoryTransferLineItemConnection, InventoryTransferLineItemConnectionQueryBuilder>
    {
        protected override InventoryTransferLineItemConnectionQueryBuilder Self => this;

        public InventoryTransferLineItemConnectionQueryBuilder() : this("inventoryTransferLineItemConnection")
        {
        }

        public InventoryTransferLineItemConnectionQueryBuilder(string name) : base(new Query<InventoryTransferLineItemConnection>(name))
        {
        }

        public InventoryTransferLineItemConnectionQueryBuilder(IQuery<InventoryTransferLineItemConnection> query) : base(query)
        {
        }

        public InventoryTransferLineItemConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferLineItemEdgeQueryBuilder> build)
        {
            var query = new Query<InventoryTransferLineItemEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferLineItemEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferLineItemEdge>(query);
            return this;
        }

        public InventoryTransferLineItemConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferLineItemQueryBuilder> build)
        {
            var query = new Query<InventoryTransferLineItem>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferLineItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferLineItem>(query);
            return this;
        }

        public InventoryTransferLineItemConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}