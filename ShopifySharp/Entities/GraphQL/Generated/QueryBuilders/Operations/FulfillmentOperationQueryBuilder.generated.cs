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
    public sealed class FulfillmentOperationQueryBuilder : FieldsQueryBuilderBase<Fulfillment, FulfillmentOperationQueryBuilder>, IGraphOperationQueryBuilder<Fulfillment>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public FulfillmentArgumentsBuilder Arguments { get; }
        protected override FulfillmentOperationQueryBuilder Self => this;

        public FulfillmentOperationQueryBuilder() : this("fulfillment")
        {
        }

        public FulfillmentOperationQueryBuilder(string name) : base(new Query<Fulfillment>(name))
        {
            Arguments = new FulfillmentArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOperationQueryBuilder(IQuery<Fulfillment> query) : base(query)
        {
            Arguments = new FulfillmentArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public FulfillmentOperationQueryBuilder DeliveredAt()
        {
            base.InnerQuery.AddField("deliveredAt");
            return this;
        }

        public FulfillmentOperationQueryBuilder DisplayStatus()
        {
            base.InnerQuery.AddField("displayStatus");
            return this;
        }

        public FulfillmentOperationQueryBuilder EstimatedDeliveryAt()
        {
            base.InnerQuery.AddField("estimatedDeliveryAt");
            return this;
        }

        public FulfillmentOperationQueryBuilder Events(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentEventConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentEventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentEventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentEventConnection>(query);
            return this;
        }

        public FulfillmentOperationQueryBuilder FulfillmentLineItems(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentLineItemConnection>("fulfillmentLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentLineItemConnection>(query);
            return this;
        }

        public FulfillmentOperationQueryBuilder FulfillmentOrders(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderConnection>("fulfillmentOrders");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderConnection>(query);
            return this;
        }

        public FulfillmentOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public FulfillmentOperationQueryBuilder InTransitAt()
        {
            base.InnerQuery.AddField("inTransitAt");
            return this;
        }

        public FulfillmentOperationQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public FulfillmentOperationQueryBuilder Location(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public FulfillmentOperationQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public FulfillmentOperationQueryBuilder Order(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public FulfillmentOperationQueryBuilder OriginAddress(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOriginAddressQueryBuilder> build)
        {
            var query = new Query<FulfillmentOriginAddress>("originAddress");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOriginAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOriginAddress>(query);
            return this;
        }

        public FulfillmentOperationQueryBuilder RequiresShipping()
        {
            base.InnerQuery.AddField("requiresShipping");
            return this;
        }

        public FulfillmentOperationQueryBuilder Service(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentServiceQueryBuilder> build)
        {
            var query = new Query<FulfillmentService>("service");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentService>(query);
            return this;
        }

        public FulfillmentOperationQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public FulfillmentOperationQueryBuilder TotalQuantity()
        {
            base.InnerQuery.AddField("totalQuantity");
            return this;
        }

        public FulfillmentOperationQueryBuilder TrackingInfo(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentTrackingInfoQueryBuilder> build)
        {
            var query = new Query<FulfillmentTrackingInfo>("trackingInfo");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentTrackingInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentTrackingInfo>(query);
            return this;
        }

        public FulfillmentOperationQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}