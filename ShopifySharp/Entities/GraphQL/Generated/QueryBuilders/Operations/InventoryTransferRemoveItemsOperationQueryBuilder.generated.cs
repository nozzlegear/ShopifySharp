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
    public sealed class InventoryTransferRemoveItemsOperationQueryBuilder : FieldsQueryBuilderBase<InventoryTransferRemoveItemsPayload, InventoryTransferRemoveItemsOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryTransferRemoveItemsPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public InventoryTransferRemoveItemsArgumentsBuilder Arguments { get; }
        protected override InventoryTransferRemoveItemsOperationQueryBuilder Self => this;

        public InventoryTransferRemoveItemsOperationQueryBuilder() : this("inventoryTransferRemoveItems")
        {
        }

        public InventoryTransferRemoveItemsOperationQueryBuilder(string name) : base(new Query<InventoryTransferRemoveItemsPayload>(name))
        {
            Arguments = new InventoryTransferRemoveItemsArgumentsBuilder(base.InnerQuery);
        }

        public InventoryTransferRemoveItemsOperationQueryBuilder(IQuery<InventoryTransferRemoveItemsPayload> query) : base(query)
        {
            Arguments = new InventoryTransferRemoveItemsArgumentsBuilder(base.InnerQuery);
        }

        public InventoryTransferRemoveItemsOperationQueryBuilder InventoryTransfer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder> build)
        {
            var query = new Query<InventoryTransfer>("inventoryTransfer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransfer>(query);
            return this;
        }

        public InventoryTransferRemoveItemsOperationQueryBuilder RemovedQuantities(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferLineItemUpdateQueryBuilder> build)
        {
            var query = new Query<InventoryTransferLineItemUpdate>("removedQuantities");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferLineItemUpdateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferLineItemUpdate>(query);
            return this;
        }

        public InventoryTransferRemoveItemsOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferRemoveItemsUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryTransferRemoveItemsUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferRemoveItemsUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferRemoveItemsUserError>(query);
            return this;
        }
    }
}