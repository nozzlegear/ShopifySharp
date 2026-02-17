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
    [Obsolete("Use `inventorySetQuantities` to set on_hand or available quantites instead.")]
    public sealed class InventorySetOnHandQuantitiesOperationQueryBuilder : FieldsQueryBuilderBase<InventorySetOnHandQuantitiesPayload, InventorySetOnHandQuantitiesOperationQueryBuilder>, IGraphOperationQueryBuilder<InventorySetOnHandQuantitiesPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public InventorySetOnHandQuantitiesArgumentsBuilder Arguments { get; }
        protected override InventorySetOnHandQuantitiesOperationQueryBuilder Self => this;

        public InventorySetOnHandQuantitiesOperationQueryBuilder() : this("inventorySetOnHandQuantities")
        {
        }

        public InventorySetOnHandQuantitiesOperationQueryBuilder(string name) : base(new Query<InventorySetOnHandQuantitiesPayload>(name))
        {
            Arguments = new InventorySetOnHandQuantitiesArgumentsBuilder(base.InnerQuery);
        }

        public InventorySetOnHandQuantitiesOperationQueryBuilder(IQuery<InventorySetOnHandQuantitiesPayload> query) : base(query)
        {
            Arguments = new InventorySetOnHandQuantitiesArgumentsBuilder(base.InnerQuery);
        }

        public InventorySetOnHandQuantitiesOperationQueryBuilder InventoryAdjustmentGroup(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryAdjustmentGroupQueryBuilder> build)
        {
            var query = new Query<InventoryAdjustmentGroup>("inventoryAdjustmentGroup");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryAdjustmentGroupQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryAdjustmentGroup>(query);
            return this;
        }

        public InventorySetOnHandQuantitiesOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventorySetOnHandQuantitiesUserErrorQueryBuilder> build)
        {
            var query = new Query<InventorySetOnHandQuantitiesUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventorySetOnHandQuantitiesUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventorySetOnHandQuantitiesUserError>(query);
            return this;
        }
    }
}