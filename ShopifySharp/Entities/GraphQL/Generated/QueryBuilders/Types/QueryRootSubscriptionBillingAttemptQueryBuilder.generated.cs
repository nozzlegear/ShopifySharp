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
    public sealed class QueryRootSubscriptionBillingAttemptQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingAttempt, QueryRootSubscriptionBillingAttemptQueryBuilder>, IHasArguments<QueryRootSubscriptionBillingAttemptArgumentsBuilder>
    {
        public QueryRootSubscriptionBillingAttemptArgumentsBuilder Arguments { get; }
        protected override QueryRootSubscriptionBillingAttemptQueryBuilder Self => this;

        public QueryRootSubscriptionBillingAttemptQueryBuilder(string name) : base(new Query<SubscriptionBillingAttempt>(name))
        {
            Arguments = new QueryRootSubscriptionBillingAttemptArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootSubscriptionBillingAttemptQueryBuilder(IQuery<SubscriptionBillingAttempt> query) : base(query)
        {
            Arguments = new QueryRootSubscriptionBillingAttemptArgumentsBuilder(base.InnerQuery);
        }

        public QueryRootSubscriptionBillingAttemptQueryBuilder SetArguments(Action<QueryRootSubscriptionBillingAttemptArgumentsBuilder> configure)
        {
            configure(this.Arguments);
            return this;
        }

        public QueryRootSubscriptionBillingAttemptQueryBuilder CompletedAt()
        {
            base.InnerQuery.AddField("completedAt");
            return this;
        }

        public QueryRootSubscriptionBillingAttemptQueryBuilder CreatedAt()
        {
            base.InnerQuery.AddField("createdAt");
            return this;
        }

        [Obsolete("Use `processingError.code` instead to get the errorCode")]
        public QueryRootSubscriptionBillingAttemptQueryBuilder ErrorCode()
        {
            base.InnerQuery.AddField("errorCode");
            return this;
        }

        [Obsolete("Use `processingError.message` instead to get the errorMessage")]
        public QueryRootSubscriptionBillingAttemptQueryBuilder ErrorMessage()
        {
            base.InnerQuery.AddField("errorMessage");
            return this;
        }

        public QueryRootSubscriptionBillingAttemptQueryBuilder Id()
        {
            base.InnerQuery.AddField("id");
            return this;
        }

        public QueryRootSubscriptionBillingAttemptQueryBuilder IdempotencyKey()
        {
            base.InnerQuery.AddField("idempotencyKey");
            return this;
        }

        public QueryRootSubscriptionBillingAttemptQueryBuilder NextActionUrl()
        {
            base.InnerQuery.AddField("nextActionUrl");
            return this;
        }

        public QueryRootSubscriptionBillingAttemptQueryBuilder Order(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder> build)
        {
            var query = new Query<Order>("order");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<Order>(query);
            return this;
        }

        public QueryRootSubscriptionBillingAttemptQueryBuilder OriginTime()
        {
            base.InnerQuery.AddField("originTime");
            return this;
        }

        public QueryRootSubscriptionBillingAttemptQueryBuilder PaymentGroupId()
        {
            base.InnerQuery.AddField("paymentGroupId");
            return this;
        }

        public QueryRootSubscriptionBillingAttemptQueryBuilder PaymentSessionId()
        {
            base.InnerQuery.AddField("paymentSessionId");
            return this;
        }

        public QueryRootSubscriptionBillingAttemptQueryBuilder ProcessingError(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptProcessingErrorQueryBuilder> build)
        {
            var query = new Query<ISubscriptionBillingAttemptProcessingError>("processingError");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptProcessingErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<ISubscriptionBillingAttemptProcessingError>(query);
            return this;
        }

        public QueryRootSubscriptionBillingAttemptQueryBuilder Ready()
        {
            base.InnerQuery.AddField("ready");
            return this;
        }

        public QueryRootSubscriptionBillingAttemptQueryBuilder RespectInventoryPolicy()
        {
            base.InnerQuery.AddField("respectInventoryPolicy");
            return this;
        }

        public QueryRootSubscriptionBillingAttemptQueryBuilder SubscriptionContract(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder> build)
        {
            var query = new Query<SubscriptionContract>("subscriptionContract");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionContractQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionContract>(query);
            return this;
        }

        public QueryRootSubscriptionBillingAttemptQueryBuilder Transactions(Action<ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionConnectionQueryBuilder> build)
        {
            var query = new Query<OrderTransactionConnection>("transactions");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.OrderTransactionConnectionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<OrderTransactionConnection>(query);
            return this;
        }
    }
}