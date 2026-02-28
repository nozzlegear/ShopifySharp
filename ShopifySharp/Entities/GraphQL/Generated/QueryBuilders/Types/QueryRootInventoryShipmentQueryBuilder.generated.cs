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
    public sealed class QueryRootInventoryShipmentQueryBuilder : FieldsQueryBuilderBase<InventoryShipment, QueryRootInventoryShipmentQueryBuilder>, IHasArguments<QueryRootInventoryShipmentArgumentsBuilder>
    {
        public QueryRootInventoryShipmentArgumentsBuilder Arguments { get; }
        protected override QueryRootInventoryShipmentQueryBuilder Self => this;

        public QueryRootInventoryShipmentQueryBuilder(string name) : base(new Query<InventoryShipment>(name))
        {
            Arguments = new QueryRootInventoryShipmentArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootInventoryShipmentQueryBuilder(IQuery<InventoryShipment> query) : base(query)
        {
            Arguments = new QueryRootInventoryShipmentArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootInventoryShipmentQueryBuilder SetArguments(Action<QueryRootInventoryShipmentArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootInventoryShipmentQueryBuilder DateCreated()
        {
            base.InnerQuery.AddField("dateCreated");
            return this;
        }

        public QueryRootInventoryShipmentQueryBuilder DateReceived()
        {
            base.InnerQuery.AddField("dateReceived");
            return this;
        }

        public QueryRootInventoryShipmentQueryBuilder DateShipped()
        {
            base.InnerQuery.AddField("dateShipped");
            return this;
        }

        public QueryRootInventoryShipmentQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootInventoryShipmentQueryBuilder LineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentLineItemConnection>("lineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentLineItemConnection>(query);
            return this;
        }

        public QueryRootInventoryShipmentQueryBuilder LineItemsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("lineItemsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public QueryRootInventoryShipmentQueryBuilder LineItemTotalQuantity()
        {
            base.InnerQuery.AddField("lineItemTotalQuantity");
            return this;
        }

        public QueryRootInventoryShipmentQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public QueryRootInventoryShipmentQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public QueryRootInventoryShipmentQueryBuilder TotalAcceptedQuantity()
        {
            base.InnerQuery.AddField("totalAcceptedQuantity");
            return this;
        }

        public QueryRootInventoryShipmentQueryBuilder TotalReceivedQuantity()
        {
            base.InnerQuery.AddField("totalReceivedQuantity");
            return this;
        }

        public QueryRootInventoryShipmentQueryBuilder TotalRejectedQuantity()
        {
            base.InnerQuery.AddField("totalRejectedQuantity");
            return this;
        }

        public QueryRootInventoryShipmentQueryBuilder Tracking(Action<ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentTrackingQueryBuilder> build)
        {
            var query = new Query<InventoryShipmentTracking>("tracking");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.InventoryShipmentTrackingQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<InventoryShipmentTracking>(query);
            return this;
        }
    }
}