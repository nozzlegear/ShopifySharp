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
    public sealed class InventoryShipmentTrackingQueryBuilder : FieldsQueryBuilderBase<InventoryShipmentTracking, InventoryShipmentTrackingQueryBuilder>
    {
        protected override InventoryShipmentTrackingQueryBuilder Self => this;

        public InventoryShipmentTrackingQueryBuilder() : this("inventoryShipmentTracking")
        {
        }

        public InventoryShipmentTrackingQueryBuilder(string name) : base(new Query<InventoryShipmentTracking>(name))
        {
        }

        public InventoryShipmentTrackingQueryBuilder(IQuery<InventoryShipmentTracking> query) : base(query)
        {
        }

        public InventoryShipmentTrackingQueryBuilder ArrivesAt()
        {
            base.InnerQuery.AddField("arrivesAt");
            return this;
        }

        public InventoryShipmentTrackingQueryBuilder Company()
        {
            base.InnerQuery.AddField("company");
            return this;
        }

        public InventoryShipmentTrackingQueryBuilder TrackingNumber()
        {
            base.InnerQuery.AddField("trackingNumber");
            return this;
        }

        public InventoryShipmentTrackingQueryBuilder TrackingUrl()
        {
            base.InnerQuery.AddField("trackingUrl");
            return this;
        }
    }
}