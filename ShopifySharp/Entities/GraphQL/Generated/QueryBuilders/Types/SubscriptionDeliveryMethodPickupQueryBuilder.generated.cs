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
    public sealed class SubscriptionDeliveryMethodPickupQueryBuilder : FieldsQueryBuilderBase<SubscriptionDeliveryMethodPickup, SubscriptionDeliveryMethodPickupQueryBuilder>
    {
        protected override SubscriptionDeliveryMethodPickupQueryBuilder Self => this;

        public SubscriptionDeliveryMethodPickupQueryBuilder() : this("subscriptionDeliveryMethodPickup")
        {
        }

        public SubscriptionDeliveryMethodPickupQueryBuilder(string name) : base(new Query<SubscriptionDeliveryMethodPickup>(name))
        {
        }

        public SubscriptionDeliveryMethodPickupQueryBuilder(IQuery<SubscriptionDeliveryMethodPickup> query) : base(query)
        {
        }

        public SubscriptionDeliveryMethodPickupQueryBuilder PickupOption(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDeliveryMethodPickupOptionQueryBuilder> build)
        {
            var query = new Query<SubscriptionDeliveryMethodPickupOption>("pickupOption");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionDeliveryMethodPickupOptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDeliveryMethodPickupOption>(query);
            return this;
        }
    }
}