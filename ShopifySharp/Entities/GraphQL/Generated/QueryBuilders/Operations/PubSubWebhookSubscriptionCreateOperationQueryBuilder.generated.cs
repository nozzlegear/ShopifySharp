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
    [Obsolete("Use `webhookSubscriptionCreate` instead.")]
    public sealed class PubSubWebhookSubscriptionCreateOperationQueryBuilder : FieldsQueryBuilderBase<PubSubWebhookSubscriptionCreatePayload, PubSubWebhookSubscriptionCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<PubSubWebhookSubscriptionCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PubSubWebhookSubscriptionCreateArgumentsBuilder Arguments { get; }
        protected override PubSubWebhookSubscriptionCreateOperationQueryBuilder Self => this;

        public PubSubWebhookSubscriptionCreateOperationQueryBuilder() : this("pubSubWebhookSubscriptionCreate")
        {
        }

        public PubSubWebhookSubscriptionCreateOperationQueryBuilder(string name) : base(new Query<PubSubWebhookSubscriptionCreatePayload>(name))
        {
            Arguments = new PubSubWebhookSubscriptionCreateArgumentsBuilder(base.InnerQuery);
        }

        public PubSubWebhookSubscriptionCreateOperationQueryBuilder(IQuery<PubSubWebhookSubscriptionCreatePayload> query) : base(query)
        {
            Arguments = new PubSubWebhookSubscriptionCreateArgumentsBuilder(base.InnerQuery);
        }

        public PubSubWebhookSubscriptionCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PubSubWebhookSubscriptionCreateUserErrorQueryBuilder> build)
        {
            var query = new Query<PubSubWebhookSubscriptionCreateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PubSubWebhookSubscriptionCreateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PubSubWebhookSubscriptionCreateUserError>(query);
            return this;
        }

        public PubSubWebhookSubscriptionCreateOperationQueryBuilder WebhookSubscription(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebhookSubscriptionQueryBuilder> build)
        {
            var query = new Query<WebhookSubscription>("webhookSubscription");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebhookSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<WebhookSubscription>(query);
            return this;
        }
    }
}