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
    [Obsolete("Use `webhookSubscriptionCreate` instead.")]
    public sealed class EventBridgeWebhookSubscriptionCreateOperationQueryBuilder : FieldsQueryBuilderBase<EventBridgeWebhookSubscriptionCreatePayload, EventBridgeWebhookSubscriptionCreateOperationQueryBuilder>, IGraphOperationQueryBuilder<EventBridgeWebhookSubscriptionCreatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public EventBridgeWebhookSubscriptionCreateArgumentsBuilder Arguments { get; }
        protected override EventBridgeWebhookSubscriptionCreateOperationQueryBuilder Self => this;

        public EventBridgeWebhookSubscriptionCreateOperationQueryBuilder() : this("eventBridgeWebhookSubscriptionCreate")
        {
        }

        public EventBridgeWebhookSubscriptionCreateOperationQueryBuilder(string name) : base(new Query<EventBridgeWebhookSubscriptionCreatePayload>(name))
        {
            Arguments = new EventBridgeWebhookSubscriptionCreateArgumentsBuilder(base.InnerQuery);
        }

        public EventBridgeWebhookSubscriptionCreateOperationQueryBuilder(IQuery<EventBridgeWebhookSubscriptionCreatePayload> query) : base(query)
        {
            Arguments = new EventBridgeWebhookSubscriptionCreateArgumentsBuilder(base.InnerQuery);
        }

        public EventBridgeWebhookSubscriptionCreateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }

        public EventBridgeWebhookSubscriptionCreateOperationQueryBuilder WebhookSubscription(Action<ShopifySharp.GraphQL.QueryBuilders.Types.WebhookSubscriptionQueryBuilder> build)
        {
            var query = new Query<WebhookSubscription>("webhookSubscription");
            var queryBuilder = new ShopifySharp.GraphQL.QueryBuilders.Types.WebhookSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<WebhookSubscription>(query);
            return this;
        }
    }
}