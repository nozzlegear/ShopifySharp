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
    [Obsolete("Scheduled changes will be phased out in a future version.")]
    public sealed class InventorySetScheduledChangesOperationQueryBuilder : FieldsQueryBuilderBase<InventorySetScheduledChangesPayload, InventorySetScheduledChangesOperationQueryBuilder>, IGraphOperationQueryBuilder<InventorySetScheduledChangesPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public InventorySetScheduledChangesArgumentsBuilder Arguments { get; }
        protected override InventorySetScheduledChangesOperationQueryBuilder Self => this;

        public InventorySetScheduledChangesOperationQueryBuilder() : this("inventorySetScheduledChanges")
        {
        }

        public InventorySetScheduledChangesOperationQueryBuilder(string name) : base(new Query<InventorySetScheduledChangesPayload>(name))
        {
            Arguments = new InventorySetScheduledChangesArgumentsBuilder(base.InnerQuery);
        }

        public InventorySetScheduledChangesOperationQueryBuilder(IQuery<InventorySetScheduledChangesPayload> query) : base(query)
        {
            Arguments = new InventorySetScheduledChangesArgumentsBuilder(base.InnerQuery);
        }

        public InventorySetScheduledChangesOperationQueryBuilder ScheduledChanges(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryScheduledChangeQueryBuilder> build)
        {
            var query = new Query<InventoryScheduledChange>("scheduledChanges");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryScheduledChangeQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryScheduledChange>(query);
            return this;
        }

        public InventorySetScheduledChangesOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventorySetScheduledChangesUserErrorQueryBuilder> build)
        {
            var query = new Query<InventorySetScheduledChangesUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventorySetScheduledChangesUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventorySetScheduledChangesUserError>(query);
            return this;
        }
    }
}