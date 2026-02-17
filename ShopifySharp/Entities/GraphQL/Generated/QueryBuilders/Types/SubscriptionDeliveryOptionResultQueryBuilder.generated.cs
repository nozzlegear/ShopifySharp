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
    public sealed class SubscriptionDeliveryOptionResultQueryBuilder : FieldsQueryBuilderBase<SubscriptionDeliveryOptionResult, SubscriptionDeliveryOptionResultQueryBuilder>
    {
        protected override SubscriptionDeliveryOptionResultQueryBuilder Self => this;

        public SubscriptionDeliveryOptionResultQueryBuilder() : this("subscriptionDeliveryOptionResult")
        {
        }

        public SubscriptionDeliveryOptionResultQueryBuilder(string name) : base(new Query<SubscriptionDeliveryOptionResult>(name))
        {
        }

        public SubscriptionDeliveryOptionResultQueryBuilder(IQuery<SubscriptionDeliveryOptionResult> query) : base(query)
        {
        }

        public SubscriptionDeliveryOptionResultQueryBuilder SubscriptionDeliveryOptionResult(Action<SubscriptionDeliveryOptionResultUnionCasesBuilder> build)
        {
            var query = new Query<SubscriptionDeliveryOptionResult>("subscriptionDeliveryOptionResult");
            var unionBuilder = new SubscriptionDeliveryOptionResultUnionCasesBuilder(query);
            build.Invoke(unionBuilder);
            base.InnerQuery.AddUnionCase(query);
            return this;
        }
    }
}