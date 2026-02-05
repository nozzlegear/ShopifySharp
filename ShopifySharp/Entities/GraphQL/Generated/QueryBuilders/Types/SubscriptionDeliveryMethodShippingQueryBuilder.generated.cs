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
    public sealed class SubscriptionDeliveryMethodShippingQueryBuilder : FieldsQueryBuilderBase<SubscriptionDeliveryMethodShipping, SubscriptionDeliveryMethodShippingQueryBuilder>
    {
        protected override SubscriptionDeliveryMethodShippingQueryBuilder Self => this;

        public SubscriptionDeliveryMethodShippingQueryBuilder() : this("subscriptionDeliveryMethodShipping")
        {
        }

        public SubscriptionDeliveryMethodShippingQueryBuilder(string name) : base(new Query<SubscriptionDeliveryMethodShipping>(name))
        {
        }

        public SubscriptionDeliveryMethodShippingQueryBuilder(IQuery<SubscriptionDeliveryMethodShipping> query) : base(query)
        {
        }

        public SubscriptionDeliveryMethodShippingQueryBuilder Address(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("address");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public SubscriptionDeliveryMethodShippingQueryBuilder ShippingOption(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDeliveryMethodShippingOptionQueryBuilder> build)
        {
            var query = new Query<SubscriptionDeliveryMethodShippingOption>("shippingOption");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDeliveryMethodShippingOptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDeliveryMethodShippingOption>(query);
            return this;
        }
    }
}