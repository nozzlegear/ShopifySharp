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
    public sealed class InventoryShipmentLineItemQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentLineItem, InventoryShipmentLineItemQueryBuilder>
    {
        protected override InventoryShipmentLineItemQueryBuilder Self => this;

        public InventoryShipmentLineItemQueryBuilder() : this("inventoryShipmentLineItem")
        {
        }

        public InventoryShipmentLineItemQueryBuilder(string name) : base(new Query<InventoryShipmentLineItem>(name))
        {
        }

        public InventoryShipmentLineItemQueryBuilder(IQuery<InventoryShipmentLineItem> query) : base(query)
        {
        }

        public InventoryShipmentLineItemQueryBuilder AcceptedQuantity()
        {
            base.InnerQuery.AddField("acceptedQuantity");
            return this;
        }

        public InventoryShipmentLineItemQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public InventoryShipmentLineItemQueryBuilder InventoryItem(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryItemQueryBuilder> build)
        {
            var query = new Query<InventoryItem>("inventoryItem");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryItemQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryItem>(query);
            return this;
        }

        public InventoryShipmentLineItemQueryBuilder Quantity()
        {
            base.InnerQuery.AddField("quantity");
            return this;
        }

        public InventoryShipmentLineItemQueryBuilder RejectedQuantity()
        {
            base.InnerQuery.AddField("rejectedQuantity");
            return this;
        }

        public InventoryShipmentLineItemQueryBuilder UnreceivedQuantity()
        {
            base.InnerQuery.AddField("unreceivedQuantity");
            return this;
        }
    }
}