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
    public sealed class InventoryScheduledChangeConnectionQueryBuilder : FieldsQueryBuilderBase<InventoryScheduledChangeConnection, InventoryScheduledChangeConnectionQueryBuilder>
    {
        protected override InventoryScheduledChangeConnectionQueryBuilder Self => this;

        public InventoryScheduledChangeConnectionQueryBuilder() : this("inventoryScheduledChangeConnection")
        {
        }

        public InventoryScheduledChangeConnectionQueryBuilder(string name) : base(new Query<InventoryScheduledChangeConnection>(name))
        {
        }

        public InventoryScheduledChangeConnectionQueryBuilder(IQuery<InventoryScheduledChangeConnection> query) : base(query)
        {
        }

        public InventoryScheduledChangeConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryScheduledChangeEdgeQueryBuilder> build)
        {
            var query = new Query<InventoryScheduledChangeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryScheduledChangeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryScheduledChangeEdge>(query);
            return this;
        }

        public InventoryScheduledChangeConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryScheduledChangeQueryBuilder> build)
        {
            var query = new Query<InventoryScheduledChange>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryScheduledChangeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryScheduledChange>(query);
            return this;
        }

        public InventoryScheduledChangeConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}