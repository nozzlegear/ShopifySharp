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
    public sealed class InventorySetScheduledChangesPayloadQueryBuilder : FieldsQueryBuilderBase<InventorySetScheduledChangesPayload, InventorySetScheduledChangesPayloadQueryBuilder>
    {
        protected override InventorySetScheduledChangesPayloadQueryBuilder Self => this;

        public InventorySetScheduledChangesPayloadQueryBuilder() : this("inventorySetScheduledChangesPayload")
        {
        }

        public InventorySetScheduledChangesPayloadQueryBuilder(string name) : base(new Query<InventorySetScheduledChangesPayload>(name))
        {
        }

        public InventorySetScheduledChangesPayloadQueryBuilder(IQuery<InventorySetScheduledChangesPayload> query) : base(query)
        {
        }

        public InventorySetScheduledChangesPayloadQueryBuilder ScheduledChanges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryScheduledChangeQueryBuilder> build)
        {
            var query = new Query<InventoryScheduledChange>("scheduledChanges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryScheduledChangeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryScheduledChange>(query);
            return this;
        }

        public InventorySetScheduledChangesPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventorySetScheduledChangesUserErrorQueryBuilder> build)
        {
            var query = new Query<InventorySetScheduledChangesUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventorySetScheduledChangesUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventorySetScheduledChangesUserError>(query);
            return this;
        }
    }
}