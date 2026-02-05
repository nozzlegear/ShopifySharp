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
    public sealed class InventoryItemEdgeQueryBuilder : FieldsQueryBuilderBase<InventoryItemEdge, InventoryItemEdgeQueryBuilder>
    {
        protected override InventoryItemEdgeQueryBuilder Self => this;

        public InventoryItemEdgeQueryBuilder() : this("inventoryItemEdge")
        {
        }

        public InventoryItemEdgeQueryBuilder(string name) : base(new Query<InventoryItemEdge>(name))
        {
        }

        public InventoryItemEdgeQueryBuilder(IQuery<InventoryItemEdge> query) : base(query)
        {
        }

        public InventoryItemEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public InventoryItemEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryItemQueryBuilder> build)
        {
            var query = new Query<InventoryItem>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryItem>(query);
            return this;
        }
    }
}