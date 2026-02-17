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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class InventoryAdjustQuantitiesOperationQueryBuilder : FieldsQueryBuilderBase<InventoryAdjustQuantitiesPayload, InventoryAdjustQuantitiesOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryAdjustQuantitiesPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public InventoryAdjustQuantitiesArgumentsBuilder Arguments { get; }
        protected override InventoryAdjustQuantitiesOperationQueryBuilder Self => this;

        public InventoryAdjustQuantitiesOperationQueryBuilder() : this("inventoryAdjustQuantities")
        {
        }

        public InventoryAdjustQuantitiesOperationQueryBuilder(string name) : base(new Query<InventoryAdjustQuantitiesPayload>(name))
        {
            Arguments = new InventoryAdjustQuantitiesArgumentsBuilder(base.InnerQuery);
        }

        public InventoryAdjustQuantitiesOperationQueryBuilder(IQuery<InventoryAdjustQuantitiesPayload> query) : base(query)
        {
            Arguments = new InventoryAdjustQuantitiesArgumentsBuilder(base.InnerQuery);
        }

        public InventoryAdjustQuantitiesOperationQueryBuilder InventoryAdjustmentGroup(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryAdjustmentGroupQueryBuilder> build)
        {
            var query = new Query<InventoryAdjustmentGroup>("inventoryAdjustmentGroup");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryAdjustmentGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryAdjustmentGroup>(query);
            return this;
        }

        public InventoryAdjustQuantitiesOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryAdjustQuantitiesUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryAdjustQuantitiesUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryAdjustQuantitiesUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryAdjustQuantitiesUserError>(query);
            return this;
        }
    }
}