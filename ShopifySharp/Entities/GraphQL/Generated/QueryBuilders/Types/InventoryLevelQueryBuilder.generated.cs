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
    public sealed class InventoryLevelQueryBuilder : FieldsQueryBuilderBase<InventoryLevel, InventoryLevelQueryBuilder>
    {
        protected override InventoryLevelQueryBuilder Self => this;

        public InventoryLevelQueryBuilder() : this("inventoryLevel")
        {
        }

        public InventoryLevelQueryBuilder(string name) : base(new Query<InventoryLevel>(name))
        {
        }

        public InventoryLevelQueryBuilder(IQuery<InventoryLevel> query) : base(query)
        {
        }

        public InventoryLevelQueryBuilder CanDeactivate()
        {
            base.InnerQuery.AddField("canDeactivate");
            return this;
        }

        public InventoryLevelQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public InventoryLevelQueryBuilder DeactivationAlert()
        {
            base.InnerQuery.AddField("deactivationAlert");
            return this;
        }

        public InventoryLevelQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public InventoryLevelQueryBuilder Item(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemQueryBuilder> build)
        {
            var query = new Query<InventoryItem>("item");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryItem>(query);
            return this;
        }

        public InventoryLevelQueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public InventoryLevelQueryBuilder Quantities(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryQuantityQueryBuilder> build)
        {
            var query = new Query<InventoryQuantity>("quantities");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryQuantityQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryQuantity>(query);
            return this;
        }

        public InventoryLevelQueryBuilder ScheduledChanges(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryScheduledChangeConnectionQueryBuilder> build)
        {
            var query = new Query<InventoryScheduledChangeConnection>("scheduledChanges");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryScheduledChangeConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryScheduledChangeConnection>(query);
            return this;
        }

        public InventoryLevelQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}