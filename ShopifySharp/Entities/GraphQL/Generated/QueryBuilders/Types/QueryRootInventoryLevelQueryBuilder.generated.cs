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
    public sealed class QueryRootInventoryLevelQueryBuilder : FieldsQueryBuilderBase<InventoryLevel, QueryRootInventoryLevelQueryBuilder>, IHasArguments<QueryRootInventoryLevelArgumentsBuilder>
    {
        public QueryRootInventoryLevelArgumentsBuilder Arguments { get; }
        protected override QueryRootInventoryLevelQueryBuilder Self => this;

        public QueryRootInventoryLevelQueryBuilder(string name) : base(new Query<InventoryLevel>(name))
        {
            Arguments = new QueryRootInventoryLevelArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootInventoryLevelQueryBuilder(IQuery<InventoryLevel> query) : base(query)
        {
            Arguments = new QueryRootInventoryLevelArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootInventoryLevelQueryBuilder SetArguments(Action<QueryRootInventoryLevelArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootInventoryLevelQueryBuilder CanDeactivate()
        {
            base.InnerQuery.AddField("canDeactivate");
            return this;
        }

        public QueryRootInventoryLevelQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public QueryRootInventoryLevelQueryBuilder DeactivationAlert()
        {
            base.InnerQuery.AddField("deactivationAlert");
            return this;
        }

        public QueryRootInventoryLevelQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootInventoryLevelQueryBuilder Item(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemQueryBuilder> build)
        {
            var query = new Query<InventoryItem>("item");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryItem>(query);
            return this;
        }

        public QueryRootInventoryLevelQueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public QueryRootInventoryLevelQueryBuilder Quantities(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryQuantityQueryBuilder> build)
        {
            var query = new Query<InventoryQuantity>("quantities");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryQuantityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryQuantity>(query);
            return this;
        }

        public QueryRootInventoryLevelQueryBuilder ScheduledChanges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryScheduledChangeConnectionQueryBuilder> build)
        {
            var query = new Query<InventoryScheduledChangeConnection>("scheduledChanges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryScheduledChangeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryScheduledChangeConnection>(query);
            return this;
        }

        public QueryRootInventoryLevelQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}