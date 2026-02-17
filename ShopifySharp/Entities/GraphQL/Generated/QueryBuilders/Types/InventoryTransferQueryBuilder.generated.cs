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
    public sealed class InventoryTransferQueryBuilder : FieldsQueryBuilderBase<InventoryTransfer, InventoryTransferQueryBuilder>
    {
        protected override InventoryTransferQueryBuilder Self => this;

        public InventoryTransferQueryBuilder() : this("inventoryTransfer")
        {
        }

        public InventoryTransferQueryBuilder(string name) : base(new Query<InventoryTransfer>(name))
        {
        }

        public InventoryTransferQueryBuilder(IQuery<InventoryTransfer> query) : base(query)
        {
        }

        public InventoryTransferQueryBuilder DateCreated()
        {
            base.InnerQuery.AddField("dateCreated");
            return this;
        }

        public InventoryTransferQueryBuilder Destination(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationSnapshotQueryBuilder> build)
        {
            var query = new Query<LocationSnapshot>("destination");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationSnapshotQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationSnapshot>(query);
            return this;
        }

        public InventoryTransferQueryBuilder Events(Action<ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder> build)
        {
            var query = new Query<EventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.EventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<EventConnection>(query);
            return this;
        }

        public InventoryTransferQueryBuilder HasTimelineComment()
        {
            base.InnerQuery.AddField("hasTimelineComment");
            return this;
        }

        public InventoryTransferQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public InventoryTransferQueryBuilder LineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<InventoryTransferLineItemConnection>("lineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryTransferLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryTransferLineItemConnection>(query);
            return this;
        }

        public InventoryTransferQueryBuilder LineItemsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("lineItemsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public InventoryTransferQueryBuilder Metafield(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder> build)
        {
            var query = new Query<Metafield>("metafield");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Metafield>(query);
            return this;
        }

        public InventoryTransferQueryBuilder MetafieldDefinitions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldDefinitionConnection>("metafieldDefinitions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldDefinitionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldDefinitionConnection>(query);
            return this;
        }

        public InventoryTransferQueryBuilder Metafields(Action<ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder> build)
        {
            var query = new Query<MetafieldConnection>("metafields");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.MetafieldConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MetafieldConnection>(query);
            return this;
        }

        public InventoryTransferQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public InventoryTransferQueryBuilder Note()
        {
            base.InnerQuery.AddField("note");
            return this;
        }

        public InventoryTransferQueryBuilder Origin(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationSnapshotQueryBuilder> build)
        {
            var query = new Query<LocationSnapshot>("origin");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationSnapshotQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<LocationSnapshot>(query);
            return this;
        }

        public InventoryTransferQueryBuilder ReceivedQuantity()
        {
            base.InnerQuery.AddField("receivedQuantity");
            return this;
        }

        public InventoryTransferQueryBuilder ReferenceName()
        {
            base.InnerQuery.AddField("referenceName");
            return this;
        }

        public InventoryTransferQueryBuilder Shipments(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentConnectionQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentConnection>("shipments");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentConnection>(query);
            return this;
        }

        public InventoryTransferQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public InventoryTransferQueryBuilder Tags()
        {
            base.InnerQuery.AddField("tags");
            return this;
        }

        public InventoryTransferQueryBuilder TotalQuantity()
        {
            base.InnerQuery.AddField("totalQuantity");
            return this;
        }
    }
}