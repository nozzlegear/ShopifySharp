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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class InventoryLevelConnectionQueryBuilder : FieldsQueryBuilderBase<InventoryLevelConnection, InventoryLevelConnectionQueryBuilder>
    {
        protected override InventoryLevelConnectionQueryBuilder Self => this;

        public InventoryLevelConnectionQueryBuilder() : this("inventoryLevelConnection")
        {
        }

        public InventoryLevelConnectionQueryBuilder(string name) : base(new Query<InventoryLevelConnection>(name))
        {
        }

        public InventoryLevelConnectionQueryBuilder(IQuery<InventoryLevelConnection> query) : base(query)
        {
        }

        public InventoryLevelConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryLevelEdgeQueryBuilder> build)
        {
            var query = new Query<InventoryLevelEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryLevelEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryLevelEdge>(query);
            return this;
        }

        public InventoryLevelConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryLevelQueryBuilder> build)
        {
            var query = new Query<InventoryLevel>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryLevelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryLevel>(query);
            return this;
        }

        public InventoryLevelConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}