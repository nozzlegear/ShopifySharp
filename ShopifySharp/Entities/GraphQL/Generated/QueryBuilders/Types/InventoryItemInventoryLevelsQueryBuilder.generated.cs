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
    public sealed class InventoryItemInventoryLevelsQueryBuilder : FieldsQueryBuilderBase<InventoryLevelConnection, InventoryItemInventoryLevelsQueryBuilder>, IHasArguments<InventoryItemInventoryLevelsArgumentsBuilder>
    {
        public InventoryItemInventoryLevelsArgumentsBuilder Arguments { get; }
        protected override InventoryItemInventoryLevelsQueryBuilder Self => this;

        public InventoryItemInventoryLevelsQueryBuilder(string name) : base(new Query<InventoryLevelConnection>(name))
        {
            Arguments = new InventoryItemInventoryLevelsArgumentsBuilder(base.InnerQuery);
        }

        public InventoryItemInventoryLevelsQueryBuilder(IQuery<InventoryLevelConnection> query) : base(query)
        {
            Arguments = new InventoryItemInventoryLevelsArgumentsBuilder(base.InnerQuery);
        }

        public InventoryItemInventoryLevelsQueryBuilder SetArguments(Action<InventoryItemInventoryLevelsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public InventoryItemInventoryLevelsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelEdgeQueryBuilder> build)
        {
            var query = new Query<InventoryLevelEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryLevelEdge>(query);
            return this;
        }

        public InventoryItemInventoryLevelsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelQueryBuilder> build)
        {
            var query = new Query<InventoryLevel>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryLevel>(query);
            return this;
        }

        public InventoryItemInventoryLevelsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}