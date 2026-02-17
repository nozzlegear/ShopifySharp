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
    public sealed class InventoryTransferSetItemsOperationQueryBuilder : FieldsQueryBuilderBase<InventoryTransferSetItemsPayload, InventoryTransferSetItemsOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryTransferSetItemsPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public InventoryTransferSetItemsArgumentsBuilder Arguments { get; }
        protected override InventoryTransferSetItemsOperationQueryBuilder Self => this;

        public InventoryTransferSetItemsOperationQueryBuilder() : this("inventoryTransferSetItems")
        {
        }

        public InventoryTransferSetItemsOperationQueryBuilder(string name) : base(new Query<InventoryTransferSetItemsPayload>(name))
        {
            Arguments = new InventoryTransferSetItemsArgumentsBuilder(base.InnerQuery);
        }

        public InventoryTransferSetItemsOperationQueryBuilder(IQuery<InventoryTransferSetItemsPayload> query) : base(query)
        {
            Arguments = new InventoryTransferSetItemsArgumentsBuilder(base.InnerQuery);
        }

        public InventoryTransferSetItemsOperationQueryBuilder InventoryTransfer(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferQueryBuilder> build)
        {
            var query = new Query<InventoryTransfer>("inventoryTransfer");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransfer>(query);
            return this;
        }

        public InventoryTransferSetItemsOperationQueryBuilder UpdatedLineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferLineItemUpdateQueryBuilder> build)
        {
            var query = new Query<InventoryTransferLineItemUpdate>("updatedLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferLineItemUpdateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferLineItemUpdate>(query);
            return this;
        }

        public InventoryTransferSetItemsOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferSetItemsUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryTransferSetItemsUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferSetItemsUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferSetItemsUserError>(query);
            return this;
        }
    }
}