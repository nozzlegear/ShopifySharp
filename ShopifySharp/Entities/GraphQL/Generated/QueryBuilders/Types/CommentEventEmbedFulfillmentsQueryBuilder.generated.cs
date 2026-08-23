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
    public sealed class CommentEventEmbedFulfillmentsQueryBuilder : FieldsQueryBuilderBase<Fulfillment, CommentEventEmbedFulfillmentsQueryBuilder>, IHasArguments<CommentEventEmbedFulfillmentsArgumentsBuilder>
    {
        public CommentEventEmbedFulfillmentsArgumentsBuilder Arguments { get; }
        protected override CommentEventEmbedFulfillmentsQueryBuilder Self => this;

        public CommentEventEmbedFulfillmentsQueryBuilder(string name) : base(new Query<Fulfillment>(name))
        {
            Arguments = new CommentEventEmbedFulfillmentsArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedFulfillmentsQueryBuilder(IQuery<Fulfillment> query) : base(query)
        {
            Arguments = new CommentEventEmbedFulfillmentsArgumentsBuilder(base.InnerQuery);
        }

        public CommentEventEmbedFulfillmentsQueryBuilder SetArguments(Action<CommentEventEmbedFulfillmentsArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public CommentEventEmbedFulfillmentsQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public CommentEventEmbedFulfillmentsQueryBuilder DeliveredAt()
        {
            base.InnerQuery.AddField("deliveredAt");
            return this;
        }

        public CommentEventEmbedFulfillmentsQueryBuilder DisplayStatus()
        {
            base.InnerQuery.AddField("displayStatus");
            return this;
        }

        public CommentEventEmbedFulfillmentsQueryBuilder EstimatedDeliveryAt()
        {
            base.InnerQuery.AddField("estimatedDeliveryAt");
            return this;
        }

        public CommentEventEmbedFulfillmentsQueryBuilder Events(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentEventConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentEventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentEventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentEventConnection>(query);
            return this;
        }

        public CommentEventEmbedFulfillmentsQueryBuilder FulfillmentLineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentLineItemConnection>("fulfillmentLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentLineItemConnection>(query);
            return this;
        }

        public CommentEventEmbedFulfillmentsQueryBuilder FulfillmentOrders(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderConnection>("fulfillmentOrders");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderConnection>(query);
            return this;
        }

        public CommentEventEmbedFulfillmentsQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public CommentEventEmbedFulfillmentsQueryBuilder InTransitAt()
        {
            base.InnerQuery.AddField("inTransitAt");
            return this;
        }

        public CommentEventEmbedFulfillmentsQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public CommentEventEmbedFulfillmentsQueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public CommentEventEmbedFulfillmentsQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public CommentEventEmbedFulfillmentsQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public CommentEventEmbedFulfillmentsQueryBuilder OriginAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOriginAddressQueryBuilder> build)
        {
            var query = new Query<FulfillmentOriginAddress>("originAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOriginAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOriginAddress>(query);
            return this;
        }

        public CommentEventEmbedFulfillmentsQueryBuilder RequiresShipping()
        {
            base.InnerQuery.AddField("requiresShipping");
            return this;
        }

        public CommentEventEmbedFulfillmentsQueryBuilder Service(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentServiceQueryBuilder> build)
        {
            var query = new Query<FulfillmentService>("service");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentService>(query);
            return this;
        }

        public CommentEventEmbedFulfillmentsQueryBuilder ShippingLabel(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLabelQueryBuilder> build)
        {
            var query = new Query<ShippingLabel>("shippingLabel");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ShippingLabelQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ShippingLabel>(query);
            return this;
        }

        public CommentEventEmbedFulfillmentsQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public CommentEventEmbedFulfillmentsQueryBuilder TotalQuantity()
        {
            base.InnerQuery.AddField("totalQuantity");
            return this;
        }

        public CommentEventEmbedFulfillmentsQueryBuilder TrackingInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentTrackingInfoQueryBuilder> build)
        {
            var query = new Query<FulfillmentTrackingInfo>("trackingInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentTrackingInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentTrackingInfo>(query);
            return this;
        }

        public CommentEventEmbedFulfillmentsQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}