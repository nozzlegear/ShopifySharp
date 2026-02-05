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
    public sealed class ShopifyPaymentsDisputeFulfillmentQueryBuilder : FieldsQueryBuilderBase<ShopifyPaymentsDisputeFulfillment, ShopifyPaymentsDisputeFulfillmentQueryBuilder>
    {
        protected override ShopifyPaymentsDisputeFulfillmentQueryBuilder Self => this;

        public ShopifyPaymentsDisputeFulfillmentQueryBuilder() : this("shopifyPaymentsDisputeFulfillment")
        {
        }

        public ShopifyPaymentsDisputeFulfillmentQueryBuilder(string name) : base(new Query<ShopifyPaymentsDisputeFulfillment>(name))
        {
        }

        public ShopifyPaymentsDisputeFulfillmentQueryBuilder(IQuery<ShopifyPaymentsDisputeFulfillment> query) : base(query)
        {
        }

        public ShopifyPaymentsDisputeFulfillmentQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ShopifyPaymentsDisputeFulfillmentQueryBuilder ShippingCarrier()
        {
            base.InnerQuery.AddField("shippingCarrier");
            return this;
        }

        public ShopifyPaymentsDisputeFulfillmentQueryBuilder ShippingDate()
        {
            base.InnerQuery.AddField("shippingDate");
            return this;
        }

        public ShopifyPaymentsDisputeFulfillmentQueryBuilder ShippingTrackingNumber()
        {
            base.InnerQuery.AddField("shippingTrackingNumber");
            return this;
        }
    }
}