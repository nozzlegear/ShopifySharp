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
    public sealed class InventoryBulkToggleActivationOperationQueryBuilder : FieldsQueryBuilderBase<InventoryBulkToggleActivationPayload, InventoryBulkToggleActivationOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryBulkToggleActivationPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public InventoryBulkToggleActivationArgumentsBuilder Arguments { get; }
        protected override InventoryBulkToggleActivationOperationQueryBuilder Self => this;

        public InventoryBulkToggleActivationOperationQueryBuilder() : this("inventoryBulkToggleActivation")
        {
        }

        public InventoryBulkToggleActivationOperationQueryBuilder(string name) : base(new Query<InventoryBulkToggleActivationPayload>(name))
        {
            Arguments = new InventoryBulkToggleActivationArgumentsBuilder(base.InnerQuery);
        }

        public InventoryBulkToggleActivationOperationQueryBuilder(IQuery<InventoryBulkToggleActivationPayload> query) : base(query)
        {
            Arguments = new InventoryBulkToggleActivationArgumentsBuilder(base.InnerQuery);
        }

        public InventoryBulkToggleActivationOperationQueryBuilder InventoryItem(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemQueryBuilder> build)
        {
            var query = new Query<InventoryItem>("inventoryItem");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryItem>(query);
            return this;
        }

        public InventoryBulkToggleActivationOperationQueryBuilder InventoryLevels(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelQueryBuilder> build)
        {
            var query = new Query<InventoryLevel>("inventoryLevels");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryLevelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryLevel>(query);
            return this;
        }

        public InventoryBulkToggleActivationOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryBulkToggleActivationUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryBulkToggleActivationUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryBulkToggleActivationUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryBulkToggleActivationUserError>(query);
            return this;
        }
    }
}