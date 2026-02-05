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
    public sealed class SubscriptionBillingAttemptCreatePayloadQueryBuilder : FieldsQueryBuilderBase<SubscriptionBillingAttemptCreatePayload, SubscriptionBillingAttemptCreatePayloadQueryBuilder>
    {
        protected override SubscriptionBillingAttemptCreatePayloadQueryBuilder Self => this;

        public SubscriptionBillingAttemptCreatePayloadQueryBuilder() : this("subscriptionBillingAttemptCreatePayload")
        {
        }

        public SubscriptionBillingAttemptCreatePayloadQueryBuilder(string name) : base(new Query<SubscriptionBillingAttemptCreatePayload>(name))
        {
        }

        public SubscriptionBillingAttemptCreatePayloadQueryBuilder(IQuery<SubscriptionBillingAttemptCreatePayload> query) : base(query)
        {
        }

        public SubscriptionBillingAttemptCreatePayloadQueryBuilder SubscriptionBillingAttempt(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingAttemptQueryBuilder> build)
        {
            var query = new Query<SubscriptionBillingAttempt>("subscriptionBillingAttempt");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.SubscriptionBillingAttemptQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<SubscriptionBillingAttempt>(query);
            return this;
        }

        public SubscriptionBillingAttemptCreatePayloadQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BillingAttemptUserErrorQueryBuilder> build)
        {
            var query = new Query<BillingAttemptUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.BillingAttemptUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<BillingAttemptUserError>(query);
            return this;
        }
    }
}