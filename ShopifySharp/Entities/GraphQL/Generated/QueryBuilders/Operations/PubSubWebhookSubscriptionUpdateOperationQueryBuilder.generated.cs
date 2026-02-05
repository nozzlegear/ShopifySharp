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
    public sealed class PubSubWebhookSubscriptionUpdateOperationQueryBuilder : FieldsQueryBuilderBase<PubSubWebhookSubscriptionUpdatePayload, PubSubWebhookSubscriptionUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<PubSubWebhookSubscriptionUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public PubSubWebhookSubscriptionUpdateArgumentsBuilder Arguments { get; }
        protected override PubSubWebhookSubscriptionUpdateOperationQueryBuilder Self => this;

        public PubSubWebhookSubscriptionUpdateOperationQueryBuilder() : this("pubSubWebhookSubscriptionUpdate")
        {
        }

        public PubSubWebhookSubscriptionUpdateOperationQueryBuilder(string name) : base(new Query<PubSubWebhookSubscriptionUpdatePayload>(name))
        {
            Arguments = new PubSubWebhookSubscriptionUpdateArgumentsBuilder(base.InnerQuery);
        }

        public PubSubWebhookSubscriptionUpdateOperationQueryBuilder(IQuery<PubSubWebhookSubscriptionUpdatePayload> query) : base(query)
        {
            Arguments = new PubSubWebhookSubscriptionUpdateArgumentsBuilder(base.InnerQuery);
        }

        public PubSubWebhookSubscriptionUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PubSubWebhookSubscriptionUpdateUserErrorQueryBuilder> build)
        {
            var query = new Query<PubSubWebhookSubscriptionUpdateUserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.PubSubWebhookSubscriptionUpdateUserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<PubSubWebhookSubscriptionUpdateUserError>(query);
            return this;
        }

        public PubSubWebhookSubscriptionUpdateOperationQueryBuilder WebhookSubscription(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebhookSubscriptionQueryBuilder> build)
        {
            var query = new Query<WebhookSubscription>("webhookSubscription");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebhookSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<WebhookSubscription>(query);
            return this;
        }
    }
}