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
    public sealed class SubscriptionBillingAttemptSuccessStateQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingAttemptSuccessState, SubscriptionBillingAttemptSuccessStateQueryBuilder>
    {
        protected override SubscriptionBillingAttemptSuccessStateQueryBuilder Self => this;

        public SubscriptionBillingAttemptSuccessStateQueryBuilder() : this("subscriptionBillingAttemptSuccessState")
        {
        }

        public SubscriptionBillingAttemptSuccessStateQueryBuilder(string name) : base(new Query<SubscriptionBillingAttemptSuccessState>(name))
        {
        }

        public SubscriptionBillingAttemptSuccessStateQueryBuilder(IQuery<SubscriptionBillingAttemptSuccessState> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptSuccessStateQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }
    }
}