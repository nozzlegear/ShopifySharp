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
    public sealed class InventoryShipmentOperationQueryBuilder : FieldsQueryBuilderBase<InventoryShipment, InventoryShipmentOperationQueryBuilder>, IGraphOperationQueryBuilder<InventoryShipment>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public InventoryShipmentArgumentsBuilder Arguments { get; }
        protected override InventoryShipmentOperationQueryBuilder Self => this;

        public InventoryShipmentOperationQueryBuilder() : this("inventoryShipment")
        {
        }

        public InventoryShipmentOperationQueryBuilder(string name) : base(new Query<InventoryShipment>(name))
        {
            Arguments = new InventoryShipmentArgumentsBuilder(base.InnerQuery);
        }

        public InventoryShipmentOperationQueryBuilder(IQuery<InventoryShipment> query) : base(query)
        {
            Arguments = new InventoryShipmentArgumentsBuilder(base.InnerQuery);
        }

        public InventoryShipmentOperationQueryBuilder DateCreated()
        {
            base.InnerQuery.AddField("dateCreated");
            return this;
        }

        public InventoryShipmentOperationQueryBuilder DateReceived()
        {
            base.InnerQuery.AddField("dateReceived");
            return this;
        }

        public InventoryShipmentOperationQueryBuilder DateShipped()
        {
            base.InnerQuery.AddField("dateShipped");
            return this;
        }

        public InventoryShipmentOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public InventoryShipmentOperationQueryBuilder LineItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentLineItemConnection>("lineItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentLineItemConnection>(query);
            return this;
        }

        public InventoryShipmentOperationQueryBuilder LineItemsCount(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("lineItemsCount");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public InventoryShipmentOperationQueryBuilder LineItemTotalQuantity()
        {
            base.InnerQuery.AddField("lineItemTotalQuantity");
            return this;
        }

        public InventoryShipmentOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public InventoryShipmentOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public InventoryShipmentOperationQueryBuilder TotalAcceptedQuantity()
        {
            base.InnerQuery.AddField("totalAcceptedQuantity");
            return this;
        }

        public InventoryShipmentOperationQueryBuilder TotalReceivedQuantity()
        {
            base.InnerQuery.AddField("totalReceivedQuantity");
            return this;
        }

        public InventoryShipmentOperationQueryBuilder TotalRejectedQuantity()
        {
            base.InnerQuery.AddField("totalRejectedQuantity");
            return this;
        }

        public InventoryShipmentOperationQueryBuilder Tracking(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentTrackingQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentTracking>("tracking");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.InventoryShipmentTrackingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentTracking>(query);
            return this;
        }
    }
}