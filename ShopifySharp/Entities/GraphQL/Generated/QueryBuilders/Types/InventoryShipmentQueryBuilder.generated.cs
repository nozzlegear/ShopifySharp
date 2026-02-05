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
    public sealed class InventoryShipmentQueryBuilder : FieldsQueryBuilderBase<InventoryShipment, InventoryShipmentQueryBuilder>
    {
        protected override InventoryShipmentQueryBuilder Self => this;

        public InventoryShipmentQueryBuilder() : this("inventoryShipment")
        {
        }

        public InventoryShipmentQueryBuilder(string name) : base(new Query<InventoryShipment>(name))
        {
        }

        public InventoryShipmentQueryBuilder(IQuery<InventoryShipment> query) : base(query)
        {
        }

        public InventoryShipmentQueryBuilder DateCreated()
        {
            base.InnerQuery.AddField("dateCreated");
            return this;
        }

        public InventoryShipmentQueryBuilder DateReceived()
        {
            base.InnerQuery.AddField("dateReceived");
            return this;
        }

        public InventoryShipmentQueryBuilder DateShipped()
        {
            base.InnerQuery.AddField("dateShipped");
            return this;
        }

        public InventoryShipmentQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public InventoryShipmentQueryBuilder LineItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentLineItemConnection>("lineItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentLineItemConnection>(query);
            return this;
        }

        public InventoryShipmentQueryBuilder LineItemsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("lineItemsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public InventoryShipmentQueryBuilder LineItemTotalQuantity()
        {
            base.InnerQuery.AddField("lineItemTotalQuantity");
            return this;
        }

        public InventoryShipmentQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public InventoryShipmentQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public InventoryShipmentQueryBuilder TotalAcceptedQuantity()
        {
            base.InnerQuery.AddField("totalAcceptedQuantity");
            return this;
        }

        public InventoryShipmentQueryBuilder TotalReceivedQuantity()
        {
            base.InnerQuery.AddField("totalReceivedQuantity");
            return this;
        }

        public InventoryShipmentQueryBuilder TotalRejectedQuantity()
        {
            base.InnerQuery.AddField("totalRejectedQuantity");
            return this;
        }

        public InventoryShipmentQueryBuilder Tracking(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentTrackingQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentTracking>("tracking");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentTrackingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentTracking>(query);
            return this;
        }
    }
}