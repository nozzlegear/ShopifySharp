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
    public sealed class SubscriptionBillingAttemptQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingAttempt, SubscriptionBillingAttemptQueryBuilder>
    {
        protected override SubscriptionBillingAttemptQueryBuilder Self => this;

        public SubscriptionBillingAttemptQueryBuilder() : this("subscriptionBillingAttempt")
        {
        }

        public SubscriptionBillingAttemptQueryBuilder(string name) : base(new Query<SubscriptionBillingAttempt>(name))
        {
        }

        public SubscriptionBillingAttemptQueryBuilder(IQuery<SubscriptionBillingAttempt> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptQueryBuilder CompletedAt()
        {
            base.InnerQuery.AddField("completedAt");
            return this;
        }

        public SubscriptionBillingAttemptQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        [Obsolete("Use `state` instead.")]
        public SubscriptionBillingAttemptQueryBuilder ErrorCode()
        {
            base.InnerQuery.AddField("errorCode");
            return this;
        }

        [Obsolete("Use `state` instead.")]
        public SubscriptionBillingAttemptQueryBuilder ErrorMessage()
        {
            base.InnerQuery.AddField("errorMessage");
            return this;
        }

        public SubscriptionBillingAttemptQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public SubscriptionBillingAttemptQueryBuilder IdempotencyKey()
        {
            base.InnerQuery.AddField("idempotencyKey");
            return this;
        }

        [Obsolete("Use `state` instead.")]
        public SubscriptionBillingAttemptQueryBuilder NextActionUrl()
        {
            base.InnerQuery.AddField("nextActionUrl");
            return this;
        }

        public SubscriptionBillingAttemptQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public SubscriptionBillingAttemptQueryBuilder OriginTime()
        {
            base.InnerQuery.AddField("originTime");
            return this;
        }

        public SubscriptionBillingAttemptQueryBuilder PaymentGroupId()
        {
            base.InnerQuery.AddField("paymentGroupId");
            return this;
        }

        public SubscriptionBillingAttemptQueryBuilder PaymentSessionId()
        {
            base.InnerQuery.AddField("paymentSessionId");
            return this;
        }

        public SubscriptionBillingAttemptQueryBuilder ProcessingError(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptProcessingErrorQueryBuilder> build)
        {
            var query = new Query<ISubscriptionBillingAttemptProcessingError>("processingError");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptProcessingErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ISubscriptionBillingAttemptProcessingError>(query);
            return this;
        }

        [Obsolete("Use `state` instead.")]
        public SubscriptionBillingAttemptQueryBuilder Ready()
        {
            base.InnerQuery.AddField("ready");
            return this;
        }

        public SubscriptionBillingAttemptQueryBuilder RespectInventoryPolicy()
        {
            base.InnerQuery.AddField("respectInventoryPolicy");
            return this;
        }

        public SubscriptionBillingAttemptQueryBuilder SubscriptionContract(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("subscriptionContract");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public SubscriptionBillingAttemptQueryBuilder Transactions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionConnectionQueryBuilder> build)
        {
            var query = new Query<OrderTransactionConnection>("transactions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransactionConnection>(query);
            return this;
        }
    }
}