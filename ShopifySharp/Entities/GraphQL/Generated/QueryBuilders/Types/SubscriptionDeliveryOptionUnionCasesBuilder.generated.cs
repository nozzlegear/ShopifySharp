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
    public sealed class SubscriptionDeliveryOptionUnionCasesBuilder : UnionCasesBuilderBase<SubscriptionDeliveryOption, SubscriptionDeliveryOptionUnionCasesBuilder>
    {
        protected override SubscriptionDeliveryOptionUnionCasesBuilder Self => this;

        public SubscriptionDeliveryOptionUnionCasesBuilder(string fieldName = "deliveryOptions") : this(new Query<SubscriptionDeliveryOption>(fieldName))
        {
        }

        public SubscriptionDeliveryOptionUnionCasesBuilder(IQuery<SubscriptionDeliveryOption> query) : base(query)
        {
        }

        public SubscriptionDeliveryOptionUnionCasesBuilder OnSubscriptionLocalDeliveryOption(Action<SubscriptionLocalDeliveryOptionQueryBuilder> build)
        {
            var query = new Query<SubscriptionLocalDeliveryOption>("... on SubscriptionLocalDeliveryOption");
            var queryBuilder = new SubscriptionLocalDeliveryOptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SubscriptionDeliveryOptionUnionCasesBuilder OnSubscriptionPickupOption(Action<SubscriptionPickupOptionQueryBuilder> build)
        {
            var query = new Query<SubscriptionPickupOption>("... on SubscriptionPickupOption");
            var queryBuilder = new SubscriptionPickupOptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SubscriptionDeliveryOptionUnionCasesBuilder OnSubscriptionShippingOption(Action<SubscriptionShippingOptionQueryBuilder> build)
        {
            var query = new Query<SubscriptionShippingOption>("... on SubscriptionShippingOption");
            var queryBuilder = new SubscriptionShippingOptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}