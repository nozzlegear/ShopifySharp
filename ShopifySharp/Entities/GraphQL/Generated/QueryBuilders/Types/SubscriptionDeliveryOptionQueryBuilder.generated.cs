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
    public sealed class SubscriptionDeliveryOptionQueryBuilder : FieldsQueryBuilderBase<SubscriptionDeliveryOption, SubscriptionDeliveryOptionQueryBuilder>
    {
        protected override SubscriptionDeliveryOptionQueryBuilder Self => this;

        public SubscriptionDeliveryOptionQueryBuilder() : this("subscriptionDeliveryOption")
        {
        }

        public SubscriptionDeliveryOptionQueryBuilder(string name) : base(new Query<SubscriptionDeliveryOption>(name))
        {
        }

        public SubscriptionDeliveryOptionQueryBuilder(IQuery<SubscriptionDeliveryOption> query) : base(query)
        {
        }

        public SubscriptionDeliveryOptionQueryBuilder SubscriptionDeliveryOption(Action<SubscriptionDeliveryOptionUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionDeliveryOption>("subscriptionDeliveryOption");
            var unionBuilder = new SubscriptionDeliveryOptionUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}