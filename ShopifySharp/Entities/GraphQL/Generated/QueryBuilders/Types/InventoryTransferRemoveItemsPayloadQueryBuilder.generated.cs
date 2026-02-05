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
    public sealed class InventoryTransferRemoveItemsPayloadQueryBuilder : FieldsQueryBuilderBase<InventoryTransferRemoveItemsPayload, InventoryTransferRemoveItemsPayloadQueryBuilder>
    {
        protected override InventoryTransferRemoveItemsPayloadQueryBuilder Self => this;

        public InventoryTransferRemoveItemsPayloadQueryBuilder() : this("inventoryTransferRemoveItemsPayload")
        {
        }

        public InventoryTransferRemoveItemsPayloadQueryBuilder(string name) : base(new Query<InventoryTransferRemoveItemsPayload>(name))
        {
        }

        public InventoryTransferRemoveItemsPayloadQueryBuilder(IQuery<InventoryTransferRemoveItemsPayload> query) : base(query)
        {
        }

        public InventoryTransferRemoveItemsPayloadQueryBuilder InventoryTransfer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder> build)
        {
            var query = new Query<InventoryTransfer>("inventoryTransfer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransfer>(query);
            return this;
        }

        public InventoryTransferRemoveItemsPayloadQueryBuilder RemovedQuantities(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferLineItemUpdateQueryBuilder> build)
        {
            var query = new Query<InventoryTransferLineItemUpdate>("removedQuantities");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferLineItemUpdateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferLineItemUpdate>(query);
            return this;
        }

        public InventoryTransferRemoveItemsPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferRemoveItemsUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryTransferRemoveItemsUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferRemoveItemsUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferRemoveItemsUserError>(query);
            return this;
        }
    }
}