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

namespace ShopifySharp.GraphQL.Generated.QueryBuilders.Operations
{
    public sealed class SubscriptionBillingAttemptCreateOperationQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingAttemptCreatePayload, SubscriptionBillingAttemptCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<SubscriptionBillingAttemptCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public SubscriptionBillingAttemptCreateArgumentsBuilder Arguments { get; }
        protected override SubscriptionBillingAttemptCreateOperationQueryBuilder Self => this;

        public SubscriptionBillingAttemptCreateOperationQueryBuilder() : this("subscriptionBillingAttemptCreate")
        {
        }

        public SubscriptionBillingAttemptCreateOperationQueryBuilder(string name) : base(new Query<SubscriptionBillingAttemptCreatePayload>(name))
        {
            Arguments = new SubscriptionBillingAttemptCreateArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingAttemptCreateOperationQueryBuilder(IQuery<SubscriptionBillingAttemptCreatePayload> query) : base(query)
        {
            Arguments = new SubscriptionBillingAttemptCreateArgumentsBuilder(base.InnerQuery);
        }

        public SubscriptionBillingAttemptCreateOperationQueryBuilder SubscriptionBillingAttempt(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingAttemptQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttempt>("subscriptionBillingAttempt");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingAttemptQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingAttempt>(query);
            return this;
        }

        public SubscriptionBillingAttemptCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BillingAttemptUserErrorQueryBuilder> build)
        {
            var query = new Query<BillingAttemptUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BillingAttemptUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BillingAttemptUserError>(query);
            return this;
        }
    }
}