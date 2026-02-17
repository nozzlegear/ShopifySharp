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
    public sealed class SubscriptionDeliveryOptionResultFailureQueryBuilder : FieldsQueryBuilderBase<SubscriptionDeliveryOptionResultFailure, SubscriptionDeliveryOptionResultFailureQueryBuilder>
    {
        protected override SubscriptionDeliveryOptionResultFailureQueryBuilder Self => this;

        public SubscriptionDeliveryOptionResultFailureQueryBuilder() : this("subscriptionDeliveryOptionResultFailure")
        {
        }

        public SubscriptionDeliveryOptionResultFailureQueryBuilder(string name) : base(new Query<SubscriptionDeliveryOptionResultFailure>(name))
        {
        }

        public SubscriptionDeliveryOptionResultFailureQueryBuilder(IQuery<SubscriptionDeliveryOptionResultFailure> query) : base(query)
        {
        }

        public SubscriptionDeliveryOptionResultFailureQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}