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

namespace ShopifySharp.GraphQL.QueryBuilders.Types
{
    public sealed class InventoryTransferLineItemUpdateQueryBuilder : FieldsQueryBuilderBase<InventoryTransferLineItemUpdate, InventoryTransferLineItemUpdateQueryBuilder>
    {
        protected override InventoryTransferLineItemUpdateQueryBuilder Self => this;

        public InventoryTransferLineItemUpdateQueryBuilder() : this("inventoryTransferLineItemUpdate")
        {
        }

        public InventoryTransferLineItemUpdateQueryBuilder(string name) : base(new Query<InventoryTransferLineItemUpdate>(name))
        {
        }

        public InventoryTransferLineItemUpdateQueryBuilder(IQuery<InventoryTransferLineItemUpdate> query) : base(query)
        {
        }

        public InventoryTransferLineItemUpdateQueryBuilder DeltaQuantity()
        {
            base.InnerQuery.AddField("deltaQuantity");
            return this;
        }

        public InventoryTransferLineItemUpdateQueryBuilder InventoryItemId()
        {
            base.InnerQuery.AddField("inventoryItemId");
            return this;
        }

        public InventoryTransferLineItemUpdateQueryBuilder NewQuantity()
        {
            base.InnerQuery.AddField("newQuantity");
            return this;
        }
    }
}