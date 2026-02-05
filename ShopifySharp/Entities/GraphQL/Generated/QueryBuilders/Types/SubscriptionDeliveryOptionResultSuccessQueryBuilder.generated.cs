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
    public sealed class SubscriptionDeliveryOptionResultSuccessQueryBuilder : FieldsQueryBuilderBase<SubscriptionDeliveryOptionResultSuccess, SubscriptionDeliveryOptionResultSuccessQueryBuilder>
    {
        protected override SubscriptionDeliveryOptionResultSuccessQueryBuilder Self => this;

        public SubscriptionDeliveryOptionResultSuccessQueryBuilder() : this("subscriptionDeliveryOptionResultSuccess")
        {
        }

        public SubscriptionDeliveryOptionResultSuccessQueryBuilder(string name) : base(new Query<SubscriptionDeliveryOptionResultSuccess>(name))
        {
        }

        public SubscriptionDeliveryOptionResultSuccessQueryBuilder(IQuery<SubscriptionDeliveryOptionResultSuccess> query) : base(query)
        {
        }

        public SubscriptionDeliveryOptionResultSuccessQueryBuilder DeliveryOptions(Action<SubscriptionDeliveryOptionUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionDeliveryOption>("deliveryOptions");
            var unionBuilder = new SubscriptionDeliveryOptionUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}