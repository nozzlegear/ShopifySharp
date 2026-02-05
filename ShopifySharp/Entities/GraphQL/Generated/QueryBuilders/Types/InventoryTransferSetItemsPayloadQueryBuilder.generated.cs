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
    public sealed class InventoryTransferSetItemsPayloadQueryBuilder : FieldsQueryBuilderBase<InventoryTransferSetItemsPayload, InventoryTransferSetItemsPayloadQueryBuilder>
    {
        protected override InventoryTransferSetItemsPayloadQueryBuilder Self => this;

        public InventoryTransferSetItemsPayloadQueryBuilder() : this("inventoryTransferSetItemsPayload")
        {
        }

        public InventoryTransferSetItemsPayloadQueryBuilder(string name) : base(new Query<InventoryTransferSetItemsPayload>(name))
        {
        }

        public InventoryTransferSetItemsPayloadQueryBuilder(IQuery<InventoryTransferSetItemsPayload> query) : base(query)
        {
        }

        public InventoryTransferSetItemsPayloadQueryBuilder InventoryTransfer(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder> build)
        {
            var query = new Query<InventoryTransfer>("inventoryTransfer");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransfer>(query);
            return this;
        }

        public InventoryTransferSetItemsPayloadQueryBuilder UpdatedLineItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferLineItemUpdateQueryBuilder> build)
        {
            var query = new Query<InventoryTransferLineItemUpdate>("updatedLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferLineItemUpdateQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferLineItemUpdate>(query);
            return this;
        }

        public InventoryTransferSetItemsPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferSetItemsUserErrorQueryBuilder> build)
        {
            var query = new Query<InventoryTransferSetItemsUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryTransferSetItemsUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferSetItemsUserError>(query);
            return this;
        }
    }
}