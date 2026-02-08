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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Types
{
    public sealed class FulfillmentOrderLineItemsPreparedForPickupPayloadQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderLineItemsPreparedForPickupPayload, FulfillmentOrderLineItemsPreparedForPickupPayloadQueryBuilder>
    {
        protected override FulfillmentOrderLineItemsPreparedForPickupPayloadQueryBuilder Self => this;

        public FulfillmentOrderLineItemsPreparedForPickupPayloadQueryBuilder() : this("fulfillmentOrderLineItemsPreparedForPickupPayload")
        {
        }

        public FulfillmentOrderLineItemsPreparedForPickupPayloadQueryBuilder(string name) : base(new Query<FulfillmentOrderLineItemsPreparedForPickupPayload>(name))
        {
        }

        public FulfillmentOrderLineItemsPreparedForPickupPayloadQueryBuilder(IQuery<FulfillmentOrderLineItemsPreparedForPickupPayload> query) : base(query)
        {
        }

        public FulfillmentOrderLineItemsPreparedForPickupPayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderLineItemsPreparedForPickupUserErrorQueryBuilder> build)
        {
            var query = new Query<FulfillmentOrderLineItemsPreparedForPickupUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.FulfillmentOrderLineItemsPreparedForPickupUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<FulfillmentOrderLineItemsPreparedForPickupUserError>(query);
            return this;
        }
    }
}