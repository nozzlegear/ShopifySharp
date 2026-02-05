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
    public sealed class SubscriptionDeliveryMethodLocalDeliveryQueryBuilder : FieldsQueryBuilderBase<SubscriptionDeliveryMethodLocalDelivery, SubscriptionDeliveryMethodLocalDeliveryQueryBuilder>
    {
        protected override SubscriptionDeliveryMethodLocalDeliveryQueryBuilder Self => this;

        public SubscriptionDeliveryMethodLocalDeliveryQueryBuilder() : this("subscriptionDeliveryMethodLocalDelivery")
        {
        }

        public SubscriptionDeliveryMethodLocalDeliveryQueryBuilder(string name) : base(new Query<SubscriptionDeliveryMethodLocalDelivery>(name))
        {
        }

        public SubscriptionDeliveryMethodLocalDeliveryQueryBuilder(IQuery<SubscriptionDeliveryMethodLocalDelivery> query) : base(query)
        {
        }

        public SubscriptionDeliveryMethodLocalDeliveryQueryBuilder Address(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder> build)
        {
            var query = new Query<MailingAddress>("address");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.MailingAddressQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<MailingAddress>(query);
            return this;
        }

        public SubscriptionDeliveryMethodLocalDeliveryQueryBuilder LocalDeliveryOption(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDeliveryMethodLocalDeliveryOptionQueryBuilder> build)
        {
            var query = new Query<SubscriptionDeliveryMethodLocalDeliveryOption>("localDeliveryOption");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionDeliveryMethodLocalDeliveryOptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionDeliveryMethodLocalDeliveryOption>(query);
            return this;
        }
    }
}