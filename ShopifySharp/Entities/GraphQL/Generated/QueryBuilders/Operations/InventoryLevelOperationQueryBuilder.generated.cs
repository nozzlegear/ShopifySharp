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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class InventoryLevelOperationQueryBuilder : FieldsQueryBuilderBase<InventoryLevel, InventoryLevelOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryLevel>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public InventoryLevelArgumentsBuilder Arguments { get; }
        protected override InventoryLevelOperationQueryBuilder Self => this;

        public InventoryLevelOperationQueryBuilder() : this("inventoryLevel")
        {
        }

        public InventoryLevelOperationQueryBuilder(string name) : base(new Query<InventoryLevel>(name))
        {
            Arguments = new InventoryLevelArgumentsBuilder(base.InnerQuery);
        }

        public InventoryLevelOperationQueryBuilder(IQuery<InventoryLevel> query) : base(query)
        {
            Arguments = new InventoryLevelArgumentsBuilder(base.InnerQuery);
        }

        public InventoryLevelOperationQueryBuilder CanDeactivate()
        {
            base.InnerQuery.AddField("canDeactivate");
            return this;
        }

        public InventoryLevelOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public InventoryLevelOperationQueryBuilder DeactivationAlert()
        {
            base.InnerQuery.AddField("deactivationAlert");
            return this;
        }

        public InventoryLevelOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public InventoryLevelOperationQueryBuilder Item(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryItemQueryBuilder> build)
        {
            var query = new Query<InventoryItem>("item");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryItem>(query);
            return this;
        }

        public InventoryLevelOperationQueryBuilder Location(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public InventoryLevelOperationQueryBuilder Quantities(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryQuantityQueryBuilder> build)
        {
            var query = new Query<InventoryQuantity>("quantities");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryQuantityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryQuantity>(query);
            return this;
        }

        public InventoryLevelOperationQueryBuilder ScheduledChanges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryScheduledChangeConnectionQueryBuilder> build)
        {
            var query = new Query<InventoryScheduledChangeConnection>("scheduledChanges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryScheduledChangeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryScheduledChangeConnection>(query);
            return this;
        }

        public InventoryLevelOperationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}