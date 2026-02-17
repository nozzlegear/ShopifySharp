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

namespace ShopifySharp.GraphQL.QueryBuilders.Operations
{
    public sealed class SubscriptionBillingAttemptOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingAttempt, SubscriptionBillingAttemptOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionBillingAttempt>
    {
        public OperationType OperationType { get; } = OperationType.Query;
        public SubscriptionBillingAttemptArgumentsBuilder Arguments { get; }
        protected override SubscriptionBillingAttemptOperationQueryBuilder Self => this;

        public SubscriptionBillingAttemptOperationQueryBuilder() : this("subscriptionBillingAttempt")
        {
        }

        public SubscriptionBillingAttemptOperationQueryBuilder(string name) : base(new Query<SubscriptionBillingAttempt>(name))
        {
            Arguments = new SubscriptionBillingAttemptArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingAttemptOperationQueryBuilder(IQuery<SubscriptionBillingAttempt> query) : base(query)
        {
            Arguments = new SubscriptionBillingAttemptArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingAttemptOperationQueryBuilder CompletedAt()
        {
            base.InnerQuery.AddField("completedAt");
            return this;
        }

        public SubscriptionBillingAttemptOperationQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        [Obsolete("Use `state` instead.")]
        public SubscriptionBillingAttemptOperationQueryBuilder ErrorCode()
        {
            base.InnerQuery.AddField("errorCode");
            return this;
        }

        [Obsolete("Use `state` instead.")]
        public SubscriptionBillingAttemptOperationQueryBuilder ErrorMessage()
        {
            base.InnerQuery.AddField("errorMessage");
            return this;
        }

        public SubscriptionBillingAttemptOperationQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public SubscriptionBillingAttemptOperationQueryBuilder IdempotencyKey()
        {
            base.InnerQuery.AddField("idempotencyKey");
            return this;
        }

        [Obsolete("Use `state` instead.")]
        public SubscriptionBillingAttemptOperationQueryBuilder NextActionUrl()
        {
            base.InnerQuery.AddField("nextActionUrl");
            return this;
        }

        public SubscriptionBillingAttemptOperationQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public SubscriptionBillingAttemptOperationQueryBuilder OriginTime()
        {
            base.InnerQuery.AddField("originTime");
            return this;
        }

        public SubscriptionBillingAttemptOperationQueryBuilder PaymentGroupId()
        {
            base.InnerQuery.AddField("paymentGroupId");
            return this;
        }

        public SubscriptionBillingAttemptOperationQueryBuilder PaymentSessionId()
        {
            base.InnerQuery.AddField("paymentSessionId");
            return this;
        }

        public SubscriptionBillingAttemptOperationQueryBuilder ProcessingError(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptProcessingErrorQueryBuilder> build)
        {
            var query = new Query<ISubscriptionBillingAttemptProcessingError>("processingError");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptProcessingErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ISubscriptionBillingAttemptProcessingError>(query);
            return this;
        }

        [Obsolete("Use `state` instead.")]
        public SubscriptionBillingAttemptOperationQueryBuilder Ready()
        {
            base.InnerQuery.AddField("ready");
            return this;
        }

        public SubscriptionBillingAttemptOperationQueryBuilder RespectInventoryPolicy()
        {
            base.InnerQuery.AddField("respectInventoryPolicy");
            return this;
        }

        public SubscriptionBillingAttemptOperationQueryBuilder SubscriptionContract(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("subscriptionContract");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public SubscriptionBillingAttemptOperationQueryBuilder Transactions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionConnectionQueryBuilder> build)
        {
            var query = new Query<OrderTransactionConnection>("transactions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransactionConnection>(query);
            return this;
        }
    }
}