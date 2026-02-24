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
    public sealed class MetafieldReferenceFulfillmentsQueryBuilder : FieldsQueryBuilderBase<Fulfillment, MetafieldReferenceFulfillmentsQueryBuilder>, IHasArguments<MetafieldReferenceFulfillmentsArgumentsBuilder>
    {
        public MetafieldReferenceFulfillmentsArgumentsBuilder Arguments { get; }
        protected override MetafieldReferenceFulfillmentsQueryBuilder Self => this;

        public MetafieldReferenceFulfillmentsQueryBuilder(string name) : base(new Query<Fulfillment>(name))
        {
            Arguments = new MetafieldReferenceFulfillmentsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceFulfillmentsQueryBuilder(IQuery<Fulfillment> query) : base(query)
        {
            Arguments = new MetafieldReferenceFulfillmentsArgumentsBuilder(base.InnerQuery);
        }

        public MetafieldReferenceFulfillmentsQueryBuilder SetArguments(Action<MetafieldReferenceFulfillmentsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public MetafieldReferenceFulfillmentsQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public MetafieldReferenceFulfillmentsQueryBuilder DeliveredAt()
        {
            base.InnerQuery.AddField("deliveredAt");
            return this;
        }

        public MetafieldReferenceFulfillmentsQueryBuilder DisplayStatus()
        {
            base.InnerQuery.AddField("displayStatus");
            return this;
        }

        public MetafieldReferenceFulfillmentsQueryBuilder EstimatedDeliveryAt()
        {
            base.InnerQuery.AddField("estimatedDeliveryAt");
            return this;
        }

        public MetafieldReferenceFulfillmentsQueryBuilder Events(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentEventConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentEventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentEventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentEventConnection>(query);
            return this;
        }

        public MetafieldReferenceFulfillmentsQueryBuilder FulfillmentLineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentLineItemConnection>("fulfillmentLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentLineItemConnection>(query);
            return this;
        }

        public MetafieldReferenceFulfillmentsQueryBuilder FulfillmentOrders(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderConnection>("fulfillmentOrders");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderConnection>(query);
            return this;
        }

        public MetafieldReferenceFulfillmentsQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public MetafieldReferenceFulfillmentsQueryBuilder InTransitAt()
        {
            base.InnerQuery.AddField("inTransitAt");
            return this;
        }

        public MetafieldReferenceFulfillmentsQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public MetafieldReferenceFulfillmentsQueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public MetafieldReferenceFulfillmentsQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public MetafieldReferenceFulfillmentsQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public MetafieldReferenceFulfillmentsQueryBuilder OriginAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOriginAddressQueryBuilder> build)
        {
            var query = new Query<FulfillmentOriginAddress>("originAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOriginAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOriginAddress>(query);
            return this;
        }

        public MetafieldReferenceFulfillmentsQueryBuilder RequiresShipping()
        {
            base.InnerQuery.AddField("requiresShipping");
            return this;
        }

        public MetafieldReferenceFulfillmentsQueryBuilder Service(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentServiceQueryBuilder> build)
        {
            var query = new Query<FulfillmentService>("service");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentService>(query);
            return this;
        }

        public MetafieldReferenceFulfillmentsQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public MetafieldReferenceFulfillmentsQueryBuilder TotalQuantity()
        {
            base.InnerQuery.AddField("totalQuantity");
            return this;
        }

        public MetafieldReferenceFulfillmentsQueryBuilder TrackingInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentTrackingInfoQueryBuilder> build)
        {
            var query = new Query<FulfillmentTrackingInfo>("trackingInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentTrackingInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentTrackingInfo>(query);
            return this;
        }

        public MetafieldReferenceFulfillmentsQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}