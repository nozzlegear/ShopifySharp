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
    public sealed class InventoryScheduledChangeEdgeQueryBuilder : FieldsQueryBuilderBase<InventoryScheduledChangeEdge, InventoryScheduledChangeEdgeQueryBuilder>
    {
        protected override InventoryScheduledChangeEdgeQueryBuilder Self => this;

        public InventoryScheduledChangeEdgeQueryBuilder() : this("inventoryScheduledChangeEdge")
        {
        }

        public InventoryScheduledChangeEdgeQueryBuilder(string name) : base(new Query<InventoryScheduledChangeEdge>(name))
        {
        }

        public InventoryScheduledChangeEdgeQueryBuilder(IQuery<InventoryScheduledChangeEdge> query) : base(query)
        {
        }

        public InventoryScheduledChangeEdgeQueryBuilder Cursor()
        {
            base.InnerQuery.AddField("cursor");
            return this;
        }

        public InventoryScheduledChangeEdgeQueryBuilder Node(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryScheduledChangeQueryBuilder> build)
        {
            var query = new Query<InventoryScheduledChange>("node");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryScheduledChangeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryScheduledChange>(query);
            return this;
        }
    }
}