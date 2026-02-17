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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class FulfillmentOrderLineItemsPreparedForPickupOperationQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderLineItemsPreparedForPickupPayload, FulfillmentOrderLineItemsPreparedForPickupOperationQueryBuilder>, IGraphOperationQueryBuilder<FulfillmentOrderLineItemsPreparedForPickupPayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public FulfillmentOrderLineItemsPreparedForPickupArgumentsBuilder Arguments { get; }
        protected override FulfillmentOrderLineItemsPreparedForPickupOperationQueryBuilder Self => this;

        public FulfillmentOrderLineItemsPreparedForPickupOperationQueryBuilder() : this("fulfillmentOrderLineItemsPreparedForPickup")
        {
        }

        public FulfillmentOrderLineItemsPreparedForPickupOperationQueryBuilder(string name) : base(new Query<FulfillmentOrderLineItemsPreparedForPickupPayload>(name))
        {
            Arguments = new FulfillmentOrderLineItemsPreparedForPickupArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderLineItemsPreparedForPickupOperationQueryBuilder(IQuery<FulfillmentOrderLineItemsPreparedForPickupPayload> query) : base(query)
        {
            Arguments = new FulfillmentOrderLineItemsPreparedForPickupArgumentsBuilder(base.InnerQuery);
        }

        public FulfillmentOrderLineItemsPreparedForPickupOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderLineItemsPreparedForPickupUserErrorQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderLineItemsPreparedForPickupUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.FulfillmentOrderLineItemsPreparedForPickupUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderLineItemsPreparedForPickupUserError>(query);
            return this;
        }
    }
}