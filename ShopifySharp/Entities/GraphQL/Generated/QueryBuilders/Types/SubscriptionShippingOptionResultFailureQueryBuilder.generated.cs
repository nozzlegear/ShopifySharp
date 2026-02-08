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
    public sealed class SubscriptionShippingOptionResultFailureQueryBuilder : FieldsQueryBuilderBase<SubscriptionShippingOptionResultFailure, SubscriptionShippingOptionResultFailureQueryBuilder>
    {
        protected override SubscriptionShippingOptionResultFailureQueryBuilder Self => this;

        public SubscriptionShippingOptionResultFailureQueryBuilder() : this("subscriptionShippingOptionResultFailure")
        {
        }

        public SubscriptionShippingOptionResultFailureQueryBuilder(string name) : base(new Query<SubscriptionShippingOptionResultFailure>(name))
        {
        }

        public SubscriptionShippingOptionResultFailureQueryBuilder(IQuery<SubscriptionShippingOptionResultFailure> query) : base(query)
        {
        }

        public SubscriptionShippingOptionResultFailureQueryBuilder Message()
        {
            base.InnerQuery.AddField("message");
            return this;
        }
    }
}