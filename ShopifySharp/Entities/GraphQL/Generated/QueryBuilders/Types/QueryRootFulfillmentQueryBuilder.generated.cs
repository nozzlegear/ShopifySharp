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
    public sealed class QueryRootFulfillmentQueryBuilder : FieldsQueryBuilderBase<Fulfillment, QueryRootFulfillmentQueryBuilder>, IHasArguments<QueryRootFulfillmentArgumentsBuilder>
    {
        public QueryRootFulfillmentArgumentsBuilder Arguments { get; }
        protected override QueryRootFulfillmentQueryBuilder Self => this;

        public QueryRootFulfillmentQueryBuilder(string name) : base(new Query<Fulfillment>(name))
        {
            Arguments = new QueryRootFulfillmentArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootFulfillmentQueryBuilder(IQuery<Fulfillment> query) : base(query)
        {
            Arguments = new QueryRootFulfillmentArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootFulfillmentQueryBuilder SetArguments(Action<QueryRootFulfillmentArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootFulfillmentQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        public QueryRootFulfillmentQueryBuilder DeliveredAt()
        {
            base.InnerQuery.AddField("deliveredAt");
            return this;
        }

        public QueryRootFulfillmentQueryBuilder DisplayStatus()
        {
            base.InnerQuery.AddField("displayStatus");
            return this;
        }

        public QueryRootFulfillmentQueryBuilder EstimatedDeliveryAt()
        {
            base.InnerQuery.AddField("estimatedDeliveryAt");
            return this;
        }

        public QueryRootFulfillmentQueryBuilder Events(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentEventConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentEventConnection>("events");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentEventConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentEventConnection>(query);
            return this;
        }

        public QueryRootFulfillmentQueryBuilder FulfillmentLineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentLineItemConnection>("fulfillmentLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentLineItemConnection>(query);
            return this;
        }

        public QueryRootFulfillmentQueryBuilder FulfillmentOrders(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderConnection>("fulfillmentOrders");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderConnection>(query);
            return this;
        }

        public QueryRootFulfillmentQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootFulfillmentQueryBuilder InTransitAt()
        {
            base.InnerQuery.AddField("inTransitAt");
            return this;
        }

        public QueryRootFulfillmentQueryBuilder LegacyResourceId()
        {
            base.InnerQuery.AddField("legacyResourceId");
            return this;
        }

        public QueryRootFulfillmentQueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public QueryRootFulfillmentQueryBuilder Name()
        {
            base.InnerQuery.AddField("name");
            return this;
        }

        public QueryRootFulfillmentQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public QueryRootFulfillmentQueryBuilder OriginAddress(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOriginAddressQueryBuilder> build)
        {
            var query = new Query<FulfillmentOriginAddress>("originAddress");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOriginAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOriginAddress>(query);
            return this;
        }

        public QueryRootFulfillmentQueryBuilder RequiresShipping()
        {
            base.InnerQuery.AddField("requiresShipping");
            return this;
        }

        public QueryRootFulfillmentQueryBuilder Service(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentServiceQueryBuilder> build)
        {
            var query = new Query<FulfillmentService>("service");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentServiceQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentService>(query);
            return this;
        }

        public QueryRootFulfillmentQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public QueryRootFulfillmentQueryBuilder TotalQuantity()
        {
            base.InnerQuery.AddField("totalQuantity");
            return this;
        }

        public QueryRootFulfillmentQueryBuilder TrackingInfo(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentTrackingInfoQueryBuilder> build)
        {
            var query = new Query<FulfillmentTrackingInfo>("trackingInfo");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentTrackingInfoQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentTrackingInfo>(query);
            return this;
        }

        public QueryRootFulfillmentQueryBuilder UpdatedAt()
        {
            base.InnerQuery.AddField("updatedAt");
            return this;
        }
    }
}