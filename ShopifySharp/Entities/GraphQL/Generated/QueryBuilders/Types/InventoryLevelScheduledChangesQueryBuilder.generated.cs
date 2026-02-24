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
    public sealed class InventoryLevelScheduledChangesQueryBuilder : FieldsQueryBuilderBase<InventoryScheduledChangeConnection, InventoryLevelScheduledChangesQueryBuilder>, IHasArguments<InventoryLevelScheduledChangesArgumentsBuilder>
    {
        public InventoryLevelScheduledChangesArgumentsBuilder Arguments { get; }
        protected override InventoryLevelScheduledChangesQueryBuilder Self => this;

        public InventoryLevelScheduledChangesQueryBuilder(string name) : base(new Query<InventoryScheduledChangeConnection>(name))
        {
            Arguments = new InventoryLevelScheduledChangesArgumentsBuilder(base.InnerQuery);
        }

        public InventoryLevelScheduledChangesQueryBuilder(IQuery<InventoryScheduledChangeConnection> query) : base(query)
        {
            Arguments = new InventoryLevelScheduledChangesArgumentsBuilder(base.InnerQuery);
        }

        public InventoryLevelScheduledChangesQueryBuilder SetArguments(Action<InventoryLevelScheduledChangesArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public InventoryLevelScheduledChangesQueryBuilder Edges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryScheduledChangeEdgeQueryBuilder> build)
        {
            var query = new Query<InventoryScheduledChangeEdge>("edges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryScheduledChangeEdgeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryScheduledChangeEdge>(query);
            return this;
        }

        public InventoryLevelScheduledChangesQueryBuilder Nodes(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryScheduledChangeQueryBuilder> build)
        {
            var query = new Query<InventoryScheduledChange>("nodes");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryScheduledChangeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryScheduledChange>(query);
            return this;
        }

        public InventoryLevelScheduledChangesQueryBuilder PageInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder> build)
        {
            var query = new Query<PageInfo>("pageInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.PageInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PageInfo>(query);
            return this;
        }
    }
}