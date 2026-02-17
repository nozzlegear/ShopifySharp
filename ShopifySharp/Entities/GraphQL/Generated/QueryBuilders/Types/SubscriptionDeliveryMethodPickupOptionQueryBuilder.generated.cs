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
    public sealed class SubscriptionDeliveryMethodPickupOptionQueryBuilder : FieldsQueryBuilderBase<SubscriptionDeliveryMethodPickupOption, SubscriptionDeliveryMethodPickupOptionQueryBuilder>
    {
        protected override SubscriptionDeliveryMethodPickupOptionQueryBuilder Self => this;

        public SubscriptionDeliveryMethodPickupOptionQueryBuilder() : this("subscriptionDeliveryMethodPickupOption")
        {
        }

        public SubscriptionDeliveryMethodPickupOptionQueryBuilder(string name) : base(new Query<SubscriptionDeliveryMethodPickupOption>(name))
        {
        }

        public SubscriptionDeliveryMethodPickupOptionQueryBuilder(IQuery<SubscriptionDeliveryMethodPickupOption> query) : base(query)
        {
        }

        public SubscriptionDeliveryMethodPickupOptionQueryBuilder Code()
        {
            base.InnerQuery.AddField("code");
            return this;
        }

        public SubscriptionDeliveryMethodPickupOptionQueryBuilder Description()
        {
            base.InnerQuery.AddField("description");
            return this;
        }

        public SubscriptionDeliveryMethodPickupOptionQueryBuilder Location(Action<ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder> build)
        {
            var query = new Query<Location>("location");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.LocationQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Location>(query);
            return this;
        }

        public SubscriptionDeliveryMethodPickupOptionQueryBuilder PresentmentTitle()
        {
            base.InnerQuery.AddField("presentmentTitle");
            return this;
        }

        public SubscriptionDeliveryMethodPickupOptionQueryBuilder Title()
        {
            base.InnerQuery.AddField("title");
            return this;
        }
    }
}