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
    public sealed class InventoryTransferLineItemQueryBuilder : FieldsQueryBuilderBase<InventoryTransferLineItem, InventoryTransferLineItemQueryBuilder>
    {
        protected override InventoryTransferLineItemQueryBuilder Self => this;

        public InventoryTransferLineItemQueryBuilder() : this("inventoryTransferLineItem")
        {
        }

        public InventoryTransferLineItemQueryBuilder(string name) : base(new Query<InventoryTransferLineItem>(name))
        {
        }

        public InventoryTransferLineItemQueryBuilder(IQuery<InventoryTransferLineItem> query) : base(query)
        {
        }

        public InventoryTransferLineItemQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public InventoryTransferLineItemQueryBuilder InventoryItem(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryItemQueryBuilder> build)
        {
            var query = new Query<InventoryItem>("inventoryItem");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryItem>(query);
            return this;
        }

        public InventoryTransferLineItemQueryBuilder PickedForShipmentQuantity()
        {
            base.InnerQuery.AddField("pickedForShipmentQuantity");
            return this;
        }

        public InventoryTransferLineItemQueryBuilder ProcessableQuantity()
        {
            base.InnerQuery.AddField("processableQuantity");
            return this;
        }

        public InventoryTransferLineItemQueryBuilder ShippableQuantity()
        {
            base.InnerQuery.AddField("shippableQuantity");
            return this;
        }

        public InventoryTransferLineItemQueryBuilder ShippedQuantity()
        {
            base.InnerQuery.AddField("shippedQuantity");
            return this;
        }

        public InventoryTransferLineItemQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }

        public InventoryTransferLineItemQueryBuilder TotalQuantity()
        {
            base.InnerQuery.AddField("totalQuantity");
            return this;
        }
    }
}