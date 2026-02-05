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
    public sealed class InventorySetQuantitiesOperationQueryBuilder : FieldsQueryBuilderBase<InventorySetQuantitiesPayload, InventorySetQuantitiesOperationQueryBuilder>, IGraphOperationQueryBuilder<InventorySetQuantitiesPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public InventorySetQuantitiesArgumentsBuilder Arguments { get; }
        protected override InventorySetQuantitiesOperationQueryBuilder Self => this;

        public InventorySetQuantitiesOperationQueryBuilder() : this("inventorySetQuantities")
        {
        }

        public InventorySetQuantitiesOperationQueryBuilder(string name) : base(new Query<InventorySetQuantitiesPayload>(name))
        {
            Arguments = new InventorySetQuantitiesArgumentsBuilder(base.InnerQuery);
        }

        public InventorySetQuantitiesOperationQueryBuilder(IQuery<InventorySetQuantitiesPayload> query) : base(query)
        {
            Arguments = new InventorySetQuantitiesArgumentsBuilder(base.InnerQuery);
        }

        public InventorySetQuantitiesOperationQueryBuilder InventoryAdjustmentGroup(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryAdjustmentGroupQueryBuilder> build)
        {
            var query = new Query<InventoryAdjustmentGroup>("inventoryAdjustmentGroup");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryAdjustmentGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryAdjustmentGroup>(query);
            return this;
        }

        public InventorySetQuantitiesOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventorySetQuantitiesUserErrorQueryBuilder> build)
        {
            var query = new Query<InventorySetQuantitiesUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventorySetQuantitiesUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventorySetQuantitiesUserError>(query);
            return this;
        }
    }
}