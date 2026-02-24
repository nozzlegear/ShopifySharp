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
    public sealed class LocationInventoryLevelsQueryBuilder : FieldsQueryBuilderBase<InventoryLevelConnection, LocationInventoryLevelsQueryBuilder>, IHasArguments<LocationInventoryLevelsArgumentsBuilder>
    {
        public LocationInventoryLevelsArgumentsBuilder Arguments { get; }
        protected override LocationInventoryLevelsQueryBuilder Self => this;

        public LocationInventoryLevelsQueryBuilder(string name) : base(new Query<InventoryLevelConnection>(name))
        {
            Arguments = new LocationInventoryLevelsArgumentsBuilder(base.InnerQuery);
        }

        public LocationInventoryLevelsQueryBuilder(IQuery<InventoryLevelConnection> query) : base(query)
        {
            Arguments = new LocationInventoryLevelsArgumentsBuilder(base.InnerQuery);
        }

        public LocationInventoryLevelsQueryBuilder SetArguments(Action<LocationInventoryLevelsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public LocationInventoryLevelsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelEdgeQueryBuilder> build)
        {
            var query = new Query<InventoryLevelEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryLevelEdge>(query);
            return this;
        }

        public LocationInventoryLevelsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelQueryBuilder> build)
        {
            var query = new Query<InventoryLevel>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryLevel>(query);
            return this;
        }

        public LocationInventoryLevelsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}