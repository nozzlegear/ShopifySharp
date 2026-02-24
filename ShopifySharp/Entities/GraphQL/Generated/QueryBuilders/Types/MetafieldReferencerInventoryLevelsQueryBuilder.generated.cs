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
    public sealed class MetafieldReferencerInventoryLevelsQueryBuilder : FieldsQueryBuilderBase<InventoryLevelConnection, MetafieldReferencerInventoryLevelsQueryBuilder>, IHasArguments<MetafieldReferencerInventoryLevelsArgumentsBuilder>
    {
        public MetafieldReferencerInventoryLevelsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferencerInventoryLevelsQueryBuilder Self => this;

        public MetafieldReferencerInventoryLevelsQueryBuilder(string name) : base(new Query<InventoryLevelConnection>(name))
        {
            Arguments = new MetafieldReferencerInventoryLevelsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerInventoryLevelsQueryBuilder(IQuery<InventoryLevelConnection> query) : base(query)
        {
            Arguments = new MetafieldReferencerInventoryLevelsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferencerInventoryLevelsQueryBuilder SetArguments(Action<MetafieldReferencerInventoryLevelsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferencerInventoryLevelsQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelEdgeQueryBuilder> build)
        {
            var query = new Query<InventoryLevelEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryLevelEdge>(query);
            return this;
        }

        public MetafieldReferencerInventoryLevelsQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelQueryBuilder> build)
        {
            var query = new Query<InventoryLevel>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryLevel>(query);
            return this;
        }

        public MetafieldReferencerInventoryLevelsQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}