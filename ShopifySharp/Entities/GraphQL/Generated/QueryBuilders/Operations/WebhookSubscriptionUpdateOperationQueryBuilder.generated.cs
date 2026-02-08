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
    public sealed class WebhookSubscriptionUpdateOperationQueryBuilder : FieldsQueryBuilderBase<WebhookSubscriptionUpdatePayload, WebhookSubscriptionUpdateOperationQueryBuilder>, IGraphOperationQueryBuilder<WebhookSubscriptionUpdatePayload>
    {
        public OperationType OperationType { get; } = OperationType.Mutation;
        public WebhookSubscriptionUpdateArgumentsBuilder Arguments { get; }
        protected override WebhookSubscriptionUpdateOperationQueryBuilder Self => this;

        public WebhookSubscriptionUpdateOperationQueryBuilder() : this("webhookSubscriptionUpdate")
        {
        }

        public WebhookSubscriptionUpdateOperationQueryBuilder(string name) : base(new Query<WebhookSubscriptionUpdatePayload>(name))
        {
            Arguments = new WebhookSubscriptionUpdateArgumentsBuilder(base.InnerQuery);
        }

        public WebhookSubscriptionUpdateOperationQueryBuilder(IQuery<WebhookSubscriptionUpdatePayload> query) : base(query)
        {
            Arguments = new WebhookSubscriptionUpdateArgumentsBuilder(base.InnerQuery);
        }

        public WebhookSubscriptionUpdateOperationQueryBuilder UserErrors(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder> build)
        {
            var query = new Query<UserError>("userErrors");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.UserErrorQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<UserError>(query);
            return this;
        }

        public WebhookSubscriptionUpdateOperationQueryBuilder WebhookSubscription(Action<ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebhookSubscriptionQueryBuilder> build)
        {
            var query = new Query<WebhookSubscription>("webhookSubscription");
            var queryBuilder = new ShopifySharp.GraphQL.Generated.QueryBuilders.Types.WebhookSubscriptionQueryBuilder(query);
            build.Invoke(queryBuilder);
            base.InnerQuery.AddField<WebhookSubscription>(query);
            return this;
        }
    }
}