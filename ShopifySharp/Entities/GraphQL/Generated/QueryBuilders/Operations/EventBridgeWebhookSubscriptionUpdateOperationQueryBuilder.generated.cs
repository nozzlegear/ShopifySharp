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
    [Obsolete("Use `webhookSubscriptionUpdate` instead.")]
    public sealed class EventBridgeWebhookSubscriptionUpdateOperationQueryBuilder : FieldsQueryBuilderBase<EventBridgeWebhookSubscriptionUpdatePayload, EventBridgeWebhookSubscriptionUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<EventBridgeWebhookSubscriptionUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public EventBridgeWebhookSubscriptionUpdateArgumentsBuilder Arguments { get; }
        protected override EventBridgeWebhookSubscriptionUpdateOperationQueryBuilder Self => this;

        public EventBridgeWebhookSubscriptionUpdateOperationQueryBuilder() : this("eventBridgeWebhookSubscriptionUpdate")
        {
        }

        public EventBridgeWebhookSubscriptionUpdateOperationQueryBuilder(string name) : base(new Query<EventBridgeWebhookSubscriptionUpdatePayload>(name))
        {
            Arguments = new EventBridgeWebhookSubscriptionUpdateArgumentsBuilder(base.InnerQuery);
        }

        public EventBridgeWebhookSubscriptionUpdateOperationQueryBuilder(IQuery<EventBridgeWebhookSubscriptionUpdatePayload> query) : base(query)
        {
            Arguments = new EventBridgeWebhookSubscriptionUpdateArgumentsBuilder(base.InnerQuery);
        }

        public EventBridgeWebhookSubscriptionUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }

        public EventBridgeWebhookSubscriptionUpdateOperationQueryBuilder WebhookSubscription(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebhookSubscriptionQueryBuilder> build)
        {
            var query = new Query<WebhookSubscription>("webhookSubscription");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebhookSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<WebhookSubscription>(query);
            return this;
        }
    }
}