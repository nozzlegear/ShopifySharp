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
    public sealed class QueryRootFulfillmentOrderQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrder, QueryRootFulfillmentOrderQueryBuilder>, IHasArguments<QueryRootFulfillmentOrderArgumentsBuilder>
    {
        public QueryRootFulfillmentOrderArgumentsBuilder Arguments { get; }
        protected override QueryRootFulfillmentOrderQueryBuilder Self => this;

        public QueryRootFulfillmentOrderQueryBuilder(string name) : base(new Query<FulfillmentOrder>(name))
        {
            Arguments = new QueryRootFulfillmentOrderArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootFulfillmentOrderQueryBuilder(IQuery<FulfillmentOrder> query) : base(query)
        {
            Arguments = new QueryRootFulfillmentOrderArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootFulfillmentOrderQueryBuilder SetArguments(Action<QueryRootFulfillmentOrderArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootFulfillmentOrderQueryBuilder AssignedLocation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderAssignedLocationQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderAssignedLocation>("assignedLocation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderAssignedLocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderAssignedLocation>(query);
            return this;
        }

        public QueryRootFulfillmentOrderQueryBuilder ChannelId()
        {
            base.InnerQuery.AddField("channelId");
            return this;
        }

        public QueryRootFulfillmentOrderQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public QueryRootFulfillmentOrderQueryBuilder DeliveryMethod(Action<ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryMethodQueryBuilder> build)
        {
            var query = new Query<DeliveryMethod>("deliveryMethod");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.DeliveryMethodQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<DeliveryMethod>(query);
            return this;
        }

        public QueryRootFulfillmentOrderQueryBuilder Destination(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderDestinationQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderDestination>("destination");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderDestinationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderDestination>(query);
            return this;
        }

        public QueryRootFulfillmentOrderQueryBuilder FulfillAt()
        {
            base.InnerQuery.AddField("fulfillAt");
            return this;
        }

        public QueryRootFulfillmentOrderQueryBuilder FulfillBy()
        {
            base.InnerQuery.AddField("fulfillBy");
            return this;
        }

        public QueryRootFulfillmentOrderQueryBuilder FulfillmentHolds(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentHoldQueryBuilder> build)
        {
            var query = new Query<FulfillmentHold>("fulfillmentHolds");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentHoldQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentHold>(query);
            return this;
        }

        public QueryRootFulfillmentOrderQueryBuilder FulfillmentOrdersForMerge(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderConnection>("fulfillmentOrdersForMerge");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderConnection>(query);
            return this;
        }

        public QueryRootFulfillmentOrderQueryBuilder Fulfillments(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentConnection>("fulfillments");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentConnection>(query);
            return this;
        }

        public QueryRootFulfillmentOrderQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootFulfillmentOrderQueryBuilder InternationalDuties(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderInternationalDutiesQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderInternationalDuties>("internationalDuties");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderInternationalDutiesQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderInternationalDuties>(query);
            return this;
        }

        public QueryRootFulfillmentOrderQueryBuilder LineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderLineItemConnection>("lineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderLineItemConnection>(query);
            return this;
        }

        public QueryRootFulfillmentOrderQueryBuilder LocationsForMove(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderLocationForMoveConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderLocationForMoveConnection>("locationsForMove");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderLocationForMoveConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderLocationForMoveConnection>(query);
            return this;
        }

        public QueryRootFulfillmentOrderQueryBuilder MerchantRequests(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderMerchantRequestConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderMerchantRequestConnection>("merchantRequests");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderMerchantRequestConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderMerchantRequestConnection>(query);
            return this;
        }

        public QueryRootFulfillmentOrderQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public QueryRootFulfillmentOrderQueryBuilder OrderId()
        {
            base.InnerQuery.AddField("orderId");
            return this;
        }

        public QueryRootFulfillmentOrderQueryBuilder OrderName()
        {
            base.InnerQuery.AddField("orderName");
            return this;
        }

        public QueryRootFulfillmentOrderQueryBuilder OrderProcessedAt()
        {
            base.InnerQuery.AddField("orderProcessedAt");
            return this;
        }

        public QueryRootFulfillmentOrderQueryBuilder RequestStatus()
        {
            base.InnerQuery.AddField("requestStatus");
            return this;
        }

        public QueryRootFulfillmentOrderQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public QueryRootFulfillmentOrderQueryBuilder SupportedActions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderSupportedActionQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderSupportedAction>("supportedActions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderSupportedActionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderSupportedAction>(query);
            return this;
        }

        public QueryRootFulfillmentOrderQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}