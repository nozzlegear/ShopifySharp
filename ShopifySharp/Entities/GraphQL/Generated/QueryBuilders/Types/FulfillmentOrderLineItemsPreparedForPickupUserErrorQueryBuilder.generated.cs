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
    public sealed class FulfillmentOrderLineItemsPreparedForPickupUserErrorQueryBuilder : FieldsQueryBuilderBase<FulfillmentOrderLineItemsPreparedForPickupUserError, FulfillmentOrderLineItemsPreparedForPickupUserErrorQueryBuilder>
    {
        protected override FulfillmentOrderLineItemsPreparedForPickupUserErrorQueryBuilder Self => this;

        public FulfillmentOrderLineItemsPreparedForPickupUserErrorQueryBuilder() : this("fulfillmentOrderLineItemsPreparedForPickupUserError")
        {
        }

        public FulfillmentOrderLineItemsPreparedForPickupUserErrorQueryBuilder(string name) : base(new Query<FulfillmentOrderLineItemsPreparedForPickupUserError>(name))
        {
        }

        public FulfillmentOrderLineItemsPreparedForPickupUserErrorQueryBuilder(IQuery<FulfillmentOrderLineItemsPreparedForPickupUserError> query) : base(query)
        {
        }

        public FulfillmentOrderLineItemsPreparedForPickupUserErrorQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public FulfillmentOrderLineItemsPreparedForPickupUserErrorQueryBuilder Field()
        {
            base.InnerQuery.AddField("field");
            return this;
        }

        public FulfillmentOrderLineItemsPreparedForPickupUserErrorQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}