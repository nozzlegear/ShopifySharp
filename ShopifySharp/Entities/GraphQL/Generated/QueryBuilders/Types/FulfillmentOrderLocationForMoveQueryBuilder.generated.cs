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
    public sealed class FulfillmentOrderLocationForMoveQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderLocationForMove, FulfillmentOrderLocationForMoveQueryBuilder>
    {
        protected override FulfillmentOrderLocationForMoveQueryBuilder Self => this;

        public FulfillmentOrderLocationForMoveQueryBuilder() : this("fulfillmentOrderLocationForMove")
        {
        }

        public FulfillmentOrderLocationForMoveQueryBuilder(string name) : base(new Query<FulfillmentOrderLocationForMove>(name))
        {
        }

        public FulfillmentOrderLocationForMoveQueryBuilder(IQuery<FulfillmentOrderLocationForMove> query) : base(query)
        {
        }

        public FulfillmentOrderLocationForMoveQueryBuilder AvailableLineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderLineItemConnection>("availableLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderLineItemConnection>(query);
            return this;
        }

        public FulfillmentOrderLocationForMoveQueryBuilder AvailableLineItemsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("availableLineItemsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }

        public FulfillmentOrderLocationForMoveQueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public FulfillmentOrderLocationForMoveQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }

        public FulfillmentOrderLocationForMoveQueryBuilder Movable()
        {
            base.InnerQuery.AddField("movable");
            return this;
        }

        public FulfillmentOrderLocationForMoveQueryBuilder UnavailableLineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderLineItemConnection>("unavailableLineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderLineItemConnection>(query);
            return this;
        }

        public FulfillmentOrderLocationForMoveQueryBuilder UnavailableLineItemsCount(Action<ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder> build)
        {
            var query = new Query<Count>("unavailableLineItemsCount");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.CountQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Count>(query);
            return this;
        }
    }
}