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
    public sealed class ReverseFulfillmentOrderQueryBuilder : FieldsQueryBuilderBase<ReverseFulfillmentOrder, ReverseFulfillmentOrderQueryBuilder>
    {
        protected override ReverseFulfillmentOrderQueryBuilder Self => this;

        public ReverseFulfillmentOrderQueryBuilder() : this("reverseFulfillmentOrder")
        {
        }

        public ReverseFulfillmentOrderQueryBuilder(string name) : base(new Query<ReverseFulfillmentOrder>(name))
        {
        }

        public ReverseFulfillmentOrderQueryBuilder(IQuery<ReverseFulfillmentOrder> query) : base(query)
        {
        }

        public ReverseFulfillmentOrderQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public ReverseFulfillmentOrderQueryBuilder LineItems(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderLineItemConnectionQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrderLineItemConnection>("lineItems");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderLineItemConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrderLineItemConnection>(query);
            return this;
        }

        public ReverseFulfillmentOrderQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public ReverseFulfillmentOrderQueryBuilder ReverseDeliveries(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseDeliveryConnectionQueryBuilder> build)
        {
            var query = new Query<ReverseDeliveryConnection>("reverseDeliveries");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseDeliveryConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseDeliveryConnection>(query);
            return this;
        }

        public ReverseFulfillmentOrderQueryBuilder Status()
        {
            base.InnerQuery.AddField("status");
            return this;
        }

        public ReverseFulfillmentOrderQueryBuilder ThirdPartyConfirmation(Action<ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderThirdPartyConfirmationQueryBuilder> build)
        {
            var query = new Query<ReverseFulfillmentOrderThirdPartyConfirmation>("thirdPartyConfirmation");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.ReverseFulfillmentOrderThirdPartyConfirmationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ReverseFulfillmentOrderThirdPartyConfirmation>(query);
            return this;
        }
    }
}