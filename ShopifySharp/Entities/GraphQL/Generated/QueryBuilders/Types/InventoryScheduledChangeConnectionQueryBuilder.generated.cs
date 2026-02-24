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
    public sealed class InventoryScheduledChangeConnectionQueryBuilder : FieldsQueryBuilderBase<InventoryScheduledChangeConnection, InventoryScheduledChangeConnectionQueryBuilder>, IHasArguments<InventoryScheduledChangeConnectionArgumentsBuilder>
    {
        public InventoryScheduledChangeConnectionArgumentsBuilder Arguments { get; }
        protected override InventoryScheduledChangeConnectionQueryBuilder Self => this;

        public InventoryScheduledChangeConnectionQueryBuilder() : this("inventoryScheduledChangeConnection")
        {
        }

        public InventoryScheduledChangeConnectionQueryBuilder(string name) : base(new Query<InventoryScheduledChangeConnection>(name))
        {
            Arguments = new InventoryScheduledChangeConnectionArgumentsBuilder(base.InnerQuery);
        }

        public InventoryScheduledChangeConnectionQueryBuilder(IQuery<InventoryScheduledChangeConnection> query) : base(query)
        {
            Arguments = new InventoryScheduledChangeConnectionArgumentsBuilder(base.InnerQuery);
        }

        public InventoryScheduledChangeConnectionQueryBuilder SetArguments(Action<InventoryScheduledChangeConnectionArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public InventoryScheduledChangeConnectionQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryScheduledChangeEdgeQueryBuilder> build)
        {
            var query = new Query<InventoryScheduledChangeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryScheduledChangeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryScheduledChangeEdge>(query);
            return this;
        }

        public InventoryScheduledChangeConnectionQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryScheduledChangeQueryBuilder> build)
        {
            var query = new Query<InventoryScheduledChange>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryScheduledChangeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryScheduledChange>(query);
            return this;
        }

        public InventoryScheduledChangeConnectionQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}