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
    public sealed class InventoryMoveQuantitiesOperationQueryBuilder : FieldsQueryBuilderBase<InventoryMoveQuantitiesPayload, InventoryMoveQuantitiesOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryMoveQuantitiesPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public InventoryMoveQuantitiesArgumentsBuilder Arguments { get; }
        protected override InventoryMoveQuantitiesOperationQueryBuilder Self => this;

        public InventoryMoveQuantitiesOperationQueryBuilder() : this("inventoryMoveQuantities")
        {
        }

        public InventoryMoveQuantitiesOperationQueryBuilder(string name) : base(new Query<InventoryMoveQuantitiesPayload>(name))
        {
            Arguments = new InventoryMoveQuantitiesArgumentsBuilder(base.InnerQuery);
        }

        public InventoryMoveQuantitiesOperationQueryBuilder(IQuery<InventoryMoveQuantitiesPayload> query) : base(query)
        {
            Arguments = new InventoryMoveQuantitiesArgumentsBuilder(base.InnerQuery);
        }

        public InventoryMoveQuantitiesOperationQueryBuilder InventoryAdjustmentGroup(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryAdjustmentGroupQueryBuilder> build)
        {
            var query = new Query<InventoryAdjustmentGroup>("inventoryAdjustmentGroup");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryAdjustmentGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryAdjustmentGroup>(query);
            return this;
        }

        public InventoryMoveQuantitiesOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryMoveQuantitiesUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryMoveQuantitiesUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryMoveQuantitiesUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryMoveQuantitiesUserError>(query);
            return this;
        }
    }
}