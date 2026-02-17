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
    public sealed class InventoryLevelEdgeQueryBuilder : FieldsQueryBuilderBase<InventoryLevelEdge, InventoryLevelEdgeQueryBuilder>
    {
        protected override InventoryLevelEdgeQueryBuilder Self => this;

        public InventoryLevelEdgeQueryBuilder() : this("inventoryLevelEdge")
        {
        }

        public InventoryLevelEdgeQueryBuilder(string name) : base(new Query<InventoryLevelEdge>(name))
        {
        }

        public InventoryLevelEdgeQueryBuilder(IQuery<InventoryLevelEdge> query) : base(query)
        {
        }

        public InventoryLevelEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public InventoryLevelEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelQueryBuilder> build)
        {
            var query = new Query<InventoryLevel>("node");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryLevel>(query);
            return this;
        }
    }
}