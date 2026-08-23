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
    public sealed class SubscriptionBillingAttemptErrorUnionCasesBuilder : UnionCasesBuilderBase<SubscriptionBillingAttemptError, SubscriptionBillingAttemptErrorUnionCasesBuilder>
    {
        protected override SubscriptionBillingAttemptErrorUnionCasesBuilder Self => this;

        public SubscriptionBillingAttemptErrorUnionCasesBuilder(string fieldName = "error") : this(new Query<SubscriptionBillingAttemptError>(fieldName))
        {
        }

        public SubscriptionBillingAttemptErrorUnionCasesBuilder(IQuery<SubscriptionBillingAttemptError> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptErrorUnionCasesBuilder OnSubscriptionBillingAttemptGeneralError(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptGeneralErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptGeneralError>("... on SubscriptionBillingAttemptGeneralError");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptGeneralErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SubscriptionBillingAttemptErrorUnionCasesBuilder OnSubscriptionBillingAttemptInventoryError(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptInventoryErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptInventoryError>("... on SubscriptionBillingAttemptInventoryError");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptInventoryErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SubscriptionBillingAttemptErrorUnionCasesBuilder OnSubscriptionBillingAttemptPaymentError(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptPaymentErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptPaymentError>("... on SubscriptionBillingAttemptPaymentError");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptPaymentErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }

        public SubscriptionBillingAttemptErrorUnionCasesBuilder OnSubscriptionBillingAttemptUnexpectedError(Action<ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptUnexpectedErrorQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttemptUnexpectedError>("... on SubscriptionBillingAttemptUnexpectedError");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.SubscriptionBillingAttemptUnexpectedErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField(query);
            return this;
        }
    }
}